using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aid_id.Models
{
    public partial class Comidas
    {
        // Necesario para crear una relacion N:M. En la otra tabla hay que hacer lo mismo. EF generará la tabla intermedia automaticamente.
        public Comidas()
        {
            this.Alimentos = new HashSet<Alimentos>();
        }

        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_comida { get; set; }

        // Creacion de todos los campos de la tabla
        public System.DateTime Fecha_hora { get; set; }

        public string Tipocomida { get; set; }

        public Nullable<decimal> Carbo_totales { get; set; }

        public Nullable<long> Id_analisis { get; set; }


        // "Collection navigation property" de tipo alimentos
        public virtual ICollection<Alimentos> Alimentos { get; set; }

        // "Navigation property". Foreign key de la tabla analisis
        public virtual Analisis Analisis { get; set; }
    }
}