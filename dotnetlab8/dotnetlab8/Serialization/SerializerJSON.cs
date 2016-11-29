using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab8.Kitchen;
using Newtonsoft.Json;

namespace dotnetlab8.Serialization
{
    public class SerializerJSON: ISerializer
    {
        private JsonSerializer ser = new JsonSerializer();
        
        public Fridge Deserialize(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string json = sr.ReadLine();

            Fridge fridge = JsonConvert.DeserializeObject<Fridge>(json);

            Console.WriteLine("Deserialized from JSON.");

            return fridge;
        }
        
        public void Serialize(Fridge fridge, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                ser.Serialize(writer, fridge);
            }

            Console.WriteLine("Saving to JSON.");
        }

    }
}
