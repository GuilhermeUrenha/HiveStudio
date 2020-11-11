using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Venda
    {
        [Display(Name = "Código")]
        [Key]
        public string idVenda { get; set; }

        [Display(Name = "Preço Total")]
        //[StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        //(10,2)
        public string precoTotal { get; set; }
    }
}