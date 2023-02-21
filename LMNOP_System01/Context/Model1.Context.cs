﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMNOP_System01.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LMNOP_SystemEntities : DbContext
    {
        public LMNOP_SystemEntities()
            : base("name=LMNOP_SystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Roles_Permisos> Roles_Permisos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Atencion_Sucursales> Atencion_Sucursales { get; set; }
        public virtual DbSet<Centro_servicio> Centro_servicio { get; set; }
        public virtual DbSet<Tarimas_CentroServicio> Tarimas_CentroServicio { get; set; }
        public virtual DbSet<Segundas_CentroServicio> Segundas_CentroServicio { get; set; }
        public virtual DbSet<Estatus01_CentroServicio> Estatus01_CentroServicio { get; set; }
    
        public virtual ObjectResult<sp_datos_Result> sp_datos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_datos_Result>("sp_datos");
        }
    
        public virtual ObjectResult<sp_login_Result> sp_login(string usuario, string clave, string patron)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            var patronParameter = patron != null ?
                new ObjectParameter("Patron", patron) :
                new ObjectParameter("Patron", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_login_Result>("sp_login", usuarioParameter, claveParameter, patronParameter);
        }
    
        public virtual ObjectResult<sp_permisos_Result> sp_permisos(Nullable<int> id_Rol)
        {
            var id_RolParameter = id_Rol.HasValue ?
                new ObjectParameter("Id_Rol", id_Rol) :
                new ObjectParameter("Id_Rol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_permisos_Result>("sp_permisos", id_RolParameter);
        }
    
        public virtual int sp_registrar(string nombre, Nullable<int> edad, string usuario, string clave, Nullable<int> id_Rol, string patron)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            var id_RolParameter = id_Rol.HasValue ?
                new ObjectParameter("Id_Rol", id_Rol) :
                new ObjectParameter("Id_Rol", typeof(int));
    
            var patronParameter = patron != null ?
                new ObjectParameter("Patron", patron) :
                new ObjectParameter("Patron", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_registrar", nombreParameter, edadParameter, usuarioParameter, claveParameter, id_RolParameter, patronParameter);
        }
    
        public virtual ObjectResult<Consultar_Result> Consultar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Result>("Consultar");
        }
    
        public virtual int Guardar(Nullable<int> num_OF, string codigo_primera, string descripcion, Nullable<decimal> kg, Nullable<int> num_tarimas, string operadores, string turno, string pedaceria, string faltante, string sobrante, string rechazo, string observaciones, Nullable<decimal> total)
        {
            var num_OFParameter = num_OF.HasValue ?
                new ObjectParameter("Num_OF", num_OF) :
                new ObjectParameter("Num_OF", typeof(int));
    
            var codigo_primeraParameter = codigo_primera != null ?
                new ObjectParameter("Codigo_primera", codigo_primera) :
                new ObjectParameter("Codigo_primera", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var kgParameter = kg.HasValue ?
                new ObjectParameter("Kg", kg) :
                new ObjectParameter("Kg", typeof(decimal));
    
            var num_tarimasParameter = num_tarimas.HasValue ?
                new ObjectParameter("Num_tarimas", num_tarimas) :
                new ObjectParameter("Num_tarimas", typeof(int));
    
            var operadoresParameter = operadores != null ?
                new ObjectParameter("Operadores", operadores) :
                new ObjectParameter("Operadores", typeof(string));
    
            var turnoParameter = turno != null ?
                new ObjectParameter("Turno", turno) :
                new ObjectParameter("Turno", typeof(string));
    
            var pedaceriaParameter = pedaceria != null ?
                new ObjectParameter("Pedaceria", pedaceria) :
                new ObjectParameter("Pedaceria", typeof(string));
    
            var faltanteParameter = faltante != null ?
                new ObjectParameter("Faltante", faltante) :
                new ObjectParameter("Faltante", typeof(string));
    
            var sobranteParameter = sobrante != null ?
                new ObjectParameter("Sobrante", sobrante) :
                new ObjectParameter("Sobrante", typeof(string));
    
            var rechazoParameter = rechazo != null ?
                new ObjectParameter("Rechazo", rechazo) :
                new ObjectParameter("Rechazo", typeof(string));
    
            var observacionesParameter = observaciones != null ?
                new ObjectParameter("Observaciones", observaciones) :
                new ObjectParameter("Observaciones", typeof(string));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Guardar", num_OFParameter, codigo_primeraParameter, descripcionParameter, kgParameter, num_tarimasParameter, operadoresParameter, turnoParameter, pedaceriaParameter, faltanteParameter, sobranteParameter, rechazoParameter, observacionesParameter, totalParameter);
        }
    
        public virtual ObjectResult<ConsultarAS_Result> ConsultarAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarAS_Result>("ConsultarAS");
        }
    
        public virtual int GuardarAS(Nullable<int> id_AtencionSucursales, Nullable<int> num_maquila, Nullable<int> division, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora)
        {
            var id_AtencionSucursalesParameter = id_AtencionSucursales.HasValue ?
                new ObjectParameter("Id_AtencionSucursales", id_AtencionSucursales) :
                new ObjectParameter("Id_AtencionSucursales", typeof(int));
    
            var num_maquilaParameter = num_maquila.HasValue ?
                new ObjectParameter("Num_maquila", num_maquila) :
                new ObjectParameter("Num_maquila", typeof(int));
    
            var divisionParameter = division.HasValue ?
                new ObjectParameter("Division", division) :
                new ObjectParameter("Division", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("Hora", hora) :
                new ObjectParameter("Hora", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GuardarAS", id_AtencionSucursalesParameter, num_maquilaParameter, divisionParameter, fechaParameter, horaParameter);
        }
    }
}
