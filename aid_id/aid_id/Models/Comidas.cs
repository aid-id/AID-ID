using System;
using System.Collections.Generic;


namespace aid_id.Models.BBDD
{
    public partial class Comidas
    {
        // Necesario para crear una relacion N:M. En la otra tabla hay que hacer lo mismo. EF generar� la tabla intermedia automaticamente.
        public Comidas()
        {
            this.Alimentos = new HashSet<Alimentos>();
        }

        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        public long id_comida { get; set; }

        // Creacion de todos los campos de la tabla
        public System.DateTime fecha_hora { get; set; }

        public string tipocomida { get; set; }

        public Nullable<decimal> carbo_totales { get; set; }

        public Nullable<long> id_analisis { get; set; }


        // "Collection navigation property" de tipo alimentos
        public virtual ICollection<Alimentos> Alimentos { get; set; }

        // "Navigation property". Foreign key de la tabla analisis
        public virtual Analisis Analisis { get; set; }
    }
}
