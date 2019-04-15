using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool first = true;
            try
            {
                using (db_diabetesEntities4 db = new db_diabetesEntities4())
                {
                    try
                    {
                        if (first)
                        {
                            //SELECT
                            Console.Write("Introduce tu correo: ");
                            string inputEmail = Console.ReadLine(); //RaulCaro38@gmail.com
                            Console.Write("Introduce tu password: ");
                            string inputPass = Console.ReadLine(); //123abc
                            var selectCorreo = db.Usuarios;

                            var res = (from e in selectCorreo
                                       where e.correo == inputEmail
                                       where e.passcode == inputPass
                                       select e).First();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Loggin Success");
                            Console.ResetColor();
                        } 
                    }
                    catch (InvalidOperationException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Login fail");
                        Console.ResetColor();
                    }
                }
                Console.ReadKey();
            }catch(System.Data.SqlClient.SqlException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Error conection");
                Console.ResetColor();
            }
        }
    }
}
