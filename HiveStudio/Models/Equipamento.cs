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

        [ForeignKey("TipoEquipamento")]
        [Display(Name = "Código de Tipo")]
        public long idTipo { get; set; }
    }
}