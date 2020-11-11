using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Equipamento
    {
        [Display(Name = "Código de Equipamento")]
        [Key]
        public string idEquipamento { get; set; }

        [Display(Name = "Marca")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string marca { get; set; }

        [Display(Name = "Modelo")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string modelo { get; set; }

        [Display(Name = "Especificações")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string especificacoes { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        //[Required(ErrorMessage = "O campo é obrigatório!")]
        public string descricao { get; set; }

        [Display(Name = "Preço por Hora")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        // (10,2)
        public string precoHora { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime dataRegistro { get; set; }

        [Display(Name = "Código de Tipo")]
        [Key]
        public long idTipo { get; set; }
    }
}