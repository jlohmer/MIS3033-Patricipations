﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__GOT_Quote
{
    class GoT_API
    {
        public string quote { get; set; }
        public string character { get; set; }

        public override string ToString()
        {
            return $"{quote} -{character}";
        }
    }
}
