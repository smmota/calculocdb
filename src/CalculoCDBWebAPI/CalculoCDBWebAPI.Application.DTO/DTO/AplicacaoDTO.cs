using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCDBWebAPI.Application.DTO.DTO
{
    public class AplicacaoDTO
    {
        [Required(ErrorMessage = "Informe o valor aplicado")]
        //[RegularExpression(@"^R$ ?(\d{1,3}.)?\d{1,3},\d{2}$|^U$ ?(\d{1,3},)?\d{1,3}.\d{2}$",
        //    ErrorMessage ="O valor aplicado deve ser maior que zero")]
        //[Range(typeof(decimal), "0.1", "79228162514264337593543950335")]
        public Decimal? ValorAplicado { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de meses")]
        //[RegularExpression(@"^\d +? (.|,\d +)$",
        //    ErrorMessage = "A quantidade de meses deve ser maior que um")]
        public int? QuantidadeMeses { get; set; }
    }
}
