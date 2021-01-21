using System;
using System.ComponentModel.DataAnnotations;

namespace Bank.Portifolio.Business.Application.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int IdCategory { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo NameCategory")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string NameCategory { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateUpdate { get; set; }
    }
}
