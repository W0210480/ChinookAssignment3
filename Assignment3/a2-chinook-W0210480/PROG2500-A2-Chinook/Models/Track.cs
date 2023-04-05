using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{
    public partial class Track
    {
        public string FormattedComposer { get { return string.IsNullOrEmpty(Composer) ? "Composer: None found" : string.Format("Composer: {0}", Composer); } }

        public string FormattedInfoBlock { get { return string.Format
                    ("Length: {0:N2} ms\nSize: {1:N2} bytes\nPrice: ${2}", Milliseconds, Bytes, UnitPrice); } }
    }
}
