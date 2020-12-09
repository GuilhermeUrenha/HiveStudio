using System.ComponentModel.DataAnnotations;

namespace HiveStudio.Models
{
    public class PagamentoMetodo
    {
        [Key]
        [Display(Name = "Código")]
        public int idMetodo { get; set; }

        [Display(Name = "Método")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string metodo { get; set; }
    }
}