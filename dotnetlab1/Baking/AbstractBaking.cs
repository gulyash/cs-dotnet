using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1.Baking
{
    abstract class AbstractBaking
    {
        public string Pastry { get; set; }
        public string Filling { get; set; }
        public int Weight { get; set; }
    }
}
