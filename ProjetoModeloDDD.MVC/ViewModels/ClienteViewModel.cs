
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Obrigatório!")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage ="Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Obrigatório!")]
        [EmailAddress(ErrorMessage ="Email inválido!")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}