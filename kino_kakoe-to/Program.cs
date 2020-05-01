using System;

namespace ypok_
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Привет!Это супер программа поможет подобрать тебе фильм на вечер...");

                Console.WriteLine("Как вас зовут?");
                String name = Console.ReadLine();
                Console.WriteLine("Здравствуйте, " + name);

                
                Console.WriteLine("Фильм какого жанра вы хотели посмотреть:коммедия, драмма, фантастика, триллер, боевик");
                string genry = Console.ReadLine();

                Console.WriteLine("В таком случае рекомендую посмотреть...");
            if (genry == "коммедия")
            {
                Console.WriteLine("наши? | забугорные?");
                string choose = Console.ReadLine();

                if (choose == "наши")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    Console.WriteLine("Иван Васильевич меняет профессию");
                    Console.WriteLine("Операция 'Ы' ");
                    
                }
                else if(choose == "забугорные")
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Зомбоящик");
                    Console.WriteLine("Секс в большом городе");
                    Console.WriteLine("Майор Пейн");
                }
            }
            else if (genry == "триллер")
            {
                Console.WriteLine("*Молчание ягнят");
                Console.WriteLine("*Сплит");
            }
            else if (genry == "боевик")
            {
                Console.WriteLine("*Терминатор");
                Console.WriteLine("*Книга Илая");
            }
            else if (genry == "фантастика") 
            {
                Console.WriteLine("*Гарри Поттер");
                Console.WriteLine("*Дорогая я уменьшил наших детей");
            }
            else
            {
                Console.WriteLine("Зеленая миля");
                Console.WriteLine("Виноваты звезды");
                Console.WriteLine("Побег из шоушенка");

            }
                Console.ReadLine();
            }
        }
}
