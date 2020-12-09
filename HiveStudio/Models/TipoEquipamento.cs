using System.ComponentModel.DataAnnotations;

namespace HiveStudio.Models
{
    public class TipoEquipamento
    {
        [Key]
        [Display(Name = "Código")]
        public int idTipo { get; set; }

        [Display(Name = "Tipo")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string tipo { get; set; }
    }
}