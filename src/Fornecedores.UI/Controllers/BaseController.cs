
using Fornecedores.Bussines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fornecedores.UI.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotificador _notificador;
        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}