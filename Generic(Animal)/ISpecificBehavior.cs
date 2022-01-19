using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal_
{
    interface ITypeSpecificBehavior<T>
    {
        string GetTypeSpecificBehavior<T>(T Data) where T : Animal;//ContraVarient
    }
}
