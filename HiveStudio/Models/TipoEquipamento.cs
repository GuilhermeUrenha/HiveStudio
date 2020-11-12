using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class TipoEquipamento
    {
        [Key]
        [Display(Name = "Código")]
        public int idTipo { get; set; }

        [Display(Name = "Tipo")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string tipo { get; set; }
    }
}