using System;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Role_MVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Role_MVC.Controllers
{
    public class PedidoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();

        public IActionResult Index()
        {
            PedidoViewModel pedido = new PedidoViewModel();
            var UsuarioLogado = ObterUsuarioSession();
            var NomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(NomeUsuarioLogado)){
                pedido.NomeUsuario = NomeUsuarioLogado;
            }

            var ClienteLogado = clienteRepository.ObterPor(UsuarioLogado);
            if(ClienteLogado != null){
                pedido.Cliente = ClienteLogado;
            }
            pedido.NomeView = "Pedido";
            pedido.NomeUsuario = ObterUsuarioNomeSession();
            pedido.UsuarioEmail = ObterUsuarioSession();
            return View(pedido);
        }
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();
            Produto produto = new Produto(form["tipo"], 
            DateTime.Parse(form["data"]),
            form["numeroPessoas"], 
            form["servico"], 
            form["observacoes"]);
            pedido.Cliente = clienteRepository.ObterPor(ObterUsuarioSession());
            pedido.Produto = produto;  
            produto.Cliente = pedido.Cliente;
            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostaViewModel(){
                    Mensagem = "Aguarde a aprovação dos nosso administradores",
                    NomeView = "Sucesso",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao processar seu pedido, tente novamente.",
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar(uint id)
        {
            
            pedidoRepository.AtualizarEstado(id,"Aprovar");
            Pedido pedido = pedidoRepository.ObterPor(id);
            // pedido.Evento.Status = (uint) StatusPedido.APROVADO;
            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao aprovar seu pedido.",
                    NomeView = "dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            
        }
        public IActionResult Reprovar(uint id)
        {
            pedidoRepository.AtualizarEstado(id,"Reprovar");
            Pedido pedido = pedidoRepository.ObterPor(id);
            // pedido.Evento.Status = (uint) StatusPedido.APROVADO;
            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao reprovar seu pedido.",
                    NomeView = "dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}
