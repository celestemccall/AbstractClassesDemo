using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Vehicles



            var vehicles = new List<Vehicle>();

            Car infiniti = new Car()
            {
                HasTrunk = true,
                Make = "Infiniti",
                Model = "G37",
                Year = 2009
            };

            Motorcycle Ryker = new Motorcycle()
            {
                HasSideCart = false,
                Make = "Can-am",
                Model = "Ryker 900",
                Year = 2020
            };

            Vehicle sedan = new Car()
            {
                HasTrunk = true,
                Make = "Ford",
                Model = "Focus",
                Year = 2007
            };

            Vehicle coupe = new Car()
            {
                HasTrunk = true,
                Make = "Acura",
                Model = "Integra",
                Year = 1995
            };

            vehicles.Add(infiniti);
            vehicles.Add(Ryker);
            vehicles.Add(sedan);
            vehicles.Add(coupe);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make} Model: {veh.Model} Year: {veh.Year}");
                veh.DriveAbstract();
                veh.DriveVirtual();
                Console.WriteLine("--------------------------------------");
            }




            #endregion            
            Console.ReadLine();
        }
    }
}
