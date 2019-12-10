using System;
using Role_MVC.Enums;

namespace Role_MVC.Models
{
    public class Cliente
    {

        public string Nome {get; set;}
        public string Email {get; set;}
        public string Endereco {get; set;}
        public string Telefone {get; set;}
        public string Cpf {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Senha {get; set;}
        public ushort TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string endereco, string telefone, string cpf, DateTime dataNascimento, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
            this.Senha = senha;
            this.TipoUsuario = (ushort) TiposUsuario.CLIENTE;
        }
    }
}
