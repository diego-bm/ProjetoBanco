using ProjetoBanco.Classes;
using System;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {            
            try
            {
                var cliente1 = Cliente.CreateCliente("Diego", "Rua dos Bardos nº 768", 16999222999, "999.999.999-99", new DateTime(2002, 08, 02));
                var cliente2 = Cliente.CreateCliente("Maurício", "Rua dos MARAVILHOSOS nº 10", 16999456999, "999.999.999-99", new DateTime(1997, 11, 20));
                Console.WriteLine(cliente1.ToString());

                var contaPoupanca = new Poupanca(cliente1, 12345, 2000);
                var contaCorrente = new ContaCorrente(cliente2, 54321, 0);

                contaPoupanca.Depositar(2000);

                Console.WriteLine(contaPoupanca.ToString());
                Console.WriteLine(contaCorrente.ToString());
            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}