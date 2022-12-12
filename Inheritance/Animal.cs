using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public bool Heterotrophic { get; set; }
        public string TypeOfConsumer { get; set; }  
        public bool HasDeterminedBodyPlan { get; set; }
        public bool IsMotile { get; set; }
        public void PrintAnimalDetails ()
        {
            Console.WriteLine($"This animal is heterotrophic: {Heterotrophic}");
            Console.WriteLine($"It is a {TypeOfConsumer}.");
            Console.WriteLine($"It has a determined body plan: {HasDeterminedBodyPlan}");
            Console.WriteLine($"It is motile: {IsMotile}");
        }
    }
}
