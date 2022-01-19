using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal_
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal
            {
                Name = "Cow",
                Age = 3,
                Type = AnimalType.Harvivore, 
                Sex = Gender.Female
            };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericBehavior(cow));
            Animal bear = new Animal { Name = "Geizzy", Age = 4, Type = AnimalType.Omnivore, Sex = Gender.Male };
            TypeSpecificAnimal<Animal> Obj2 = new TypeSpecificAnimal<Animal>();
            Console.WriteLine(Obj2.GetTypeSpecificBehavior(bear));
            Console.ReadLine();
        }
    }
}

