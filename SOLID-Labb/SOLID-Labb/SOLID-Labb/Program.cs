using System;

namespace SOLID_Labb
{
    class Program
    {
     
       public void Animals()
        {
            Animal[] animals = {new Dog("Black"),
             new Hedgehog("Pink"),
             new Bird("Yellow")};
        }

        public void spam(Animal[] animals)
        {
            Console.WriteLine("###############");
            Console.WriteLine();
        }

        public void dogTransferOwnership(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    dog.TransferOwnership("Niklas");
                }
            }
        }

        private void Animaleat(animal)
        {
            Animal.Eat();
        }

         void AnimalSleep()
        {
            animal.Sleep();
        }

        private void AnimalSpeak()
        {
            animal.Speak();
        }

        private void AnimalColor()
        {
            animal._color = "Grey";
            Console.WriteLine(animal.GetType().Name + " is " + animal._color);
            Console.WriteLine();
        }


        
    }
}


