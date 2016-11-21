using dotnetlab6.Baking;
using dotnetlab6.Kitchen;

namespace dotnetlab6.Factories
{
    
    interface IPastryFactory<in P, out T> where T:AbstractBaking where P:Pastry //поддержка обобщений в существующих интерфейсах проекта
    {
       T bake(P pastry, Filling fill);
    }
}
