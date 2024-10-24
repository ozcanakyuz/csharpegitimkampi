using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali YILDIZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan OZTURK");
            //    Console.WriteLine("Merve CINAR");
            //}
            //CustomerList();


            string StudentCard()
            {
                string name = "ALI";
                string surname = "KAYA";

                return name + " " + surname;
            }

            Console.WriteLine(StudentCard());

            Console.Read();
        }
    }
}
