using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Estado
    {
        [Display(Name = "Código de Estado")]
        [Key]
        public string idEstado { get; set; }
        
        [Display(Name = "Nome")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }
    }
}