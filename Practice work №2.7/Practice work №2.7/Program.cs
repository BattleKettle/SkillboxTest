using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_work__2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Nick Gregory Hamvell";
            string email = "greg@gmail.com";
            int age = 25;
            int progGrade = 3;
            int mathGrade = 4;
            int phizGrade = 5;
            double midGrade = (progGrade+mathGrade+phizGrade)/3;
            Console.WriteLine("\nФ.И.О.:{0}\nВозвраст:{1}\nEmail:{2}\nБаллы про программированию:{3}\nБаллы по математике:{4}\nБаллы по физике:{5}\nСредний балл:{6}", fullName, age, email, progGrade, mathGrade, phizGrade, midGrade);
            Console.ReadKey();
            Console.Write("Thanks for your visit, i fope you are in good mood. If not, know, you are a buatifull person and you can became who ever you want. Good luck!");
            Console.ReadKey();
        }
    }
}
