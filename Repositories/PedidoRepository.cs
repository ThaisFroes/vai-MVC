using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Role_MVC.Models;
using Role_MVC.Enums;

namespace Role_MVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedidos.csv";
        public PedidoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Pedido pedido){
            var quantidadeLinhas = File.ReadAllLines(PATH).Length;
            pedido.Produto.Id = (uint) ++quantidadeLinhas;
            var linha = new string[] {PrepararRegistroCSV(pedido)};
            File.AppendAllLines(PATH, linha);
            return true;
        }
        public List<Pedido> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var linha in linhas)
            {
                Pedido pedido = new Pedido();
                pedido.Produto.Id = uint.Parse(ExtrairValorDoCampo("id", linha));
                pedido.Produto.Status = ushort.Parse(ExtrairValorDoCampo("status_pedido", linha));
                pedido.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                pedido.Cliente.Cpf = ExtrairValorDoCampo ("cliente_cpf", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                pedido.Produto.Tipo = ExtrairValorDoCampo("evento_tipo", linha);
                pedido.Produto.Data = DateTime.Parse(ExtrairValorDoCampo("evento_data", linha));
                pedido.Produto.NumeroPessoas = ExtrairValorDoCampo("evento_numeroPessoas", linha);
                pedido.Produto.Servicos = ExtrairValorDoCampo("evento_servicos", linha);
                pedido.Produto.Observacoes = ExtrairValorDoCampo("evento_observacoes", linha);
                pedidos.Add(pedido);
            }
            return pedidos;
        }

        private string PrepararRegistroCSV(Pedido pedido)
        {
            Cliente cliente = pedido.Cliente;
            Produto produto = pedido.Produto;
            return $"id={produto.Id};status_pedido={produto.Status};cliente_nome={cliente.Nome};cliente_cpf={cliente.Cpf};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};evento_tipo={produto.Tipo};evento_data={produto.Data};evento_numeroPessoas={produto.NumeroPessoas};evento_servicos={produto.Servicos};evento_observacoes={produto.Observacoes}";
        }

        public Pedido ObterPor(uint id)
        {
            var pedidosTotais= ObterTodos();
            foreach(var pedido in pedidosTotais)
            {
                if(pedido.Produto.Id == id)
                {
                    return pedido;
                }
            }
            return null;
        }

        public List<Pedido> ObterTodosPorCliente(string email)
        {
            var pedidosTotais = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach(var pedido in pedidosTotais)
            {
                if(pedido.Cliente.Email.Equals(email)){
                    pedidosCliente.Add(pedido);
                }
            }
                return pedidosCliente;
        }

        public bool Atualizar(Pedido pedido)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidoCSV = PrepararRegistroCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;
            var id = pedido.Produto.Id;
            for(int i = 0 ; i < pedidosTotais.Length ; i++)
            {
                var idConvertido = uint.Parse((ExtrairValorDoCampo("id", pedidosTotais[i])));
                if(id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            if(!resultado)
            {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }
            return resultado;
        }

        public void AtualizarEstado(uint id,string NovoEstado)
        {
            Pedido pedido = ObterPor(id);
            int linha = 0;
            if(NovoEstado == "Aprovar"){
                pedido.Produto.Status = (ushort) StatusPedido.APROVADO;
            }else if(NovoEstado == "Reprovar")
            {
                pedido.Produto.Status = (ushort) StatusPedido.REPROVADO;
            }
            var pedidosTotais = ObterTodos();
            for(int i=0; i < pedidosTotais.Count; i++)
            {
                if(pedidosTotais[i].Produto.Id == id)
                {
                    linha = i;
                    break;
                }
            }
            var linhas = File.ReadAllLines(PATH);    
            linhas[linha] = PrepararRegistroCSV(pedido);
            File.WriteAllLines(PATH,linhas);
        }
    }
}
