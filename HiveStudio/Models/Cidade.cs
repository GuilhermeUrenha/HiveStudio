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
        [Key]
        [Display(Name = "Código de Cidade")]
        public int idCidade { get; set; }

        [ForeignKey("Estado")]
        [Display(Name = "Código de Estado")]
        public int idEstado { get; set; }

        [Display(Name = "Nome da Cidade")]
        [StringLength(200, ErrorMessage = "Máximo de 200 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }
    }
}