﻿using Rems.Application.Common.Interfaces;
using Rems.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Rems.Application.Common.Extensions
{
    public static class DataExtensions
    {
        public static void RemoveDuplicateRows(this DataTable table, IEqualityComparer<DataRow> comparer = null)
        {
            if (comparer == null) 
                comparer = new DataRowItemComparer();

            var rows = table.Rows.Cast<DataRow>()
                .Distinct(comparer)
                .Select(r => r.ItemArray)
                .ToArray();

            table.Rows.Clear();
            foreach (var row in rows) table.Rows.Add(row);
        }

        public static IEntity ToEntity(this DataRow row, IRemsDbContext context, Type type, PropertyInfo[] infos)
        {
            IEntity entity = Activator.CreateInstance(type) as IEntity;

            foreach (var info in infos)
            {
                var value = row[info.Name];

                // Use default value if DBNull
                if (value is DBNull) continue;

                var itype = info.PropertyType;

                // Is the property an entity?
                if (typeof(IEntity).IsAssignableFrom(itype)) 
                {
                    // Does the entity already exist?
                    if (context.FindMatchingEntity(itype, value) is IEntity e) 
                    {
                        info.SetValue(entity, e);
                        continue;
                    }

                    // If the entity was not found, assume that it was referred
                    // to by name, and create a new entity using the given value
                    INamed named = Activator.CreateInstance(itype) as INamed;
                    named.Name = value.ToString();

                    info.SetValue(entity, named);

                    context.Attach(named);
                    context.SaveChanges();
                }
                else
                {
                    entity.SetValue(info, value);
                }
            }

            return entity;
        }
        
        /// <summary>
        /// A bunch of ugly string matching to find a property because unfiltered excel data
        /// </summary>
        public static PropertyInfo FindProperty(this DataColumn col)
        {
            var type = col.Table.ExtendedProperties["Type"] as Type;

            // Test for a direct match
            if (type.GetProperty(col.ColumnName) is PropertyInfo x)
                return x;

            // Test if the column is called name
            if (col.ColumnName == type.Name && type.GetProperty("Name") is PropertyInfo y)
            {
                col.ColumnName = "Name";
                return y;
            }

            // Trim the column and look for direct match again
            var name = col.ColumnName.Replace("Name", "").Replace("name", "").Trim();
            if (type.GetProperty(name) is PropertyInfo z)
            {
                col.ColumnName = name;
                return z;
            }

            // Assume its called name
            if (name == type.Name)
            {
                col.ColumnName = "Name";
                return type.GetProperty("Name");
            }

            // Assume the column has the type name attached
            var prop = col.ColumnName.Replace(type.Name, "").Trim();
            if (type.GetProperty(prop) is PropertyInfo i)
            {
                col.ColumnName = prop;
                return i;
            }

            // If no property was found
            return null;
        }
    }

    public class DataRowItemComparer : IEqualityComparer<DataRow>
    {
        public bool Equals(DataRow x, DataRow y)
        {
            var xItems = x.ItemArray;
            var yItems = y.ItemArray;

            if (xItems.Length != yItems.Length) return false;

            for (int i = 0; i < xItems.Length; i++)
            {
                if (!Equals(xItems[i], yItems[i])) return false;
            }

            return true;
        }

        public int GetHashCode(DataRow obj)
        {
            unchecked
            {
                if (obj.ItemArray == null) return 0;

                int hash = 17;

                foreach (var o in obj.ItemArray)
                {
                    hash *= 31;
                    hash += o.GetHashCode();
                }
                return hash;
            }
        }
    }
}
