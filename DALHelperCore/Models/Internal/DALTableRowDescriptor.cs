using DALHelperCore.Interfaces.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DALHelperCore.Models.Internal
{
    /// <summary>
    /// This class is used to gather information about database tables and their columns to enable automatic bulk table writes.
    /// </summary>
    internal class DALTableRowDescriptor : DALBaseModel
    {
        [DALProperty]
        public string Field { get; set; }
        [DALProperty]
        public string Type { get; set; }
        [DALProperty]
        public string Null { get; set; }
        [DALProperty]
        public string Key { get; set; }
        [DALProperty]
        public string Default { get; set; }
        [DALProperty]
        public string Extra { get; set; }

        public DALTableRowDescriptor() : base() { }
        public DALTableRowDescriptor(DataRow TrackerRow, string AlternateTableName = null) : base(TrackerRow, AlternateTableName) { }
    }
}
