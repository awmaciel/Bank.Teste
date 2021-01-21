using System;
using System.ComponentModel.DataAnnotations;

namespace Bank.Portifolio.Business.Application.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int IdClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo NameClient")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string NameClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo SectorClient")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string SectorClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo PhoneClient")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string PhoneClient { get; set; }

        [Required(ErrorMessage = "Preencha o campo Tipo CellClient")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string CellClient { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateUpdate { get; set; }
    }
}
