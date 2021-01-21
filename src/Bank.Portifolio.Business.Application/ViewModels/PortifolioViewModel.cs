using System;
using System.ComponentModel.DataAnnotations;

namespace Bank.Portifolio.Business.Application.ViewModels
{
    public class PortifolioViewModel
    {
        [Key]
        public int IdPortifolio { get; set; }

        [Required(ErrorMessage = "Preencha o campo NameProtifolio")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string NameProtifolio { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateUpdate { get; set; }
    }
}
