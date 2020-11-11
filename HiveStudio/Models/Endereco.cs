using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Endereco
    {
        [Display(Name = "Código de Endereço")]
        [Key]
        public int idEndereco { get; set; }

        [Display(Name = "Código de Cidade")]
        [Key]
        public int idCidade { get; set; }

        [Display(Name = "Logradouro")]
        [StringLength(30, ErrorMessage = "Máximo de 60 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string logradouro { get; set; }

        [Display(Name = "Numero")]
        [StringLength(30, ErrorMessage = "Máximo de 6 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string numero { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(30, ErrorMessage = "Máximo de 60 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string complemento { get; set; }
    }
}