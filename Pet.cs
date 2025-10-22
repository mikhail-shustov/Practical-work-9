using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    internal class Pet
    {
        internal class pet
        {
            private string name;
            private int energy;
            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Energy
            {
                get => energy;
                set
                {
                    if (value < 0)
                        energy = 0;
                    else if (value > 100)
                        energy = 100;
                    else
                        energy = value;
                }
            }
            public pet(string name, int energy)
            {
                Name = name;
                Energy = energy;
            }
            public void Play()
            {
                Energy -= 20;
                Console.WriteLine($"{Name} играет, энергия: {Energy}.");
            }
            public void Rest()
            {
                Energy += 30;
                Console.WriteLine($"{Name} отдыхает, энергия: {Energy}.");
            }
        }
    }
}
