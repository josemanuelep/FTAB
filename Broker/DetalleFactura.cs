//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int idFactura { get; set; }
        public int idProducto { get; set; }
        public int precioUnitario { get; set; }
        public int cantidad { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
