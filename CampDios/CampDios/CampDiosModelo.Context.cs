﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CampDiosEntities : DbContext
    {
        public CampDiosEntities()
            : base("name=CampDiosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aprendice> Aprendices { get; set; }
        public virtual DbSet<Capacitacione> Capacitaciones { get; set; }
        public virtual DbSet<Catalogo> Catalogoes { get; set; }
        public virtual DbSet<Catalogo_Detalles> Catalogo_Detalles { get; set; }
        public virtual DbSet<Comunidad> Comunidads { get; set; }
        public virtual DbSet<Familia> Familias { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<HistoriaEspiritual> HistoriaEspirituals { get; set; }
        public virtual DbSet<Iglesia> Iglesias { get; set; }
        public virtual DbSet<LiderasgoCorporativo> LiderasgoCorporativoes { get; set; }
        public virtual DbSet<LiderasgoPastoral> LiderasgoPastorals { get; set; }
        public virtual DbSet<Miembro> Miembros { get; set; }
        public virtual DbSet<Parentesco> Parentescos { get; set; }
        public virtual DbSet<Pastore> Pastores { get; set; }
        public virtual DbSet<Profesion> Profesions { get; set; }
        public virtual DbSet<Programacion_de_Reunione> Programacion_de_Reuniones { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tipo_Grupo> Tipo_Grupo { get; set; }
        public virtual DbSet<USUARIO> USUARIOS { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }
        public virtual DbSet<Comunidad_Miembro> Comunidad_Miembro { get; set; }
        public virtual DbSet<Grupo_Miembro> Grupo_Miembro { get; set; }
        public virtual DbSet<HistoriaEspiritualMiembro> HistoriaEspiritualMiembros { get; set; }
        public virtual DbSet<Miembro_Familiar> Miembro_Familiar { get; set; }
        public virtual DbSet<Miembros_full> Miembros_full { get; set; }
        public virtual DbSet<Zona_Miembro> Zona_Miembro { get; set; }
    
        public virtual int APRENDICES_SIUD(Nullable<int> iDAPRENDIS, Nullable<int> iDMIEMBRO, Nullable<int> iDGRUPO, string bANDERA)
        {
            var iDAPRENDISParameter = iDAPRENDIS.HasValue ?
                new ObjectParameter("IDAPRENDIS", iDAPRENDIS) :
                new ObjectParameter("IDAPRENDIS", typeof(int));
    
            var iDMIEMBROParameter = iDMIEMBRO.HasValue ?
                new ObjectParameter("IDMIEMBRO", iDMIEMBRO) :
                new ObjectParameter("IDMIEMBRO", typeof(int));
    
            var iDGRUPOParameter = iDGRUPO.HasValue ?
                new ObjectParameter("IDGRUPO", iDGRUPO) :
                new ObjectParameter("IDGRUPO", typeof(int));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("APRENDICES_SIUD", iDAPRENDISParameter, iDMIEMBROParameter, iDGRUPOParameter, bANDERAParameter);
        }
    
        public virtual int CAPACITACIONES_SIUD(Nullable<int> iDCAPACITACION, string nOMBRE, string dESCRIPCION, string bANDERA)
        {
            var iDCAPACITACIONParameter = iDCAPACITACION.HasValue ?
                new ObjectParameter("IDCAPACITACION", iDCAPACITACION) :
                new ObjectParameter("IDCAPACITACION", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CAPACITACIONES_SIUD", iDCAPACITACIONParameter, nOMBREParameter, dESCRIPCIONParameter, bANDERAParameter);
        }
    
        public virtual int COMUNIDAD_SIUD(Nullable<int> idComunidad, string nombre, string descripcion, string direccion, Nullable<int> idLiderComunidad, Nullable<int> idZona, string bANDERA)
        {
            var idComunidadParameter = idComunidad.HasValue ?
                new ObjectParameter("IdComunidad", idComunidad) :
                new ObjectParameter("IdComunidad", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var idLiderComunidadParameter = idLiderComunidad.HasValue ?
                new ObjectParameter("IdLiderComunidad", idLiderComunidad) :
                new ObjectParameter("IdLiderComunidad", typeof(int));
    
            var idZonaParameter = idZona.HasValue ?
                new ObjectParameter("IdZona", idZona) :
                new ObjectParameter("IdZona", typeof(int));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("COMUNIDAD_SIUD", idComunidadParameter, nombreParameter, descripcionParameter, direccionParameter, idLiderComunidadParameter, idZonaParameter, bANDERAParameter);
        }
    
        public virtual int FAMILIA_SIUD(Nullable<int> iDFAMILIA, Nullable<int> iDMIEMBRO, string nOMBRES, string aPELLIDOS, Nullable<int> iDPARENTESCO, Nullable<System.DateTime> fECHANACIMIENTO, string bANDERA)
        {
            var iDFAMILIAParameter = iDFAMILIA.HasValue ?
                new ObjectParameter("IDFAMILIA", iDFAMILIA) :
                new ObjectParameter("IDFAMILIA", typeof(int));
    
            var iDMIEMBROParameter = iDMIEMBRO.HasValue ?
                new ObjectParameter("IDMIEMBRO", iDMIEMBRO) :
                new ObjectParameter("IDMIEMBRO", typeof(int));
    
            var nOMBRESParameter = nOMBRES != null ?
                new ObjectParameter("NOMBRES", nOMBRES) :
                new ObjectParameter("NOMBRES", typeof(string));
    
            var aPELLIDOSParameter = aPELLIDOS != null ?
                new ObjectParameter("APELLIDOS", aPELLIDOS) :
                new ObjectParameter("APELLIDOS", typeof(string));
    
            var iDPARENTESCOParameter = iDPARENTESCO.HasValue ?
                new ObjectParameter("IDPARENTESCO", iDPARENTESCO) :
                new ObjectParameter("IDPARENTESCO", typeof(int));
    
            var fECHANACIMIENTOParameter = fECHANACIMIENTO.HasValue ?
                new ObjectParameter("FECHANACIMIENTO", fECHANACIMIENTO) :
                new ObjectParameter("FECHANACIMIENTO", typeof(System.DateTime));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FAMILIA_SIUD", iDFAMILIAParameter, iDMIEMBROParameter, nOMBRESParameter, aPELLIDOSParameter, iDPARENTESCOParameter, fECHANACIMIENTOParameter, bANDERAParameter);
        }
    
        public virtual int GRUPO_SIUD(Nullable<int> idGrupo, string nombre, string descripcion, string direccion, Nullable<int> idLiderGrupo, Nullable<int> idComunidad, string bANDERA)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var idLiderGrupoParameter = idLiderGrupo.HasValue ?
                new ObjectParameter("IdLiderGrupo", idLiderGrupo) :
                new ObjectParameter("IdLiderGrupo", typeof(int));
    
            var idComunidadParameter = idComunidad.HasValue ?
                new ObjectParameter("IdComunidad", idComunidad) :
                new ObjectParameter("IdComunidad", typeof(int));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GRUPO_SIUD", idGrupoParameter, nombreParameter, descripcionParameter, direccionParameter, idLiderGrupoParameter, idComunidadParameter, bANDERAParameter);
        }
    
        public virtual int HISTORIA_ESPIRITUAL_SIUD(Nullable<int> idHistoria, Nullable<int> idMiembro, Nullable<System.DateTime> fechaConversion, Nullable<System.DateTime> fechaBautismo, string iglesiaBautismo, string bANDERA)
        {
            var idHistoriaParameter = idHistoria.HasValue ?
                new ObjectParameter("IdHistoria", idHistoria) :
                new ObjectParameter("IdHistoria", typeof(int));
    
            var idMiembroParameter = idMiembro.HasValue ?
                new ObjectParameter("IdMiembro", idMiembro) :
                new ObjectParameter("IdMiembro", typeof(int));
    
            var fechaConversionParameter = fechaConversion.HasValue ?
                new ObjectParameter("FechaConversion", fechaConversion) :
                new ObjectParameter("FechaConversion", typeof(System.DateTime));
    
            var fechaBautismoParameter = fechaBautismo.HasValue ?
                new ObjectParameter("FechaBautismo", fechaBautismo) :
                new ObjectParameter("FechaBautismo", typeof(System.DateTime));
    
            var iglesiaBautismoParameter = iglesiaBautismo != null ?
                new ObjectParameter("IglesiaBautismo", iglesiaBautismo) :
                new ObjectParameter("IglesiaBautismo", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HISTORIA_ESPIRITUAL_SIUD", idHistoriaParameter, idMiembroParameter, fechaConversionParameter, fechaBautismoParameter, iglesiaBautismoParameter, bANDERAParameter);
        }
    
        public virtual int IGLESIA_SIUD(Nullable<int> idIglesia, string nombre, string direccion, string tel, string tel2, string tel3, string email, string bANDERA)
        {
            var idIglesiaParameter = idIglesia.HasValue ?
                new ObjectParameter("IdIglesia", idIglesia) :
                new ObjectParameter("IdIglesia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var tel2Parameter = tel2 != null ?
                new ObjectParameter("Tel2", tel2) :
                new ObjectParameter("Tel2", typeof(string));
    
            var tel3Parameter = tel3 != null ?
                new ObjectParameter("Tel3", tel3) :
                new ObjectParameter("Tel3", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IGLESIA_SIUD", idIglesiaParameter, nombreParameter, direccionParameter, telParameter, tel2Parameter, tel3Parameter, emailParameter, bANDERAParameter);
        }
    
        public virtual int LIDERASGO_COORPORATIVO_SIUD(Nullable<int> idCorporativo, string nombre, string descripcion, string bANDERA)
        {
            var idCorporativoParameter = idCorporativo.HasValue ?
                new ObjectParameter("IdCorporativo", idCorporativo) :
                new ObjectParameter("IdCorporativo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LIDERASGO_COORPORATIVO_SIUD", idCorporativoParameter, nombreParameter, descripcionParameter, bANDERAParameter);
        }
    
        public virtual int LIDERASGO_PASTORAL_SIUD(Nullable<int> idPastoreo, string nombre, string descripcion, string bANDERA)
        {
            var idPastoreoParameter = idPastoreo.HasValue ?
                new ObjectParameter("IdPastoreo", idPastoreo) :
                new ObjectParameter("IdPastoreo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LIDERASGO_PASTORAL_SIUD", idPastoreoParameter, nombreParameter, descripcionParameter, bANDERAParameter);
        }
    
        public virtual int MIEMBROS_SIUD(Nullable<int> idMiembro, string nombres, string apellidos, string dUI, string nIT, Nullable<System.DateTime> fechaNacimiento, string direccion, string direccion1, string direccion2, string email, string tel, string cel, string sexo, string estadoCivil, Nullable<int> idProfesion, Nullable<int> idCapacitacion, Nullable<int> idPastoreo, Nullable<int> idCorporativo, string bANDERA)
        {
            var idMiembroParameter = idMiembro.HasValue ?
                new ObjectParameter("IdMiembro", idMiembro) :
                new ObjectParameter("IdMiembro", typeof(int));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var dUIParameter = dUI != null ?
                new ObjectParameter("DUI", dUI) :
                new ObjectParameter("DUI", typeof(string));
    
            var nITParameter = nIT != null ?
                new ObjectParameter("NIT", nIT) :
                new ObjectParameter("NIT", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var direccion1Parameter = direccion1 != null ?
                new ObjectParameter("Direccion1", direccion1) :
                new ObjectParameter("Direccion1", typeof(string));
    
            var direccion2Parameter = direccion2 != null ?
                new ObjectParameter("Direccion2", direccion2) :
                new ObjectParameter("Direccion2", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var celParameter = cel != null ?
                new ObjectParameter("Cel", cel) :
                new ObjectParameter("Cel", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var estadoCivilParameter = estadoCivil != null ?
                new ObjectParameter("EstadoCivil", estadoCivil) :
                new ObjectParameter("EstadoCivil", typeof(string));
    
            var idProfesionParameter = idProfesion.HasValue ?
                new ObjectParameter("IdProfesion", idProfesion) :
                new ObjectParameter("IdProfesion", typeof(int));
    
            var idCapacitacionParameter = idCapacitacion.HasValue ?
                new ObjectParameter("IdCapacitacion", idCapacitacion) :
                new ObjectParameter("IdCapacitacion", typeof(int));
    
            var idPastoreoParameter = idPastoreo.HasValue ?
                new ObjectParameter("IdPastoreo", idPastoreo) :
                new ObjectParameter("IdPastoreo", typeof(int));
    
            var idCorporativoParameter = idCorporativo.HasValue ?
                new ObjectParameter("IdCorporativo", idCorporativo) :
                new ObjectParameter("IdCorporativo", typeof(int));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MIEMBROS_SIUD", idMiembroParameter, nombresParameter, apellidosParameter, dUIParameter, nITParameter, fechaNacimientoParameter, direccionParameter, direccion1Parameter, direccion2Parameter, emailParameter, telParameter, celParameter, sexoParameter, estadoCivilParameter, idProfesionParameter, idCapacitacionParameter, idPastoreoParameter, idCorporativoParameter, bANDERAParameter);
        }
    
        public virtual int PARENTESCOS_SIUD(Nullable<int> idParentesco, string nombre, string bANDERA)
        {
            var idParentescoParameter = idParentesco.HasValue ?
                new ObjectParameter("IdParentesco", idParentesco) :
                new ObjectParameter("IdParentesco", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PARENTESCOS_SIUD", idParentescoParameter, nombreParameter, bANDERAParameter);
        }
    
        public virtual int PROFESION_SIUD(Nullable<int> idProfesion, string descripcion, Nullable<bool> oficio, string bANDERA)
        {
            var idProfesionParameter = idProfesion.HasValue ?
                new ObjectParameter("IdProfesion", idProfesion) :
                new ObjectParameter("IdProfesion", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var oficioParameter = oficio.HasValue ?
                new ObjectParameter("Oficio", oficio) :
                new ObjectParameter("Oficio", typeof(bool));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROFESION_SIUD", idProfesionParameter, descripcionParameter, oficioParameter, bANDERAParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int ZONA_SIUD(Nullable<int> idZona, string nombre, string descripcion, string direccion, Nullable<int> idLiderZona, string bANDERA)
        {
            var idZonaParameter = idZona.HasValue ?
                new ObjectParameter("IdZona", idZona) :
                new ObjectParameter("IdZona", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var idLiderZonaParameter = idLiderZona.HasValue ?
                new ObjectParameter("IdLiderZona", idLiderZona) :
                new ObjectParameter("IdLiderZona", typeof(int));
    
            var bANDERAParameter = bANDERA != null ?
                new ObjectParameter("BANDERA", bANDERA) :
                new ObjectParameter("BANDERA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ZONA_SIUD", idZonaParameter, nombreParameter, descripcionParameter, direccionParameter, idLiderZonaParameter, bANDERAParameter);
        }
    }
}