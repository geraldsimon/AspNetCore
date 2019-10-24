using Fornecedores.UI.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fornecedores.UI.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatótio")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatótio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ficar entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatótio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ficar entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }


        public string Imagem { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatótio")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}