﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetlab2.Baking;
using dotnetlab2.Kitchen;

namespace dotnetlab2.Factories
{
    interface IPastryFactory<in P, out T> where T:AbstractBaking //where P:Pastry //поддержка обобщений в существующих интерфейсах проекта
    {
        T bake(P pastry, Filling fill);
    }
}
