using System;

namespace ProjetoBanco.Classes
{
    public class Cliente
    {
        private Cliente()
        { }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public long Telefone { get; private set; }

        public string CPF { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool IsMaiorIdade => ValidarMaioridade();

        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime dataNascimento) =>
            new Cliente { Nome = nome, Endereco = endereco, Telefone = telefone, CPF = cpf, DataNascimento = dataNascimento };

        public override string ToString() => $"Nome: {Nome} | CPF: {CPF} | Data de Nascimento: {DataNascimento} --- Sobrecrita de: { base.ToString()}";

        private bool ValidarMaioridade() => DateTime.Now.Year - DataNascimento.Year >= 18;
                   
    }
}