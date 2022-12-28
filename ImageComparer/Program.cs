using System;

namespace ImageComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine("Введите путь до 1 картинки");
            var path1 = Console.ReadLine();
            Console.WriteLine("Введите путь до 2 картинки");
            var path2 = Console.ReadLine();

            var result = ImageManager.CompareImages(path1, path2);
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Картинки идентичны");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Картинки разные");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

