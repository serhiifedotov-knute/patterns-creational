using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class Food {
        public string[] ingridients = new string[10];
        private int ingridientsCount = 0;

        public void AddIngridient(string ingridient) {
            this.ingridients[ingridientsCount++] = ingridient;
        }

        public Food Clone() {
            Food food = new Food();
            for(int i = 0; i < ingridientsCount; i++) {
                food.AddIngridient(this.ingridients[i]);
            }
            return food;
        }

    }
}
