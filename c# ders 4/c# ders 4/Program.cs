using System.Text;

namespace c__ders_4
{
    public class Program
    {
        public static List<List<heyvan>> animals;

        static void Main(string[] args)
        {
            List<heyvan> cats = new List<heyvan>()
            {
                new cat("Mestan",12,"Erkek",100,80,12.3f),
                new cat("Cici",12,"Disi",100,80,12.3f),
                new cat("Maci",12,"Disi",100,80,12.3f),
                new cat("Ciyciy",12,"Erkek",100,80,12.3f)
            };
            List<heyvan> dogs = new List<heyvan>()
            {
                new dog("Cem",12,"Erkek",100,80,12.3f),
                new dog("Reks",12,"Disi",100,80,12.3f),
                new dog("Alabula",12,"Erkek",100,80,12.3f),
                new dog("Bim",12,"Disi",100,80,12.3f),
                new dog("Xaski",12,"Erkek",100,80,12.3f)
            };


            animals = new List<List<heyvan>>();
            animals.Add(dogs);
            animals.Add(cats);

            Start();
        }

        static void Start()
        {
            int secim;
            Console.WriteLine("1 dog  \n2 cat  \nSecim edin :");
            secim = int.Parse(Console.ReadLine());
            int yemekSayi = 0;
            float QiymetSayi = 0;
            while (true)
            {
                for (int i = 0; i < animals[secim-1].Count; i++)
                {
                    Console.WriteLine(animals[secim - 1][i].nickname);
                }
                Console.WriteLine("Hansi Bisikle oynamaq isdeyirsen onun adini qeyd et");
                string? sec;
                sec=Console.ReadLine();
                for (int i = 0; i < animals[secim - 1].Count; i++)
                {
                    if (sec== animals[secim - 1][i].nickname)
                    {
                        
                        while (true)
                        {
                            Thread.Sleep(3000);
                            Console.Clear();

                            int secimm;
                            Console.WriteLine("1 oynamaq\n2 Yemek yemek\n3 Yatmaq\n4 Yemek ve Qiymet artiminin siyahisi \nSecim edin: ");
                            secimm = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (secimm == 1)
                            {
                                animals[secim - 1][i].play();
                                animals[secim - 1][i].show(secim, animals,i);
                            }
                            else if (secimm == 2)
                            {
                                animals[secim - 1][i].eat();
                                animals[secim - 1][i].mealQuantity += 1.5f;
                                QiymetSayi+=1.5f;
                                animals[secim - 1][i].price += 1;
                                yemekSayi++;
                                animals[secim - 1][i].show(secim, animals, i);
                            }
                            else if(secimm == 3)
                            {
                                animals[secim - 1][i].sleep();
                                animals[secim - 1][i].show(secim, animals, i);
                            }
                            else if (secimm == 4)
                            {
                                Console.WriteLine("Yemek Sayi  : "+ yemekSayi+"\nQiymet artimi  : "+ QiymetSayi);
                            }
                            else
                            {
                                Console.WriteLine("Ele secim yoxdur");
                            }
                        }
                    }
                   
                }

                
            }
        }
       
        static void removeByName(string name)
        {
            foreach (var item in animals)
            {
                foreach (var item2 in item)
                {
                    if (item2.nickname == name)
                        item.Remove(item2);
                }
            }
            
        }
        
        
       
    }
}