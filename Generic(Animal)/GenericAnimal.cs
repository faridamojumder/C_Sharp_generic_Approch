using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal_
{
    public class GenericAnimal<T>:IGenericBehavior<T>
    {
        public string GetGenericBehavior(T Obj)
        {
            string behavior = string.Empty;
            if (Obj is Animal)
            {
                Animal a = Obj as Animal;
                switch (a.Type)
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
            }
            else
            {
                behavior = "Not an Animal";
            }
            return behavior;
        }

    }
}
