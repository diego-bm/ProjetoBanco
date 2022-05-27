using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Classes
{
    class Poupanca : Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo) : base (cliente, numero, saldo)
        {

        }

        public override bool Sacar(decimal valorSaque)
        {
            if (valorSaque <= 0m)
            {
                Mensagem = "Valor de saque inválido!";
                return false;
            }

            if (valorSaque > Saldo)
            {
                Mensagem = "Saldo Insuficiente";
                return false;
            }

            Saldo -= valorSaque;
            Mensagem = "Saque efetuado com sucesso";
            return true;
        }

        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0m)
            {
                Mensagem = "Saldo Insuficiente";
                return false;
            }

            if (valorDeposito < Saldo)
            {
                Mensagem = "Saldo Insuficiente";
                return false;
            }
            Saldo += valorDeposito;

            if (valorDeposito > 1000)
            {
                Saldo += valorDeposito * 0.05m;
            }

            return true;
        }

        public override string ToString() => $"Cliente: {Cliente} | Numero: {Numero} | Saldo: {Saldo} --- Sobrecrita de: { base.ToString()}";
    }
}
