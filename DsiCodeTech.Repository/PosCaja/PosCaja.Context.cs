﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsiCodeTech.Repository.PosCaja
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pos_caja_Entities : DbContext
    {
        public pos_caja_Entities()
            : base("name=pos_caja_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<cfdi_objeto_impuesto> cfdi_objeto_impuesto { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
        public virtual DbSet<factura_venta> factura_venta { get; set; }
        public virtual DbSet<impuestos> impuestos { get; set; }
        public virtual DbSet<oferta> oferta { get; set; }
        public virtual DbSet<oferta_articulo> oferta_articulo { get; set; }
        public virtual DbSet<permiso> permiso { get; set; }
        public virtual DbSet<pos_control> pos_control { get; set; }
        public virtual DbSet<pos_settings> pos_settings { get; set; }
        public virtual DbSet<promocion> promocion { get; set; }
        public virtual DbSet<promocion_articulo> promocion_articulo { get; set; }
        public virtual DbSet<unidad_medida> unidad_medida { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuario_permiso> usuario_permiso { get; set; }
        public virtual DbSet<venta_cancelada_articulo> venta_cancelada_articulo { get; set; }
        public virtual DbSet<venta_devolucion> venta_devolucion { get; set; }
        public virtual DbSet<venta_devolucion_articulo> venta_devolucion_articulo { get; set; }
        public virtual DbSet<venta_cancelada> venta_cancelada { get; set; }
        public virtual DbSet<venta> venta { get; set; }
        public virtual DbSet<venta_articulo> venta_articulo { get; set; }
    }
}