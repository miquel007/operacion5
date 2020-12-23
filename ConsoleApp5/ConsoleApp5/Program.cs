using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escrive un numero");
            string Ntrap = Console.ReadLine();
            int num1 = Convert.ToInt32(Ntrap);

            Console.WriteLine("Escrive un numero");
            string Ntrap1 = Console.ReadLine();
            int num2 = Convert.ToInt32(Ntrap1);

            Console.WriteLine("Escrive un numero");
            string Ntrap2 = Console.ReadLine();
            int num3 = Convert.ToInt32(Ntrap2);

            Console.WriteLine("Escrive un numero");
            string Ntrap3 = Console.ReadLine();
            int num4 = Convert.ToInt32(Ntrap3);

            Console.WriteLine("Variable a = " + num1);
            Console.WriteLine("Variable b = " + num2);
            Console.WriteLine("Variable c = " + num3);
            Console.WriteLine("Variable d = " + num4);

            int num5 = num2;
            num2 = num3;
            num3 = num1;
            num1 = num4;
            num4 = num5;




            Console.WriteLine("New Variable a = " + num1);
            Console.WriteLine("New Variable b = " + num2);
            Console.WriteLine("New Variable c = " + num3);
            Console.WriteLine("New Variable d = " + num4);

        }
    }
}
