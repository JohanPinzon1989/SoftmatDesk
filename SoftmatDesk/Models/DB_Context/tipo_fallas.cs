//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftmatDesk.Models.DB_Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_fallas
    {
        public int idFallas { get; set; }
        public int Categorias_idCategorias { get; set; }
        public string Fuente { get; set; }
        public string Descripcion { get; set; }
        public string Link { get; set; }
    
        public virtual categorias categorias { get; set; }
    }
}
