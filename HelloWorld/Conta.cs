using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Conta
    {
         private double Saldo;

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo = valor;

            }
        }
        
        public double Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                return this.Saldo -= valor;

            }
            return 0;
        }

        public double GetSaldo(){
            return this.Saldo;
        }

        
    }
}