using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_password_generator_csharp__not_form_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char type = ' ';
            string password = "", userName = Environment.UserName, path = $@"C:\Users\{userName}\AppData\Roaming\fs_psw_gen";
            int lung_passw = 0;

        inizio:

            Console.Write("How long do you want the password to be ");
            lung_passw = Convert.ToInt32(Console.ReadLine());

            Console.Write("You want only [c]haracters, [n]umber e characters, [s]ymbols numbers and characters ");
            type = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            switch (type)
            {
                case 'c':
                    password += charac(in lung_passw);
                    break;

                case 'n':
                    password += Number(in lung_passw);
                    break;

                case 's':
                    password += symbols(in lung_passw);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Type not valid");
                    goto inizio;
            }

            //Saves the password
            if (!Directory.Exists(path))
            {
                Console.WriteLine($@"The last password generated is saved in C:\Users\{userName}\AppData\Roaming\fs_psw_gen");
                //Creating the directory
                Directory.CreateDirectory(path);
                //Creating the file
                using (StreamWriter writer = File.CreateText($@"{path}\psw.txt"))
                {
                    //Saving the password
                    writer.WriteLine(password);
                }

            }
            else
            {
                //Saving the password to the file
                using (StreamWriter writer = File.CreateText($@"{path}\psw.txt"))
                {
                    writer.WriteLine(password);
                }
            }

            //Prints the password
            Console.Write(password);

            Console.ReadKey();
        }



        static string charac(in int lung_passw)
        {
            Random rnd = new Random();
            int temp;
            string password = "";
            for (int i = 0; i < lung_passw; i++)
            {
                temp = rnd.Next(0, 2);
                if (temp == 1)
                {
                    password += (char)rnd.Next(65, 91);
                }
                else
                {
                    password += (char)rnd.Next(97, 123);
                }
            }
            return $"{password}*";
        }

        static string Number(in int lung_passw)
        {
            Random rnd = new Random();
            int temp;
            string password = "";
            for (int i = 0; i < lung_passw; i++)
            {
                temp = rnd.Next(0, 3);
                if (temp == 0)
                {
                    password += (char)rnd.Next(65, 91);
                }
                else if (temp == 1)
                {
                    password += (char)rnd.Next(97, 123);
                }
                else
                {
                    password += (char)rnd.Next(48, 58);
                }
            }
            return $"{password}*";
        }

        static string symbols(in int lung_passw)
        {
            Random rnd = new Random();
            int temp;
            string password = "";
            for (int i = 0; i < lung_passw; i++)
            {
                temp = rnd.Next(0, 7);
                if (temp == 0)
                {
                    password += (char)rnd.Next(65, 91);
                }
                else if (temp == 1)
                {
                    password += (char)rnd.Next(97, 123);
                }
                else if (temp == 2)
                {
                    password += (char)rnd.Next(48, 58);
                }
                else if (temp == 3)
                {
                    password += (char)rnd.Next(33, 48);
                }
                else if (temp == 4)
                {
                    password += (char)rnd.Next(58, 64);
                }
                else if (temp == 5)
                {
                    password += (char)rnd.Next(91, 97);
                }
                else if (temp == 6)
                {
                    password += (char)rnd.Next(123, 127);
                }
            }
            return $"{password}*";
        }
    }
}
