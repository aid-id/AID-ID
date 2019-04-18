using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aid_id.Models
{
    public class Usuarios
    {
        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_usuario { get; set; }

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

        
    }
}