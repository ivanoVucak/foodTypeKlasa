using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodTypeKlasa
{
    internal class foodType
    {
        string name;
        int protein, carbs, fat;


        public void setName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void setProtein(int protein)
        {
            this.protein = protein;
        }
        public int GetProtein()
        {
            return this.protein;
        }

        public void setCarbs(int carbs)
        {
            this.carbs = carbs;
        }
        public int GetCarbs()
        {
            return this.carbs;
        }

        public void setFat(int fat)
        {
            this.fat = fat;
        }
        public int GetFat()
        {
            return this.fat;
        }


        public override string ToString()
        {
            string ispis = "Name: " + this.GetName() + "\n"
                + "Protein: " + this.GetProtein() + "%\n"
                + "Carbs: " + this.GetCarbs() + "%\n"
                + "Fat: " + this.GetFat() + "%\n";
            return ispis;
        }



        public foodType(String name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }
        public foodType() { }
    }
}
