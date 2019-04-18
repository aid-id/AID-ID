using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace aid_id.Models
{
    public class Analisis
    {
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_analisis { get; set; }

        // Creacion de todos los campos de la tabla
        public byte valor { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha_hora { get; set; }

        public byte intensidad_deporte { get; set; }

    }
}