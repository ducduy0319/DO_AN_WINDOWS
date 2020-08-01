using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_DT_LOD.Modules
{
    class XLXEMSANPHAM:XLBANG
    {
        public XLXEMSANPHAM() : base("HOADONCT") { }
        public XLXEMSANPHAM(string pQuery) : base("HOADONCT", pQuery) { }
    }
}
