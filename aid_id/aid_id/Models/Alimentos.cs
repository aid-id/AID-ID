using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aid_id.Models
{
    public partial class Alimentos
    {
        // Necesario para crear una relacion N:M. En la otra tabla hay que hacer lo mismo. EF generará la tabla intermedia automaticamente.
        public Alimentos()
        {
            this.Comidas = new HashSet<Comidas>();
        }

        // Primary key. Entity Framework siempre buscara por una palabra que contenga ID
        [Key]
        public long Id_alimento { get; set; }

        // Creacion de todos los campos de la tabla
        public string nombre { get; set; }

        public decimal carbohidratos { get; set; }

        public decimal proteinas { get; set; }

        public decimal grasas { get; set; }


        // "Collection navigation property" de tipo comida
        public virtual ICollection<Comidas> Comidas { get; set; }
    }
}
