using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Carolina Teixeira Araujo
             * ETML Papp stage
             * programme: calculatrice
             * 07.09.2023
             */

            // Definition des variables
            int res = 0;                            // Variable d'entrée du resultat
            int num1 = 0; 










            do
            {

                int res;
                Console.WriteLine("entrer votre premier chiffre");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer votre deuxieme chiffre");

                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer l'opération (+,-,*,/) :");
                string opération = Console.ReadLine();

                switch (opération)
                {

                    case "+":

                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;

                    case "-":

                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;

                    case "*":

                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;

                    case "/":

                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;

                }
                Console.ReadLine();
            }
            while (true);
        }
        private static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
