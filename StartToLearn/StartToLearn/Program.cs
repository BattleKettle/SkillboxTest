using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartToLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, мир! \nЯ снова сюда попал." );
            Console.WriteLine("Это однострочный вывод");
            Console.WriteLine("И это однострочный");
            Console.WriteLine("А это раздельный\nвывод текста");
            Console.Write("Hello");
            Console.Write(" World");
            Console.Write(" >:D");

            //Console.ReadKey(); почему нельзя использовать эту задержку, так же тоже должно работать?
           
            Console.ReadLine();
        }
    }
}
