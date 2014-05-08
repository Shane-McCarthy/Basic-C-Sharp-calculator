using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void IdentifyProg(string MenuOpt)
        {
            
            switch (MenuOpt)
            {
                case "1" :
                    Console.WriteLine("Where sum = OperandA + OperandB: ");
                    break;
                case "2":
                    Console.WriteLine("Where difference = OperandA - OperandB: ");
                    break;
                case "3":
                    Console.WriteLine("Where product = A * B");
                    break;
                case "4":
                    Console.WriteLine("Where quotient =  A / B ");
                    break;
                case "5":
                    Console.WriteLine("Where modulus = A % B ");
                    break;
                default:
                    Console.WriteLine("Invalid entry, Please restart the application");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break; 
            }
        }
        static void calculator_prog(string menu_opt)
        {
            Console.Write("Enter OperandA:");
            float input1;
            if (!float.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Invalid entry, Please restart the application");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.Write("Enter OperandB:");
            float input2;
            if (!float.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Invalid entry, Please restart the application");
                Console.ReadLine();
                Environment.Exit(0);
            }
            switch (menu_opt)
            {
                case "1":
                    Console.WriteLine("Sum = " + (input1 + input2));
                    
                    break;
                case "2":
                    
                    Console.WriteLine("difference = " + (input1 - input2));
                    break;

                case "3":
                    
                    Console.WriteLine("product = " +  (input1 * input2));
                    break;

                case "4":
                    
                    Console.WriteLine("quotient = " + (input1 / input2));
                    break;
                case "5":
                    
                    Console.WriteLine("modulus = "+ (input1 % input2));
                    break;
              
                default:
                    Console.WriteLine("Invalid entry, Please restart the application");
                    Console.ReadLine(); 
                    break; 
                
                   
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("CALCULATOR MENU");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide number by another");
            Console.WriteLine("5) Calculate the remainder from dividing one number by another");
            Console.Write("Please make your selection:" );
            string MenuOpt = Console.ReadLine();
           // int menu_opt = Convert.ToInt32(myStringVar);
            IdentifyProg(MenuOpt);
            calculator_prog(MenuOpt);
            Console.WriteLine("The operation has successfully completed");
            Console.WriteLine("Please hit enter to stop the program");
            Console.ReadLine();
           
            
        }
    }
}
