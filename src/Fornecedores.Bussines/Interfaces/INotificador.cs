using Fornecedores.Bussines.Notifications;
using System.Collections.Generic;

namespace Fornecedores.Bussines.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacoes();

        void Handle(Notificacao notificacao);
    }
}