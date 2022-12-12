using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool Endothermic { get; set; }
        public bool HasFeathers { get; set; }  
        public bool HasBeak { get; set; }
        public bool ProducesHardShelledEggs { get; set; }
        public void PrintBirdDetails()
        {
            Console.WriteLine($"It is endothermic: {Endothermic}");
            Console.WriteLine($"It has feathers: {HasFeathers}");
            Console.WriteLine($"It has a beak: {HasBeak}");
            Console.WriteLine($"It produces hard-shelled eggs: {ProducesHardShelledEggs}");
        }
    }
}
