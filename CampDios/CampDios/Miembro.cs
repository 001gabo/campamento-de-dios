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
    
    public partial class Miembro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Miembro()
        {
            this.Aprendices = new HashSet<Aprendice>();
            this.Comunidads = new HashSet<Comunidad>();
            this.Familias = new HashSet<Familia>();
            this.Familias1 = new HashSet<Familia>();
            this.Grupoes = new HashSet<Grupo>();
            this.HistoriaEspirituals = new HashSet<HistoriaEspiritual>();
            this.Pastores = new HashSet<Pastore>();
            this.USUARIOS = new HashSet<USUARIO>();
            this.Zonas = new HashSet<Zona>();
        }
    
        public int IdMiembro { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public Nullable<int> IdProfesion { get; set; }
        public Nullable<int> IdCapacitacion { get; set; }
        public Nullable<int> IdPastoreo { get; set; }
        public Nullable<int> IdCorporativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aprendice> Aprendices { get; set; }
        public virtual Capacitacione Capacitacione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comunidad> Comunidads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Familia> Familias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Familia> Familias1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo> Grupoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoriaEspiritual> HistoriaEspirituals { get; set; }
        public virtual LiderasgoCorporativo LiderasgoCorporativo { get; set; }
        public virtual LiderasgoPastoral LiderasgoPastoral { get; set; }
        public virtual Profesion Profesion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pastore> Pastores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zona> Zonas { get; set; }
    }
}
