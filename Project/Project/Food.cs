using System;

namespace Project
{
    public class Food
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
        public Type food;
        public int totalKCal;

        public Food(int id, DateTime realTime, Type food, int totalKCal)
        {
            this.id = id;
            this.realTime = realTime;
            this.food = food;
            this.totalKCal = totalKCal;
        }
    }
}
