using System;
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
            char[] password;
            int lung_passw ,temp = 0;
            Random rnd = new Random();

            inizio:

            Console.Write("How long do you want the password to be ");
            lung_passw = Convert.ToInt32(Console.ReadLine());

            Console.Write("You want only [c]arracters, [n]umber e carracters, [s]ymbols numbers and carracters ");
            type = Convert.ToChar(Console.ReadLine());

            //Sets the lenght of the password array to the inserted password lenght
            password = new char[lung_passw];

            Console.Clear();

            switch (type)
            {
                case 'c':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        temp = rnd.Next(0, 2);
                        if (temp == 1)
                        {
                            password[i] = (char)rnd.Next(65, 91);
                        }
                        else
                        {
                            password[i] = (char)rnd.Next(97, 123);
                        }
                    }
                    break;

                case 'n':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        temp = rnd.Next(0, 3);
                        if (temp == 0)
                        {
                            password[i] = (char)rnd.Next(65, 91);
                        }
                        else if (temp == 1)
                        {
                            password[i] = (char)rnd.Next(97, 123);
                        }
                        else
                        {
                            password[i] = (char)rnd.Next(48, 58);
                        }
                    }
                    break;

                case 's':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        temp = rnd.Next(0, 7);
                        if (temp == 0)
                        {
                            password[i] = (char)rnd.Next(65, 91);
                        }
                        else if (temp == 1)
                        {
                            password[i] = (char)rnd.Next(97, 123);
                        }
                        else if (temp == 2)
                        {
                            password[i] = (char)rnd.Next(48, 58);
                        }
                        else if (temp == 3)
                        {
                            password[i] = (char)rnd.Next(33, 48);
                        }
                        else if (temp == 4)
                        {
                            password[i] = (char)rnd.Next(58, 64);
                        }
                        else if (temp == 5)
                        {
                            password[i] = (char)rnd.Next(91, 97);
                        }
                        else if (temp == 6)
                        {
                            password[i] = (char)rnd.Next(123, 127);
                        }
                    }
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Type not valid");
                    goto inizio;
            }
            //Prints the password
            for (int i = 0; i < lung_passw; i++)
            {
                Console.Write($"{password[i]}");
            }

            Console.ReadKey();
        }
    }
}
