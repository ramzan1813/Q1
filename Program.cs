using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number ");
            int Number01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter again a Number ");
            int Number02 = Convert.ToInt32(Console.ReadLine());
            int Numcber03=0;
           
           Console.WriteLine($" Before Swap Number 01 is : {Number01} ");

           Console.WriteLine($" Before Swap Number 02 is : {Number02} ");
            Numcber03 = Number01;
            Number01 = Number02;
            Number02 = Numcber03;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($" After Swap Number 01 is : {Number01} ");

           Console.WriteLine($" After Swap Number 02 is : {Number02} ");

           Console.ReadKey();
        }
    }
}
