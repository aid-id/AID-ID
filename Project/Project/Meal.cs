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

        public Meal(int id, string name, int kCal, int carbohydrates, int proteins, int grease, int salt)
        {
            this.id = id;
            this.name = name;
            this.kCal = kCal;
            this.carbohydrates = carbohydrates;
            this.proteins = proteins;
            this.grease = grease;
            this.salt = salt;
        }
    }
}
