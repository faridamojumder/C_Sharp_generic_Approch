﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Animal_
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T Obj);//covarient
    }

}
