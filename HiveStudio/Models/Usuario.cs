using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using MySql.Data.Types;

namespace HiveStudio.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Código de Usuário")]
        public int idUsuario { get; set; }

        [Display(Name = "Login")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string login { get; set; }

        [Display(Name = "Shadow")]
        [StringLength(32, ErrorMessage = "Máximo de 32 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string shadow { get; set; }

        [Display(Name = "Salt")]
        [StringLength(32, ErrorMessage = "Máximo de 32 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string salt { get; set; }

        [Display(Name = "Cargo")]//bit(2)
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public long cargo { get; set; }

        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string emailName { get; set; }

        [ForeignKey("Hostname")]
        [Display(Name = "Hostname")]
        public int idHostname { get; set; }
    }
}