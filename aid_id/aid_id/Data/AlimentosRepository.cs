using aid_id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aid_id.Data
{
    public class AlimentosRepository
    {
        public IEnumerable<SelectListItem> GetAlimentos()
        {
            using (var context = new Aid_idContext())
            {
                List<SelectListItem> alimentos = context.Alimentos.AsNoTracking()
                    .OrderBy(n => n.Nombre)
                    .Select(n =>
                    new SelectListItem
                    {
                        Value = n.Carbohidratos.ToString(),
                        Text = n.Nombre
                    }).ToList();
                var alimentostip = new SelectListItem()
                {
                    Value = null,
                    Text = "--Escoge un alimento--"
                };
                alimentos.Insert(0, alimentostip);
                return new SelectList(alimentos, "Value", "Text");
            }
        }
    }
}