using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try{
                if (form["senha"] == form["confirmar-senha"])
                {
                    Cliente cliente = new Cliente(
                    form["nome"], 
                    form["email"], 
                    form["endereco"], 
                    form["telefone"],
                    form["cpf"],
                    DateTime.Parse(form["data-nascimento"]), 
                    form["senha"]);
                    clienteRepository.Inserir(cliente);
                    return View("Sucesso", new RespostaViewModel("O cadastro foi um sucesso!"));
                }
                return View("Erro", new RespostaViewModel("As senhas não são iguais."));
            }
            catch(Exception e){
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Houve uma falha no cadastro.")); 
            }
        }
    }
}
