using System.ComponentModel.DataAnnotations;

namespace Estacionamento.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Required, Display(Name = "Modelo")]
        [StringLength(50, ErrorMessage = "O modelo do veículo não pode ter mais que 50 caracteres.")]
        public string Modelo { get; set; }

        [Required, Display(Name = "Placa")]
        [MaxLength(7, ErrorMessage = "A placa deve ter no máximo 7 caracteres, composto de letras e números.")]
        [MinLength(7, ErrorMessage = "A placa deve ter no mínimo 7 caracteres, composto de letras e números.")]
        [RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = "A placa só pode conter letras e números")]
        public string Placa { get; set; }

        [Display(Name ="Preço Inicial")]
        public decimal PrecoInicial { get; set; }

        [Required, Display(Name = "Preço por hora")]
        public decimal PrecoHora { get; set; }

        [Required, Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required, Display(Name = "Cor")]
        public string Cor { get; set; }

        [Required, Display(Name = "Proprietário")]
        public string Proprietario { get; set; }

    }
}
