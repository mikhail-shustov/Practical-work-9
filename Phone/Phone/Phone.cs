using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class Phone
    {
        private string brand;
        private int batteryLevel;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    brand = value;
                }
            }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0 && value > 100)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    batteryLevel = value;
                }
            }
        }
        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void UsePhone()
        {
            int Level = batteryLevel - 10;
            Console.WriteLine($"Телефон {brand}, заряд: {Level}%");
        }
    }
}
