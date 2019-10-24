using FluentValidation;
using FluentValidation.Results;
using Fornecedores.Bussines.Interfaces;
using Fornecedores.Bussines.Models;
using Fornecedores.Bussines.Notifications;

namespace Fornecedores.UI.Services
{
    public abstract class BaseServices
    {
        private readonly INotificador _notificador;
        public BaseServices(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }
        protected void Notificar(string message)
        {
            _notificador.Handle(new Notificacao(message));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
