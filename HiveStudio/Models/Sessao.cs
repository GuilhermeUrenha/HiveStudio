using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class Sessao
    {
        [Key]
        [Display(Name = "Código de Sessão")]
        public int idSessao { get; set; }

        [ForeignKey("Venda")]
        [Display(Name = "Código de Venda")]
        public int idVenda { get; set; }

        [Display(Name = "Horário de Início")]
        public DateTime horarioInicio { get; set; }

        [Display(Name = "Horário de Término")]
        public DateTime horarioFim { get; set; }

        [ForeignKey("Endereco")]
        [Display(Name = "Código de Endereço")]
        public int idEndereco { get; set; }

        [ForeignKey("Cliente")]
        [Display(Name = "Código de Venda")]
        public string clienteCpf { get; set; }

        [ForeignKey("Fotografo")]
        [Display(Name = "Código de Venda")]
        public string fotografoCpf { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string descricao { get; set; }
    }
}