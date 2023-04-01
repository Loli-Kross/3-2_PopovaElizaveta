using System;
using System.Collections.Generic;
using System.Text;

namespace Pz_5_Interface
{
    enum Otdel_name
    {
        Otdel_Kadrov,
        Otdel_Analitiky,
        Otdel_Prodazh
    }
    internal class Otdel 
    {
        
        private Otdel_name otdel;
        public Otdel_name OTdel { get { return otdel; } set { otdel = value; } }
        public override string ToString()
        {
            return $"{otdel}";
        }
    }
}
