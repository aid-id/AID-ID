using System;

namespace Project
{
    public class Meal
    {
        public int id = 0;
        public string name = "";
        public int kCal;
        public int carbohydrates = 0;
        public int proteins = 0;
        public int grease = 0;
        public int salt = 0;

        /// <summary>
        /// Recoge los valores de los alimentos individuales que componen cada consumición.
        /// </summary>
        /// <param name="id">Indica el id del alimento que le corresponde en la base de datos.</param>
        /// <param name="name">Indca el nombre del alimento.</param>
        /// <param name="kCal">Indica las kCalorías del alimento.</param>
        /// <param name="carbohydrates">Indica los carbohidratos del alimento.</param>
        /// <param name="proteins"></param>
        /// <param name="grease"></param>
        /// <param name="salt"></param>
        public Meal(int id, string name, int kCal, int carbohydrates, int proteins, int grease, int salt)
        {
            this.id             = id;
            this.name           = name;
            this.kCal           = kCal;
            this.carbohydrates  = carbohydrates;
            this.proteins       = proteins;
            this.grease         = grease;
            this.salt           = salt;
        }
    }
}
