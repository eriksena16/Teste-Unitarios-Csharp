using MyProject.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private List<Purchase> purchases = new List<Purchase>
           {
               new Purchase{ Id = 1, AccountId = 19,OperationId = 209, CompanyId = 120, DocumentId = 10, DocumentNumber = "3564", SupplierId = 152},
               new Purchase{ Id = 2, AccountId = 12,OperationId = 25, CompanyId = 69, DocumentId = 11, DocumentNumber = "5749", SupplierId = 652},
               new Purchase{ Id = 3, AccountId = 1,OperationId = 209, CompanyId = 78, DocumentId = 10, DocumentNumber = "5641", SupplierId = 32},
               new Purchase{ Id = 4, AccountId = 19,OperationId = 35, CompanyId = 120, DocumentId = 10, DocumentNumber = "9874", SupplierId = 45},
               new Purchase{ Id = 5, AccountId = 19,OperationId = 78, CompanyId = 120, DocumentId = 56, DocumentNumber = "54575", SupplierId = 152}
           };

        public void Add(Purchase obj)
        {
            var purchases = Get();

            purchases.Add(obj);
        }
        public void Update(Purchase obj)
        {
            var purchaseRemove = Get(obj.Id);
            Remove(purchaseRemove);
            Add(obj);
        }
        public void Remove(Purchase obj) => purchases.Remove(obj);
      
        public List<Purchase> Get() => purchases;

        public Purchase Get(long id)=> purchases.FirstOrDefault(c => c.Id == id);

        public bool PurchaseExists(Purchase obj) => purchases.Any(c => c.CompanyId == obj.CompanyId
            && c.AccountId == obj.AccountId
            && c.SupplierId == obj.SupplierId
            && c.DocumentId == obj.DocumentId
            && c.DocumentNumber.Equals(obj.DocumentNumber));
    }
}
