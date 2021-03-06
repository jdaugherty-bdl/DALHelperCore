using DALHelperCore.Interfaces.Attributes;
using DALHelperCore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALHelperCore.InternalClasses.Models
{
    internal class DALTableRowDescriptor : DALBaseModel
    {
        [DALResolvable]
        public string Field { get; set; }
        [DALResolvable]
        public string Type { get; set; }
        [DALResolvable]
        public string Null { get; set; }
        [DALResolvable]
        public string Key { get; set; }
        [DALResolvable]
        public string Default { get; set; }
        [DALResolvable]
        public string Extra { get; set; }

        public DALTableRowDescriptor() : base() { }
        private static string ThisTypeName => typeof(DALTableRowDescriptor).Name;
        public DALTableRowDescriptor(DataRow TrackerRow, string AlternateTableName = null) : base(TrackerRow, AlternateTableName ?? ThisTypeName) { }
    }
}
