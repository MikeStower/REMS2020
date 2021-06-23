﻿using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rems.Application.Common;
using Rems.Application.CQRS;

namespace WindowsClient.Models
{
    public class TraitNode : DataNode<ExcelColumn, DataColumn>
    {
        public override bool Valid => Excel.Ignore || traitExists;

        private bool traitExists;

        public Func<Task> Add;

        public override string Key
        {
            get
            {
                string key = Valid ? "Valid" : "Invalid";
                key += Excel.Ignore ? "Off" : "On";

                return key;
            }
        }

        public TraitNode(ExcelColumn excel) : base(excel)
        {
            var ignore = new ToolStripMenuItem("Ignore", null, (s, e) => ToggleIgnore());
            Items.Add(ignore);

            EventHandler handler = async (s, e) => await Add.Invoke();
            var add = new ToolStripMenuItem("Add as trait", null, handler);            

            Items.Add(add);            
        }

        public async Task AddTrait()
        {
            if (Excel.Ignore)
                return;

            var query = new AddTraitCommand
            {
                Name = Excel.Data.ColumnName,
                Type = (Excel.Source.ExtendedProperties["Type"] as Type).Name
            };

            await QueryManager.Request(query);

            traitExists = true;
            Root.Refresh();
        }

        public async Task AddFactor()
        {
            if (Excel.Ignore)
                return;

            var query = new AddFactorCommand { Name = Excel.Data.ColumnName };
            await QueryManager.Request(query);

            traitExists = true;
            Root.Refresh();
        }

        /// <summary>
        /// Initialisation that can only be done after being added to a parent node
        /// </summary>
        public async Task Initialise()
        {
            if (Excel.Data.Table.TableName == "Design")
            {
                Parent.Text = "Factors";
                Add = AddFactor;
                Items[1].Text = "Add as factor";
                Parent.ContextMenuStrip.Items[0].Text = "Add all as factors";
            }
            else
                Add = AddTrait;

            if (Excel.Data is null)
            {
                traitExists = false;
                return;
            }                

            // Test if the trait is in the database
            bool inDB = await QueryManager.Request(new TraitExistsQuery() { Name = Excel.Data.ColumnName });

            traitExists = inDB || InExcel() || await IsFactor();
        }

        private bool InExcel()
        {
            // Is there a traits table
            if (Excel.Data.Table?.DataSet?.Tables["Traits"] is not DataTable traits)
                return false;

            // Is there a column with trait names
            if (traits.Columns["Name"] is not DataColumn name)
                return false;

            var rows = traits.Rows.Cast<DataRow>();
            var trait = Excel.Data.ColumnName.ToLower();

            return rows.Any(r => r[name].ToString().ToLower() == trait);
        }

        private async Task<bool> IsFactor()
            => await QueryManager.Request(new IsFactorQuery { Name = Excel.Data.ColumnName });
    }
}