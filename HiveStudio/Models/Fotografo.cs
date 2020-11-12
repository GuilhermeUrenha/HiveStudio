using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Fotografo
    {
        [Key]
        [Display(Name = "CPF")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Máximo de 11 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string cpf { get; set; }

        [Display(Name = "Dígito")]
        [StringLength(2, ErrorMessage = "Máximo de 2 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public sbyte cpf_dig { get; set; }

        [Display(Name = "Nome")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }

        [Display(Name = "Celular")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "Máximo de 9 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string celular { get; set; }

        [Display(Name = "Telefone")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "Máximo de 8 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string telefone { get; set; }

        [ForeignKey("Endereco")]
        [Display(Name = "Código de Endereço")]
        public int idEndereco { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Ativo")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public long isAtivo { get; set; }

        [Display(Name = "Pagamento por Hora")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public decimal pagtoHora { get; set; }

        [ForeignKey("Usuario")]
        [Display(Name = "Código de Usuário")]
        public int idUsuario { get; set; }
    }
}