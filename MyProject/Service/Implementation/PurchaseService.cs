using Microsoft.Extensions.DependencyInjection;
using MyProject.Repository;
using MyProject.Repository.Interface;
using MyProject.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.Service
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _repository;
        public PurchaseService()
        {
            var service = new ServiceCollection();
            service.AddTransient<IPurchaseRepository, PurchaseRepository>();
            var provider = service.BuildServiceProvider();

            _repository = provider.GetService<IPurchaseRepository>();
        }

        public bool Add(Purchase obj)
        {
            if (!_repository.PurchaseExists(obj))
            {
                _repository.Add(obj);
                return true;
            }
            else
                return false;

        }
     
        public bool Update(Purchase obj)
        {
            if (!_repository.PurchaseExists(obj))
            {
                _repository.Update(obj);
                return true;
            }
            else
                return false;

        }
        public List<Purchase> Get()
        {
            return _repository.Get();
        }
    }
}
