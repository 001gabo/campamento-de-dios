//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampDios
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoriaEspiritual
    {
        public int IdHistoria { get; set; }
        public int IdMiembro { get; set; }
        public System.DateTime FechaConversion { get; set; }
        public System.DateTime FechaBautismo { get; set; }
        public string IglesiaBautismo { get; set; }
    
        public virtual Miembro Miembro { get; set; }
    }
}
