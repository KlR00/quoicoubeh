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
            //int res = 0;                            // Variable d'entrée du resultat
            //int num1 = 0;                           // Variable d'entrée du premier chiffre
            //int num2 = 0;                           // Variable d'entrée du deuxieme chiffre 










            do
            {

                int res;

                Console.WriteLine("entrer votre premier chiffre");  
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer votre deuxieme chiffre");

                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer l'opération (+,-,*,/) :");
                string opération = Console.ReadLine();

                switch (opération)                  // redirige l'action sur le choix du utilisateur          
                {

                    case "+":

                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);   // Affichage du resultat de l'addition
                        break;                                  // sortie de la boucle 

                    case "-":

                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);   // Affichage du resultat de la subtraction 
                        break;                                     // sortie de la boucle

                    case "*":

                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);   // Affichange du resultat de la mutiplication
                        break;                                        // sortie de la boucle 

                    case "/":

                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);    // Affichange du resultat de la division    
                        break;                                   // sortie de la boucle 

                }
                Console.ReadLine();
            }
            while (true);
        }
        private static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
            result = Addition(num1, num2);
        }

        private static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
            result = Subtraction(num1, num2);
        }

        private static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
            result = Multiplication(num1, num2);
        }

        private static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
            


    }

}
