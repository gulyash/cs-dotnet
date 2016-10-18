using dotnetlab3.Baking;
using dotnetlab3.Kitchen;

namespace dotnetlab3.Factories
{
    
    interface IPastryFactory<in P, out T> where T:AbstractBaking where P:Pastry //поддержка обобщений в существующих интерфейсах проекта
    {
       T bake(P pastry, Filling fill);
    }
}
