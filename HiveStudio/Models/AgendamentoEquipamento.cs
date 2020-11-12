using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class AgendamentoEquipamento
    {
        [Display(Name = "Código de Agendamento")]
        [ForeignKey("Equipamento"), Column(Order = 0)]
        public int idEquipamento { get; set; }

        [Display(Name = "Código de Sessão")]
        [ForeignKey("SessaoFotos"), Column(Order = 1)]
        public int idSessao { get; set; }
    }
}