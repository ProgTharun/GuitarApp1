using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAPP.Model
{
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public string builder { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Backwood { get; set; }
        public string Topwood { get; set; }

        public Guitar(string serialNumber, double price, string builder, string model, string type, string backwood, string topwood)
        {
            SerialNumber = serialNumber;
            Price = price;
            builder = builder;
            Model = model;
            Type = type;
            Backwood = backwood;
            Topwood = topwood;
        }

        public string GetSerialNumber()
        {

            return SerialNumber;
        }
        public double GetPrice()
        {
            return Price;
        }
        public string GetBuilder()
        {
            return builder;
        }
        public string GetModel()
        {
            return Model;
        }
        public string GetType()
        {
            return Type;
        }
        public string GetBackwood()
        {
            return Backwood;
        }
        public string GetTopWood() { return Topwood; }
        public override string ToString()
        {
            return $"Serialnumber:{SerialNumber}\n" +
            $"Price:{Price}\n" +
                $"Builder:{builder}\n" +
                $"Model:{Model}\n" +
                $"Type:{Type} \n" +
                $"Backwood:{Backwood} \n" +
                $"TopWood{Topwood} \n";
        }

    }

}
