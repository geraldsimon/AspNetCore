using FluentValidation;
using Fornecedores.Bussines.Models.Validations.Documentos;

namespace Fornecedores.Bussines.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2,100).WithMessage(("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres"));

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(ValidacaoCpf.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

                RuleFor(f => ValidacaoCpf.Validar(f.Documento)).Equal(true)
                .WithMessage("O campo Documento fornecido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(ValidacaoCnpf.TamanhoCNPJ)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

                RuleFor(f => ValidacaoCnpf.Validar(f.Documento)).Equal(true)
                .WithMessage("O campo Documento fornecido é inválido.");
            });
        }
    }
}