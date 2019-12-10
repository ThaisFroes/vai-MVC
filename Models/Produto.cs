using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Enums;

namespace Role_MVC.Models
{
    public class Produto
    {
        public string Tipo {get;set;}
        public DateTime Data {get;set;}
        public string NumeroPessoas {get;set;}
        public string Servicos {get;set;}
        public string Observacoes {get;set;}
        public Cliente Cliente {get;set;}
        public ushort Status {get;set;}
        public uint Id {get;set;}

        public Produto()
        {

        }

        public Produto(string tipo, DateTime data, string numeroPessoas, string servicos, string observacoes)
        {
            this.Tipo = tipo;
            this.Data = data;
            this.NumeroPessoas = numeroPessoas;
            this.Servicos = servicos;
            this.Observacoes = observacoes;
            this.Cliente = new Cliente();
            this.Status = (ushort) StatusPedido.PENDENTE;
            this.Id = 0;
        }
    }
}
