using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Código")]
        public string idUsuario { get; set; }

        [Display(Name = "Dígito")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Máximo de 2 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string cpf_dig { get; set; }
    }
}