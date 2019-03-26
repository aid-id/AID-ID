using System;

namespace Project
{
    public class Food
    {
        public DateTime realTime;
        public enum Type
        {
            DESAYUNO,
            ALMUERZO,
            COMIDA,
            MERIENDA,
            CENA,
            OTROS
        }
        public Type food;
        public int totalKCal;

        /// <summary>
        /// Recoge los valores de la consumición del total de alimentos en un mismo momento.
        /// </summary>
        /// <param name="realTime">Indica la fecha y la hora en la que se ha consumido.</param>
        /// <param name="food">Indica el tipo de alimento según el horario de consumición habitual.</param>
        /// <param name="totalKCal">Indica el total de kCalorías consumidas entre 
        /// todos los alimentos de la consumición.</param>
        public Food(DateTime realTime, Type food, int totalKCal)
        {
            this.realTime   = realTime;
            this.food       = food;
            this.totalKCal  = totalKCal;
        }
    }
}
