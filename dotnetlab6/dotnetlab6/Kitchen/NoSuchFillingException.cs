using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab6.Kitchen
{
    class NoSuchFillingException :ApplicationException
    {
        public string name;

        public NoSuchFillingException(string n) {
            name = n;
        }
    }
}
