using System;
using System.ComponentModel.DataAnnotations;

namespace Bank.Portifolio.Business.Application.ViewModels
{
    public class BusinessViewModel
    {
        [Key]
        public int IdBusiness { get; set; }

        [ScaffoldColumn(false)]
        public int IdPortifolio { get; set; }

        [ScaffoldColumn(false)]
        public int IdCategory { get; set; }

        [ScaffoldColumn(false)]
        public int IdClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo Negocio")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string TypeBusiness { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateUpdate { get; set; }
    }
}
