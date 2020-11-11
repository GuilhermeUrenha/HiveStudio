using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HiveStudio.Models
{
    public class AgendamentoEquipamento
    {
        [Display(Name = "Código de Agendamento")]
        [Key]
        public int idAgendamento { get; set; }

        [Display(Name = "Código de Sessão")]
        [Key]
        public int idSessao { get; set; }
    }
}