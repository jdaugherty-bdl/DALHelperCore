using System;
using System.Collections.Generic;
using System.Text;

namespace DALHelperCore.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class DALTable : Attribute
    {
        private string _tableName;

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        public DALTable(string TableName)
        {
            _tableName = TableName;
        }
    }
}
