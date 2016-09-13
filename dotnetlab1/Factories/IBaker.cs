using System;

namespace dotnetlab1
{
    interface IBaker
    {
        Bun bakeBun(string filling);

        Pie bakePie(string filling);
    }
}
