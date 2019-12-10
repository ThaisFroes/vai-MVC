using Microsoft.AspNetCore.Mvc;
using Role_MVC.Enums;
using Role_MVC.Repositories;
using Role_MVC.ViewModel;


namespace Role_MVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        [HttpGet]
        public IActionResult Dashboard()
        {
            var tipoUsuarioSession = ushort.Parse(ObterUsuarioTipoSession());
            if(tipoUsuarioSession.Equals((ushort) TiposUsuario.ADMINISTRADOR))
            {
            var pedidos = pedidoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            foreach(var pedido in pedidos)
            {
                switch(pedido.Produto.Status)
                {
                case (ushort) StatusPedido.REPROVADO:
                    dashboardViewModel.PedidosReprovados++;
                break;
                case (ushort) StatusPedido.APROVADO:
                    dashboardViewModel.PedidosAprovados++;
                break;
                default:
                    dashboardViewModel.PedidosPendentes++;
                    dashboardViewModel.Pedidos.Add(pedido);
                break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashboardViewModel);
            } else {
                return View("Falha", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não é digno de entrar nesta tela."
                });
            }
        }
    }
}