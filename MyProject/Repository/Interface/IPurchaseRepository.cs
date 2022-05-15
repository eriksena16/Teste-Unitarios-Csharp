using System.Collections.Generic;

namespace MyProject.Repository.Interface
{
    public interface IPurchaseRepository
    {
        void Add(Purchase obj);
        List<Purchase> Get();
        bool PurchaseExists(Purchase obj);
        void Update(Purchase obj);
    }
}
