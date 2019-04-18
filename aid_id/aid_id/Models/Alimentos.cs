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
        public string Nombre { get; set; }

        public decimal Carbohidratos { get; set; }

        public decimal Proteinas { get; set; }

        public decimal Grasas { get; set; }


        // "Collection navigation property" de tipo comida
        public virtual ICollection<Comidas> Comidas { get; set; }
    }
}