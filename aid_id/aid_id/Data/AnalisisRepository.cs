using aid_id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aid_id.Data
{
    public class AnalisisRepository
    {
        public NuevoAnalisis CrearAnalisis()
        {
            var alRepo = new AlimentosRepository();
            var analisis = new NuevoAnalisis()
            {
                Id_NuevoAnalisis = Guid.NewGuid(),
                Alimentos = alRepo.GetAlimentos()
            };
            return analisis;
        }
    }
}