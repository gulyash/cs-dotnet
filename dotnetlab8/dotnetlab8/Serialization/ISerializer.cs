using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Serialization
{
    public interface ISerializer
    {
        void Serialize(Fridge fridge, string path);

        Fridge Deserialize(string path);
    }
}
