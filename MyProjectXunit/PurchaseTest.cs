using Microsoft.Extensions.DependencyInjection;
using MyProject;
using MyProject.Service;
using MyProject.Service.Interface;
using Xunit;

namespace MyProjectXunit
{

    public class PurchaseTest
    {
        private readonly IPurchaseService _purchaseService;
        public PurchaseTest()
        {
            var service = new ServiceCollection();
            service.AddTransient<IPurchaseService, PurchaseService>();
            var provider = service.BuildServiceProvider();

            _purchaseService = provider.GetService<IPurchaseService>();
        }

        [Fact]
        public void AdicionarCompraComSucesso()
        {
            Purchase  newpurchase = new Purchase { Id = 6, AccountId = 19, CompanyId = 120, DocumentId = 3, DocumentNumber = "7842", OperationId = 12, SupplierId = 30 };

            bool expected = true;

            var result = _purchaseService.Add(newpurchase);

            Assert.Equal(expected, result);

        }
        [Fact]
        public void AdicionarCompraSemSucesso()
        {
            Purchase purchase = new Purchase { Id = 7, AccountId = 19, OperationId = 209, CompanyId = 120, DocumentId = 10, DocumentNumber = "3564", SupplierId = 152 };

            bool expected = false;

            var result = _purchaseService.Add(purchase);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void UpdateCompraComSucesso()
        {
           var purchaseUpdate = new Purchase { Id = 2, AccountId = 12, OperationId = 25, CompanyId = 69, DocumentId = 11, DocumentNumber = "4588", SupplierId = 1678 };

            bool expected = true;

            var result = _purchaseService.Update(purchaseUpdate);

            Assert.Equal(expected, result);

        }
        [Fact]
        public void UpdateCompraSemSucesso()
        {
            var purchaseUpdate = new Purchase { Id = 5, AccountId = 19, OperationId = 78, CompanyId = 120, DocumentId = 56, DocumentNumber = "54575", SupplierId = 152 };

            bool expected = false;

            var result = _purchaseService.Update(purchaseUpdate);

            Assert.Equal(expected, result);
        }

    }
}
