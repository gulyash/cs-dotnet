using dotnetlab8.Baking;
using dotnetlab8.Kitchen;

namespace dotnetlab8.Factories
{
    
    public interface IPastryFactory<in P, out T> where T:AbstractBaking where P:Pastry //поддержка обобщений в существующих интерфейсах проекта
    {
       T bake(P pastry, Filling fill);
    }
}
