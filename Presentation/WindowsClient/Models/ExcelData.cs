﻿using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Rems.Application.Common.Extensions;
using Rems.Application.CQRS;

namespace WindowsClient.Models
{
    /// <summary>
    /// Manages data taken from an excel spreadsheet
    /// </summary>
    public interface IExcelData<TData> : IDisposable
        where TData : IDisposable
    {
        /// <summary>
        /// The raw data
        /// </summary>
        TData Data { get; }

        /// <summary>
        /// The name of the data
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The table which the data is sourced from
        /// </summary>
        DataTable Source { get; }

        /// <summary>
        /// The state of the data
        /// </summary>
        PropertyCollection State { get; }

        /// <summary>
        /// If the data is a column, swap its position to the given index
        /// </summary>
        void Swap(int index);
    }

    public abstract class BaseExcelData<TData> : IExcelData<TData>
        where TData : IDisposable
    {
        public TData Data { get; protected set; }
        
        public abstract string Name { get; set; }
        public abstract DataTable Source { get; }
        public abstract PropertyCollection State { get; }

        public abstract void Swap(int index);

        #region Disposable
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Data.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class ExcelTable : BaseExcelData<DataTable>
    {
        /// <inheritdoc/>
        public override string Name
        {
            get => Data.TableName;
            set => Data.TableName = value;
        }

        /// <inheritdoc/>
        public override DataTable Source => Data;

        /// <inheritdoc/>
        public override PropertyCollection State => Data.ExtendedProperties;

        public ExcelTable(DataTable table)
        {
            Data = table;
            State["Ignore"] = false;
            State["Valid"] = true;            
        }

        /// <inheritdoc/>
        public override void Swap(int i)
        {
            throw new NotImplementedException("Cannot swap the ordinal of a table");
        }
    }

    public class ExcelColumn : BaseExcelData<DataColumn>
    {
        /// <inheritdoc/>
        public override string Name
        {
            get => Data.ColumnName;
            set => Data.ColumnName = value;
        }

        /// <inheritdoc/>
        public override DataTable Source => Data.Table;

        /// <inheritdoc/>
        public override PropertyCollection State => Data.ExtendedProperties;

        public ExcelColumn(DataColumn column)
        {
            Data = column;

            var info = column.FindProperty();
            State["Info"] = info;
            State["Ignore"] = false;
            State["IsTrait"] = false;
        }

        /// <inheritdoc/>
        public override void Swap(int index)
        {
            Data.SetOrdinal(index);
        }

        /// <summary>
        /// Tests if the column is referring to a known database trait
        /// </summary>
        public async Task CheckIfTrait()
        {
            // Test if the trait is in the database
            bool inDB = await QueryManager.Request(new TraitExistsQuery() { Name = Data.ColumnName });

            // Test if the trait is in the excel data
            bool inExcel()
            {
                // Is there a traits table
                if (Data.Table.DataSet.Tables["Traits"] is not DataTable traits)
                    return false;

                // Is there a column with trait names
                if (traits.Columns["Name"] is not DataColumn name)
                    return false;

                var rows = traits.Rows.Cast<DataRow>();
                var trait = Data.ColumnName.ToLower();

                return rows.Any(r => r[name].ToString().ToLower() == trait);
            };

            State["IsTrait"] = inDB || inExcel();
        }
    }
}
