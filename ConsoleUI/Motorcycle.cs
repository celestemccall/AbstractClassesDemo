using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcyle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcyle has been fixed and is now driveable");
        }
    }
}

