using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Cliente
    {
        [Display(Name = "CPF")]
        [Key]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Máximo de 11 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string cpf { get; set; }

        [Display(Name = "Dígito")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Máximo de 2 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string cpf_dig { get; set; }

        [Display(Name = "Nome")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "Máximo de 8 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string telefone { get; set; }

        [Display(Name = "Celular")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "Máximo de 9 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string celular { get; set; }

        [Display(Name = "Código de Endereço")]
        //[StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Key]
        public int enderecoid { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Código de Usuário")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [Key]
        public int usuarioid { get; set; }
    }
}