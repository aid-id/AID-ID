using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aid_id.Models.BBDD
{
    public partial class Analisis
    {
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        public long id_analisis { get; set; }

        // Creacion de todos los campos de la tabla
        public byte valor { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha_hora { get; set; }

        public byte intensidad_deporte { get; set; }

        public long id_usuario { get; set; }

        // "Collection navigation property" de tipo comidas
        public virtual ICollection<Comidas> Comidas { get; set; }

        // "Navigation property". Foreign key de la tabla usuarios
        public virtual Usuarios Usuarios { get; set; }
    }
}


