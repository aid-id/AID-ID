using System;
using System.Collections.Generic;


namespace aid_id.Models.BBDD
{
    public partial class Usuarios
    {
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        public long id_usuario { get; set; }

        // Creacion de todos los campos de la tabla
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string usuario { get; set; }

        public string passcode { get; set; }

        public string correo { get; set; }

        public byte edad { get; set; }

        public byte peso { get; set; }

        public decimal altura { get; set; }

        public byte glucemia_min { get; set; }

        public byte glucemia_max { get; set; }

        public byte r_insulina_carb { get; set; }

        public byte r_insulina_gluc { get; set; }

        public short total_insulina_diaria { get; set; }

        // "Collection navigation property" de tipo analisis
        public virtual ICollection<Analisis> Analisis { get; set; }
    }
}
