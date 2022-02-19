using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3
{
    internal class Password
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter your Password:");
                //ConsoleKeyInfo ck = Console.ReadKey(true);
                //ConsoleKey and ConsoleKey are defined in System namespace
                ConsoleKeyInfo ck = Console.ReadKey(true); //hides pressed keychar on console
                string password = "";
                while (ck.Key!=ConsoleKey.Enter)
                {
                    Console.Write("*");
                    password = password + ck.KeyChar;
                    ck = Console.ReadKey(true);
                }
                Console.WriteLine("\nEntered Password:"+password);

                /* Console.Write("*"); 
                   Console.WriteLine("\nPressed Key:"+ck.Key); //ConsoleKey
                  if(ConsoleKey.Enter!=ck.Key)
                      Console.WriteLine("KeyChar:"+ck.KeyChar);
                */
            
        }
    }
}
