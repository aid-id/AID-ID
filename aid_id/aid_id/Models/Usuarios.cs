using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aid_id.Models
{
    public partial class Usuarios
    {
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_usuario { get; set; }

        // Creacion de todos los campos de la tabla
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Usuario { get; set; }

        public string Passcode { get; set; }

        public string Correo { get; set; }

        public byte Edad { get; set; }

        public byte Peso { get; set; }

        public decimal Altura { get; set; }

        public byte Glucemia_min { get; set; }

        public byte Glucemia_max { get; set; }

        public byte R_insulina_carb { get; set; }

        public byte R_insulina_gluc { get; set; }

        public short Total_insulina_diaria { get; set; }

        // "Collection navigation property" de tipo analisis
        public virtual ICollection<Analisis> Analisis { get; set; }
    }
}