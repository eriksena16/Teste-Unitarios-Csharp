using MyProject;
using Xunit;

namespace MyProjectXunit
{
    public class BancoTest
    {
        [Fact]
        public void Sacar()
        {
            double saldo = 700;
            double valor = 620;

            var conta = new Conta();
            conta.Saldo = saldo;

            bool expected = true;

            var result = conta.Sacar(valor);

            Assert.Equal(expected, result);

        }
        [Fact]
        public void Depositar()
        {
            double saldo = 600;
            double valor = 130;

            var conta = new Conta();
            conta.Saldo = saldo;

            bool expected = true;

            var result = conta.Depositar(valor);

            Assert.Equal(expected, result);

        }
        [Fact]
        public void AdicionarConta()
        {

            var conta = new Conta
            {
                Titular = new Cliente("Erik"),
                Numero = 156,
                Saldo = 50
            };


            bool expected = true;

            var result = conta.AdicionarConta(conta);

            Assert.Equal(expected, result);

        }
    }
}
