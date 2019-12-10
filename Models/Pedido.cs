using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Enums;

namespace Role_MVC.Models
{
    public class Pedido
    {
        public Produto Produto {get;set;}
        public Cliente Cliente {get;set;}

        public Pedido()
        {
            this.Produto = new Produto();
            this.Cliente = new Cliente();
        }
    }
}
