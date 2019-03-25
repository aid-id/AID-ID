using System;

namespace aid_id
{
    public class Meals
    {
        public int id = 0;
        public DateTime realTime;
        public enum Type
        {
            DESAYUNO,
            COMIDA,
            MERIENDA,
            CENA,
            OTROS
        }
        public Type meal;
        public int totalKCal;
    }
}
