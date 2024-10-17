using GuitarAPP.Model;
using GuitarAPP.Servivce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAPP.Controller
{
    public class Inventory
    {
        static List<Guitar> guitars = Serializer.Deserialize();
        public Inventory()
        {
            new List<Guitar>();
        }
        public void DisplayGuitar()
        {
            if (guitars.Count == 0)

                return;

            foreach (var guitar in guitars)
            {
                Console.WriteLine(guitar);

            }

        }
        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backwood, string topwood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backwood, topwood);
            guitars.Add(guitar);
            Serializer.Serialization(guitars);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            var num = guitars.Find(m => m.SerialNumber.Equals(serialNumber));
            return num;

        }
        public static List<Guitar> SearchGuitar(Guitar searchGuitar)
        {
          return guitars.FindAll(g =>
                (string.IsNullOrEmpty(searchGuitar.SerialNumber) || g.SerialNumber.Equals(searchGuitar.SerialNumber)) &&
                (searchGuitar.Price == 0 || g.Price == searchGuitar.Price) &&
                (string.IsNullOrEmpty(searchGuitar.builder) || g.builder.Equals(searchGuitar.builder)) &&
                (string.IsNullOrEmpty(searchGuitar.Model) || g.Model.Equals(searchGuitar.Model)) &&
                (string.IsNullOrEmpty(searchGuitar.Type) || g.Type.Equals(searchGuitar.Type)) &&
                (string.IsNullOrEmpty(searchGuitar.Backwood) || g.Backwood.Equals(searchGuitar.Backwood)) &&
                (string.IsNullOrEmpty(searchGuitar.Topwood) || g.Topwood.Equals(searchGuitar.Topwood))
            );
            Serializer.Serialization(guitars);
        }
        public void Exit()
        {
            Serializer.Serialization(guitars);
            Environment.Exit(0);
        }
    }
}
