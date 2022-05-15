using System;

namespace MyProject
{
    public class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        private int numeroDeContas;
        private Conta[] Contas;

        public bool Sacar(double valor)
        {
            if (Saldo > valor)
            {
                return true;
            }
            else
               throw new ArgumentException(Saldo.ToString() + "<" + valor.ToString(), "Saldo Insuficiente");

        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            else return false;

        }

        public bool AdicionarConta(Conta conta)
        {
           
           var condicao = conta != null
               && conta.Numero != 0
               && conta.Titular != null
               && conta.Titular.Nome != null
               && conta.Titular.Nome.Length >= 3
               && conta.Saldo >= 50;

            if (condicao)
                return true;
            else
                throw new ArgumentException(nameof(conta),"Verifique seu dados");

        }
    }

    public class ContaPoupanca : Conta
    {
        //public override bool Sacar(double valor)
        //{
        //    //this.Saldo -= (valor + 0.05);
        //    return true;
        //}

    }

    public class ContaCorrente : Conta
    {
        //public override bool Sacar(double valor)
        //{
        //    //this.Saldo += (valor + 0.10);
        //    return false;
        //}

        //public override void Depositar(double valor)
        //{
        //    this.Saldo += (valor - 0.05);
        //}

    }
}
