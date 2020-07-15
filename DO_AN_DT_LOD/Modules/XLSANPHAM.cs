using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_DT_LOD.Modules
{
    class XLSANPHAM:XLBANG
    {
            public XLSANPHAM() : base("SANPHAM") { }
            public XLSANPHAM(string pQuery) : base("SANPHAM", pQuery) { }
        
    }
}
