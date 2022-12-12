using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird ostrich = new Bird();
            ostrich.Heterotrophic = true;
            ostrich.TypeOfConsumer = "herbivore";
            ostrich.HasDeterminedBodyPlan = true;
            ostrich.IsMotile = true;
            ostrich.Endothermic = true;
            ostrich.HasFeathers = true;
            ostrich.HasBeak = true;
            ostrich.ProducesHardShelledEggs = true;
            Console.WriteLine("Ostrich:");
            ostrich.PrintAnimalDetails();
            ostrich.PrintBirdDetails();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile turtle = new Reptile()
            {
                Heterotrophic = true,
                TypeOfConsumer = "omnivore",
                HasDeterminedBodyPlan = true,
                IsMotile = true,
                HasScales = true,
                Ectothermic = true,
                HasTeeth = false,
                Precocial = true
            };
            Console.WriteLine("Turtle:");
            turtle.PrintAnimalDetails();
            turtle.PrintReptileDetails();
        }
    }
}
