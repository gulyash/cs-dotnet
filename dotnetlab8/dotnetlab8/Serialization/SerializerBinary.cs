using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Serialization
{
    public class SerializerBinary: ISerializer
    {
        private readonly BinaryFormatter formatter;

        public SerializerBinary()
        {
            formatter = new BinaryFormatter();
        }

        public Fridge Deserialize(string path)
        {
            
            using (var fs = new FileStream(path, FileMode.Open))
            {
                Console.WriteLine("Fridge deserialized from binary file.");
                return (Fridge)formatter.Deserialize(fs);
            }
        }

        public void Serialize(Fridge fridge, string path)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (var fs = new FileStream(path, FileMode.Create))
            {
                binFormat.Serialize(fs, fridge);
            }
            Console.WriteLine("Fridge saved to binary file.");

        }

    }
}
