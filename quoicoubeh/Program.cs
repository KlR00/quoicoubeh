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
            //string opération                       // Variable d'entrée de l'opération









            do
            {

                //int res;

                Console.WriteLine("entrer votre premier nombre");  
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer votre deuxieme nombre");

                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entrer l'opération (+,-,*,/) :");
                string opération = Console.ReadLine();

                int result = 0;

                switch (opération)                  // redirige l'action sur le choix du utilisateur          
                {
                    
                    case "+":

                        //res = num1 + num2;
                        //Console.WriteLine("Addition:" + res);
                        result = Addition(num1, num2);
                        Console.WriteLine(result);                         // Affichage du resultat de l'addition
                        break;                                             // sortie de la boucle 

                    case "-":

                        //res = num1 - num2;
                        //Console.WriteLine("Subtraction:" + res);
                        result = Subtraction(num1, num2);
                        Console.WriteLine(result);                         // Affichage du resultat de la subtraction 
                        break;                                             // sortie de la boucle

                    case "*":

                        //res = num1 * num2;
                        //Console.WriteLine("Multiplication:" + res);
                        result = Multiplication(num1, num2);
                        Console.WriteLine(result);                         // Affichange du resultat de la mutiplication
                        break;                                             // sortie de la boucle 

                    case "/":

                        //res = num1 / num2;
                        //Console.WriteLine("Division:" + res);
                        result = Division(num1, num2);
                        Console.WriteLine(result);                         // Affichange du resultat de la division    
                        break;                                             // sortie de la boucle 

                }
                Console.ReadLine();
            }
            while (true);
        }
        private static int Addition(int num1, int num2)           // Méthode pour additionner deux nombres 
        {
            int result = num1 + num2;
            return result;
            
        }

        private static int Subtraction(int num1, int num2)         // méthode pour soustraire deux nombres
        {
            int result = num1 - num2;
            return result;
            
        }

        private static int Multiplication(int num1, int num2)      // methode pour multiplier deux nombres
        {
            int result = num1 * num2;
            return result;
            
        }

        private static int Division(int num1, int num2)            // methode pour diviser deux nombres
        {
            int result = num1 / num2;
            return result;
            
        }
            


    }

}
