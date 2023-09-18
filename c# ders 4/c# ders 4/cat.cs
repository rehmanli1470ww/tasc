using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ders_4
{
    public class cat : heyvan
    {
        public cat(string nickname, int age, string gender, int energy, int price, float mealQuantity) : base(nickname, age, gender, energy, price, mealQuantity)
        {
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.energy = energy;
            this.price = price;
            this.mealQuantity = mealQuantity;

        }

    }
}
