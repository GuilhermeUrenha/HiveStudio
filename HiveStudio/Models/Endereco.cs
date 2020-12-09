using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiveStudio.Models
{
    public class Endereco
    {
        [Key]
        [Display(Name = "Código de Endereço")]
        public int idEndereco { get; set; }

        [ForeignKey("Cidade")]
        [Display(Name = "Código de Cidade")]
        public int idCidade { get; set; }

        [Display(Name = "Logradouro")]
        [StringLength(200, ErrorMessage = "Máximo de 200 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string logradouro { get; set; }

        [Display(Name = "Numero")]
        [StringLength(20, ErrorMessage = "Máximo de 20 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string numero { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string complemento { get; set; }
    }
}