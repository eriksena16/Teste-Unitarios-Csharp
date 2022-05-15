using System.Collections.Generic;

namespace MyProject.Service.Interface
{
    public interface IPurchaseService
    {
        bool Add(Purchase obj);
        List<Purchase> Get();
        bool Update(Purchase obj);
    }
}
