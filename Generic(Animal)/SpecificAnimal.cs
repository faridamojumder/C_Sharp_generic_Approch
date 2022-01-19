using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal_
{
    public class TypeSpecificAnimal<T> : ITypeSpecificBehavior<T>
    {
        public string GetTypeSpecificBehavior<T>(T data) where T : Animal
        {
            string behavior = string.Empty;

            switch (data.Type)
            {
                case AnimalType.Harvivore:
                    behavior = "Lives on harvs,four footed";
                    break;
                case AnimalType.Carnivore:
                    behavior = "hAVE CANINE,MEET EATER";
                    break;
                case AnimalType.Omnivore:
                    behavior = "Diveres eating behavior,adaptable";
                    break;
                default:
                    behavior = "Unknown behavior";
                    break;
            }

            return behavior;
        }

    }
}
