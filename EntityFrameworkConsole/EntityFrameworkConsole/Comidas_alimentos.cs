//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comidas_alimentos
    {
        public long id_comidas_alimentos { get; set; }
        public Nullable<long> id_comida { get; set; }
        public Nullable<long> id_alimento { get; set; }
    
        public virtual Alimentos Alimentos { get; set; }
        public virtual Comidas Comidas { get; set; }
    }
}