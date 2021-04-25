using System;
using System.Collections.Generic;
using System.Text;

namespace DALHelperCore.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct)]
    public sealed class DALProperty : Attribute
    {
        private string _columnName;

        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        public DALProperty(string ColumnName = null)
        {
            _columnName = ColumnName;
        }
    }
}
