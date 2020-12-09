using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiveStudio.Models
{
    public class Orcamento
    {
        [Key]
        [Display(Name = "Código de Cidade")]
        public int idParcela { get; set; }

        [ForeignKey("PagamentoMetodo")]
        [Display(Name = "Código do Método")]
        public int idMetodo { get; set; }

        [Display(Name = "Preço Total")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public decimal precoTotal { get; set; }

        [Display(Name = "Estado de pagamento")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public int pago { get; set; }

        [Display(Name = "Data de Pagamento")]
        public DateTime dataPgto { get; set; }

        [Display(Name = "Data de Vencimento")]
        public DateTime dataVenc { get; set; }
    }
}