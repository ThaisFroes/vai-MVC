using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Role_MVC.Repositories;
using Role_MVC.ViewModel;
using Role_MVC.Enums;

namespace Role_MVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
        
        [HttpGet]
        public IActionResult Login()
        {
        return View(new RespostaViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            try{
                var usuario = form["email"];
                var senha = form["senha"];
                var cliente = clienteRepository.ObterPor(usuario);
                if(cliente != null)
                    {
                        if(cliente.Senha.Equals(senha)){
                            switch(cliente.TipoUsuario)
                            {
                                case (ushort) TiposUsuario.CLIENTE:
                                    HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                    HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                    HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                                    return RedirectToAction("Index", "Home");

                                case (ushort) TiposUsuario.ADMINISTRADOR:
                                    HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                    HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                    HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                                    return RedirectToAction("Dashboard", "Administrador");
                            }
                        } else {
                            return View("Login", new RespostaViewModel(" *Senha incorreta* "));
                        }
                    } else {
                        return View("Login", new RespostaViewModel($" * Usuário {usuario} não foi encontrado *"));
                    }
            } catch(Exception e){
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Houve uma falha no processo."));
            } 
            return RedirectToAction("Index", "Home");
        }
    public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCliente);
            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos,
                NomeView = "Historico",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
