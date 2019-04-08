using ClothingStore.Model;
using System.Collections.Generic;

namespace ClothingStore.Service
{
    public interface IService
    {
        List<Supplier> GetListSupplier();

        Order MakeOrder(Supplier supplier);
        
    }
}
