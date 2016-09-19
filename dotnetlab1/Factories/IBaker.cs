using System;

namespace dotnetlab1
{
    /// <summary>
    /// describes what each baker must do
    /// </summary>
    interface IBaker
    {
        Bun bakeBun(string filling);

        Pie bakePie(string filling);
    }
}
