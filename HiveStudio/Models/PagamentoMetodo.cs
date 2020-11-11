using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class PagamentoMetodo
    {
        [Display(Name = "Código")]
        [Key]
        public int idMetodo { get; set; }

        [Display(Name = "Método")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string metodo { get; set; }
    }
}