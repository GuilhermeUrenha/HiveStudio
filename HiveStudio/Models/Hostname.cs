using System.ComponentModel.DataAnnotations;

namespace HiveStudio.Models
{
    public class Hostname
    {
        [Key]
        [Display(Name = "Código de Host")]
        public int idHostname { get; set; }

        [Display(Name = "Nome de Host")]
        //[StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string hostname { get; set; }
    }
}