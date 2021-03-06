﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aid_id.Models
{
    public class NuevoAnalisis
    {
        [Key]
        public Guid Id_NuevoAnalisis { get; set; }

        public int Valor { get; set; }

        [Display(Name = "Alimento")]
        public string NombreAlimento { get; set; }
        public IEnumerable<SelectListItem> Alimentos { get; set; }

        [Display(Name = "Intensidad del deporte")]
        public SelectList IntensidadDeporte { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime FechaHora { get; set; }

        public int Id_Usuario { get; set; }
    }
}