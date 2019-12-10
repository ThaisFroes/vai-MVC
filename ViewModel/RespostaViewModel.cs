using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Role_MVC.ViewModel
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}

        public RespostaViewModel()
        {

        }

        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}
