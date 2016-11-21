using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab6.Kitchen;

namespace dotnetlab6.Serialization
{
    interface ISerializer
    {
        void Serialize(Fridge fridge, string path);

        Fridge Deserialize(string path);
    }
}
