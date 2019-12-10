using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Role_MVC.Models;
using Role_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using Role_MVC.ViewModel;

namespace Role_MVC.Controllers
{
    public class SobreController : AbstractController
    {
        public IActionResult Index()
        {
            return View( new BaseViewModel()
            {
                NomeView = "Sobre",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }
    }
}