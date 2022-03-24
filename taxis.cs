using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_app
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine($"Driver name = {DriverName}");
            if(OnDuty == true)
            {
                Console.WriteLine($"On Duty = yes");
            } 
            else
            {
                Console.WriteLine($"On Duty = no");
            }
            Console.WriteLine($"Number Of Pasanger = {NumPassanger}");
        }

        public void PickUpPassanger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine($"{DriverName} sedang menjamput penumpang");
            } 
            else
            {
                Console.WriteLine($"{DriverName} tidak sedang menjamput penumpang");
            }
        }

        public void DropOffPassanger()
        {
            if (NumPassanger != 0)
            {
                Console.WriteLine($"{DriverName} selesai mengantar penumpang");
            }
            else
            {
                Console.WriteLine($"{DriverName} belom selesai penumpang");
            }
        }
    }
}
