using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using dotnetlab6.Kitchen;
using Newtonsoft.Json;

namespace dotnetlab6.Serialization
{
    class SerializerXML:ISerializer
    {
        private readonly XmlSerializer formatter = new XmlSerializer(typeof(Fridge));
        public SerializerXML()
        {
            
        }

        public Fridge Deserialize(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                Console.WriteLine("Fridge deserialized from XML file.");
                Fridge fridge = (Fridge)formatter.Deserialize(fs);
                return fridge;
            }
        }

        public void Serialize(Fridge fridge, string path)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, fridge);
            }
            Console.WriteLine("Fridge saved to XML file.");
        }
    }
}
