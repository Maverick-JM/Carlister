using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlister.Common.Enums
{
    public enum PriceType
    {
        [Description("Price on Application")]
        POA,
        [Description("Excluding Government Charges")]
        EGC,
        [Description("Drive Away Price")]
        DAP
    }
}
