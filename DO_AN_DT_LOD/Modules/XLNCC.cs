using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_DT_LOD.Modules
{
    class XLNCC : XLBANG
    {
        public XLNCC() : base("NHA_CC") { }
        public XLNCC(string pQuery) : base("NHA_CC", pQuery) { }

    }
}
