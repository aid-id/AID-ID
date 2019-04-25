using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aid_id.Models
{
    public partial class Analisis
    {
        // Necesario para crear una relacion N:M. En la otra tabla hay que hacer lo mismo. EF generará la tabla intermedia automaticamente.
        public Analisis()
        {
            this.Alimentos = new HashSet<Alimentos>();
        }
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_analisis { get; set; }

        // Creacion de todos los campos de la tabla
        public byte Valor { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_hora { get; set; }

        public byte Intensidad_deporte { get; set; }

        public string Tipocomida { get; set; }

        public Nullable<decimal> Carbo_totales { get; set; }

        public long Id_usuario { get; set; }

        // "Collection navigation property" de tipo alimentos
        public virtual ICollection<Alimentos> Alimentos { get; set; }

        // "Navigation property". Foreign key de la tabla usuarios
        public virtual Usuarios Usuarios { get; set; }
    }
}
