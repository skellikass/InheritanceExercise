using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public bool Ectothermic { get; set; }
        public bool HasTeeth { get; set; }
        public bool Precocial { get; set; }
        public void PrintReptileDetails()
        {
            Console.WriteLine($"It has scales: {HasScales}");
            Console.WriteLine($"It is ectothermic: {Ectothermic}");
            Console.WriteLine($"It has teeth: {HasTeeth}");
            Console.WriteLine($"It is precocial: {Precocial}");
        }
    }
}
