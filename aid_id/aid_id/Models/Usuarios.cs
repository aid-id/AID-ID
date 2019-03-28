using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aid_id.Models
{
    public class Usuarios
    {

        /* Declareting atributs for Class Usuarios */
        //Private atributes for security

        private string name = "";
        private string surname = "";
        private int older = 0;
        private float uWeith = 0;
        private float uHeight = 0;
        private int gluMin = 0;
        private int gluMax = 0;
        private int insuCarb = 0;
        private int insuGluc = 0;
        private int insuTotal = 0;

        // Getter and Setter to Atributs for Security
        // Public attribs for easy acces

        public string Name { get => name; set => name;}
        public string Surname { get => surname; set => surname; }
        public string Older { get => older; set => older; }
        public string UWeith { get => uWeith; set => uWeith; }
        public string UHeight { get => UHeight; set => UHeight; }
        public string GluMin { get => GluMin; set => GluMin; }
        public string GluMax { get => GluMax; set => GluMax; }
        public string InsuCarb { get => InsuCarb; set => InsuCarb; }
        public string InsuGluc { get => InsuGluc; set => InsuGluc; }
        public string InsuTotal { get => InsuTotal; set => InsuTotal; }

        //modificacción de prueba 
        public int modificacion = 100;


    }
}