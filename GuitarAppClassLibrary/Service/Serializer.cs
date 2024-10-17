using GuitarAPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuitarAPP.Servivce
{
    internal class Serializer
    {
        static string filepath = "Tharun.json";
        public static void Serialization(List<Guitar> guitars)
        {
            var json = JsonSerializer.Serialize(guitars);
            File.WriteAllText(filepath, json);

        }
        public static List<Guitar> Deserialize()
        {
            if (!File.Exists(filepath))
            {
                return new List<Guitar>();
            }
            var json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<List<Guitar>>(json);
        }
    }
}