using dotnetlab5.Baking;
using dotnetlab5.Kitchen;

namespace dotnetlab5.Factories
{
    
    interface IPastryFactory<in P, out T> where T:AbstractBaking where P:Pastry //поддержка обобщений в существующих интерфейсах проекта
    {
       T bake(P pastry, Filling fill);
    }
}
