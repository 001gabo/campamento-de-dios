using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CampDios.Modelo.ViewModels
{
    public class Programacion_de_ReunioneViewModel
    {
        [Required]
        public int IdGrupo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de reunión")]
        public System.DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de reunión")]
        public System.DateTime Hora { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}