using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab_4
{
    internal class JsonAction
    {
        JsonAction() { }
        public static List<Biathlete> DeserialiseFromJson(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return JsonSerializer.Deserialize<List<Biathlete>>(fs);
            }
        }
        public static void SerializeToJson(String path, List<Biathlete> biath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fs, biath, options);
            }
        }
    }
}
