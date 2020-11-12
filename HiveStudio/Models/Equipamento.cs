using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Equipamento
    {
        [Key]
        [Display(Name = "Código de Equipamento")]
        public int idEquipamento { get; set; }

        [Display(Name = "Marca")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string marca { get; set; }

        [Display(Name = "Modelo")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string modelo { get; set; }

        [Display(Name = "Especificações")]
        //[StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string especificacoes { get; set; }

        [Display(Name = "Descrição")]
        //[StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        //[Required(ErrorMessage = "O campo é obrigatório!")]
        public string descricao { get; set; }

        [Display(Name = "Preço por Hora")]
        //[StringLength(8, MinimumLength = 5, ErrorMessage = "Máximo de 5 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        // (10,2)
        public decimal precoHora { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime dataRegistro { get; set; }

        [ForeignKey("TipoEquipamento")]
        [Display(Name = "Código de Tipo")]
        public int idTipo { get; set; }
    }
}