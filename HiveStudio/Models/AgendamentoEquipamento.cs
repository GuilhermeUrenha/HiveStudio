﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiveStudio.Models
{
    public class AgendamentoEquipamento
    {
        [ForeignKey("Equipamento"), Column(Order = 0)]
        [Display(Name = "Código de Agendamento")]
        public int idEquipamento { get; set; }

        [ForeignKey("SessaoFotos"), Column(Order = 1)]
        [Display(Name = "Código de Sessão")]
        public int idSessao { get; set; }
    }
}