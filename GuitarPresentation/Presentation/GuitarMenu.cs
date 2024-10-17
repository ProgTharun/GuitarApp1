using GuitarAPP.Controller;
using GuitarAPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAPP.Presentation
{
    internal class GuitarMenu
    {
        static Inventory manager = new Inventory();
        public static void Menu()
        {
            Console.WriteLine("===Welcome to Guitar Store=====");
            while (true)
            {
                Console.WriteLine("Enter Your Choices\n" +
                    "1.Display Guitar\n" +
                    "2.Add Guitar\n" +
                    "3.Get Guitar\n" +
                    "4.Search Guitar\n" +
                    "5.Exit");

                DoTask();
            }

        }
        public static void DoTask()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DisplayGuitar();
                    break;
                case 2:
                    AddGuitar();
                    break;
                case 3:
                    GetGuitar();
                    break;
                case 4:
                    SearchGuitars(manager);
                    break;
                case 5:
                    Exit();

                    break;
                default:
                    break;
            }


        }

        public static void DisplayGuitar()
        {
            manager.DisplayGuitar();
        }
        public static void AddGuitar()
        {
            Console.WriteLine("Enter Serial Number");
            string serialNumber = Console.ReadLine();
            Console.WriteLine("Enter Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Builder");
            string builder = Console.ReadLine();
            Console.WriteLine("Enter Model");
            string model = Console.ReadLine();
            Console.WriteLine("EnterType");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Backwood");
            string backwood = Console.ReadLine();
            Console.WriteLine("Enter TopWood");
            string topwood = Console.ReadLine();
            manager.AddGuitar(serialNumber, price, builder, model, type, backwood, topwood);
            Console.WriteLine("Details Added Succesfully");

        }
        public static void GetGuitar()
        {
            Console.WriteLine("Eneter Serial Number");
            string serialNumber = Console.ReadLine();
           var guitar= manager.GetGuitar(serialNumber);
            if(guitar==null)
            {
                Console.WriteLine("No Giutar Exsits");
            }
            else 
            {
                Console.WriteLine(guitar);
            }

        }


        public static void SearchGuitars(Inventory manager)
        {
            Console.Write("Enter Serial Number (leave empty if not applicable): ");
            string serialNumber = Console.ReadLine();
            Console.Write("Enter Price (0 if not applicable): ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Builder (leave empty if not applicable): ");
            string builder = Console.ReadLine();
            Console.Write("Enter Model (leave empty if not applicable): ");
            string model = Console.ReadLine();
            Console.Write("Enter Type (leave empty if not applicable): ");
            string type = Console.ReadLine();
            Console.Write("Enter Backwood (leave empty if not applicable): ");
            string backwood = Console.ReadLine();
            Console.Write("Enter Topwood (leave empty if not applicable): ");
            string topwood = Console.ReadLine();

            Guitar searchGuitar = new Guitar(serialNumber, price, builder, model, type, backwood, topwood);
            List<Guitar> matchingGuitars = Inventory.SearchGuitar(searchGuitar);

            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Matching Guitars:");
                foreach (var guitar in matchingGuitars)
                {
                    Console.WriteLine(guitar);
                }
            }
            else
            {
                Console.WriteLine("No matching guitars found.");
            }
        }
        public static void Exit()
        {
            manager.Exit();
        }
    }
}


