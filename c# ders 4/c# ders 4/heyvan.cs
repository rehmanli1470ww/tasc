using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ders_4
{
    public class heyvan
    {
        public string nickname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int energy { get; set; }
        public int price { get; set; }
        public float mealQuantity { get; set; }
        
        public heyvan(string nickname, int age, string gender, int energy, int price, float mealQuantity)
        {
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.energy = energy;
            this.price = price;
            this.mealQuantity = mealQuantity;

        }
        public void eat()
        {
            energy += 20;
            if ( energy>=100) {
                energy = 100;
            }
           
        }
        public void sleep()
        {
            energy = 100;
           
        }
        public void play()
        {
            energy -= 20;
            if(energy==0)
            {
                sleep();
            }
            
        }
        public void show(int secim, List<List<heyvan>> animals,int i)
        {
            Console.WriteLine("Nickname  " + animals[secim - 1][i].nickname + "\nAge  " + animals[secim - 1][i].age +
                     "\nGender  " + animals[secim - 1][i].gender + "\nEnergy  " + animals[secim - 1][i].energy + "\nPrice  " + animals[secim - 1][i].price
                     + "\nMealQuantity  " + animals[secim - 1][i].mealQuantity);
        }


    }
}
