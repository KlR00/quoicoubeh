using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("addition:" + res);
                break;

              case "/":

                res = num1 / num2;
                Console.WriteLine("division:" + res);
                break;

           }
             Console.ReadLine();
               
            
            

            
        }
    }
}
