using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Cidade
    {
        [Display(Name = "Código de Cidade")]
        [Key]
        public int idCidade { get; set; }

        [Display(Name = "Código de Estado")]
        [ForeignKey("Estado")]
        public int idEstado { get; set; }

        [Display(Name = "Nome da Cidade")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }
    }
}