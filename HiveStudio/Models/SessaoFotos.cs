using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class SessaoFotos
    {
        [Display(Name = "Caminho")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string path { get; set; }

        [ForeignKey("Sessao")]
        [Display(Name = "Código de Sessão")]
        public int idSessao { get; set; }
    }
}