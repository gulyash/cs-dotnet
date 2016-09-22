using System;
using dotnetlab1.Baking;

namespace dotnetlab1.Factories
{
    interface IBaker
    {
        Bun bakeBun(string filling);

        Pie bakePie(string filling);
    }
}
