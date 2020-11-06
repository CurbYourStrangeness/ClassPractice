using System;
using System.Collections.Generic;
using System.Text;

namespace ClassConceptExpansion0
{
    class address
    {
        public string streetAddr { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int zCode { get; set; }

        public string FullAddr
        {
            get
            {
                return string.Format($"{streetAddr}, {city}, {state}, {zCode}");
            }
        }
    }
}
