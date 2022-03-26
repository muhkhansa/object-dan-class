using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name :{0} ", DriverName);
            Console.WriteLine("Taxi On Duty :{0} ", OnDuty);
            Console.WriteLine("Number Passenger :{0} ", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang dalam Perjalanan", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0}Selesai mengantar penumpang", DriverName);
        }
    }
}
