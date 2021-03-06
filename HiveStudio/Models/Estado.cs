﻿using System.ComponentModel.DataAnnotations;

namespace HiveStudio.Models
{
    public class Estado
    {
        [Key]
        [Display(Name = "Código de Estado")]
        public int idEstado { get; set; }
        
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "Máximo de 50 caracteres!")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string nome { get; set; }
    }
}