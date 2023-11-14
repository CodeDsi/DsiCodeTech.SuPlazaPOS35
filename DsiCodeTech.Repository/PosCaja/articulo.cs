//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public articulo()
        {
            this.oferta_articulo = new HashSet<oferta_articulo>();
            this.promocion_articulo = new HashSet<promocion_articulo>();
            this.venta_cancelada_articulo = new HashSet<venta_cancelada_articulo>();
            this.impuestos = new HashSet<impuestos>();
            this.venta_articulo = new HashSet<venta_articulo>();
        }
    
        public string cod_barras { get; set; }
        public string cod_asociado { get; set; }
        public long id_clasificacion { get; set; }
        public string cod_interno { get; set; }
        public string descripcion { get; set; }
        public string descripcion_corta { get; set; }
        public decimal cantidad_um { get; set; }
        public System.Guid id_unidad { get; set; }
        public System.Guid id_proveedor { get; set; }
        public decimal precio_compra { get; set; }
        public decimal utilidad { get; set; }
        public decimal precio_venta { get; set; }
        public string tipo_articulo { get; set; }
        public decimal stock { get; set; }
        public decimal stock_min { get; set; }
        public decimal stock_max { get; set; }
        public Nullable<System.DateTime> kit_fecha_ini { get; set; }
        public Nullable<System.DateTime> kit_fecha_fin { get; set; }
        public bool articulo_disponible { get; set; }
        public bool kit { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public bool visible { get; set; }
        public short puntos { get; set; }
        public System.DateTime last_update_inventory { get; set; }
        public string cve_producto { get; set; }
        public string id_objeto_impuesto { get; set; }
    
        public virtual cfdi_objeto_impuesto cfdi_objeto_impuesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<oferta_articulo> oferta_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promocion_articulo> promocion_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_cancelada_articulo> venta_cancelada_articulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<impuestos> impuestos { get; set; }
        public virtual unidad_medida unidad_medida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta_articulo> venta_articulo { get; set; }
    }
}