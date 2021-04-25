using System;
using System.Collections.Generic;
using System.Text;

namespace DALHelperCore.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Struct)]
    public sealed class DALTransferProperty : Attribute
    {
    }
}
