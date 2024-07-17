using System;

namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args) 
        {
            System.Console.WriteLine("Köylüm Manavina Hoş Geldiniz!");
            System.Console.WriteLine("Elma = 2 TL");
            System.Console.WriteLine("Armut = 3 TL");
            System.Console.WriteLine("Çilek = 2 TL");
            System.Console.WriteLine("Muz = 3 TL");
            System.Console.WriteLine("Diğer bütün meyveler = 4 TL");

            System.Console.WriteLine("");

            System.Console.Write("Hangi meyveyi satin almak isterseniz? (Elma/Armut/Çilek/Muz/Diger): ");
            string fruit = Console.ReadLine();  // kullanıcıdan meyve ismini istediğimiz metod 
            fruit =  fruit.ToLower(); // kullanıcı ilk harfi büyük harfle girildiğinde if koşulunda eşit olmasını sağlayan metod
            // if - else çözümü
            /*
        
            if (fruit == "muz") // kullanıcıdan aldığımız meyve ismini karşılaştırdığımız durum
            {
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                
            }
            else if (fruit == "elma") // kullanıcıdan aldığımız meyve ismini karşılaştırdığımız durum
            {
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }
            else if(fruit == "armut") // kullanıcıdan aldığımız meyve ismini karşılaştırdığımız durum
            {
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }
            else if (fruit == "çilek") // kullanıcıdan aldığımız meyve ismini karşılaştırdığımız durum
            {
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }
            else  // kullanıcıdan aldığımız meyve ismini karşılaştırdığımız durum
            {
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
            }
*/
            // swit-case çözümü

            switch (fruit)
            {
                case "muz":
                    System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                case "elma":
                    System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case "armut":
                    System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;

                case "çilek":
                    System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                
                default:
                System.Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                break;
            }

        }
    }
}
