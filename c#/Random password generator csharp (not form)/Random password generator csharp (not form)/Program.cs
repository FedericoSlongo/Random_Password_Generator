using System;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Random_password_generator_csharp__not_form_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char type = ' ';
            string userName = Environment.UserName, path = $@"C:\Users\{userName}\AppData\Roaming\fs_psw_gen", passw = "", temp_s = "";
            int lung_passw = 0, temp = 0;

            inizio:

            Console.Write("How long do you want the password to be ");
            lung_passw = Convert.ToInt32(Console.ReadLine());

            Console.Write("You want only [c]haracters, [n]umber e characters, [s]ymbols numbers and characters ");
            type = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            passw = pasw_gen(in type, in lung_passw);
            if (passw == "i")
                goto inizio;


            //Saves the password
            if (!Directory.Exists(path))
            {
                Console.WriteLine($@"The passwords generated are saved in C:\Users\{userName}\AppData\Roaming\fs_psw_gen\psw.txt");
                //Creating the directory
                Directory.CreateDirectory(path);
                //Creating the file
                using (StreamWriter writer = File.CreateText($@"{path}\psw.txt"))
                {
                    //Saving the password
                    writer.WriteLine(passw);
                }

            } else if (!File.Exists($@"{path}\psw.txt")) {
                //Creating the file
                using (StreamWriter writer = File.CreateText($@"{path}\psw.txt"))
                    writer.WriteLine(passw); //Saving the password
            } else {
                File.Copy($@"{path}\psw.txt", $@"{path}\psw_temp.txt");
                StreamWriter sw = new StreamWriter($@"{path}\psw.txt");
                StreamReader sr = new StreamReader($@"{path}\psw_temp.txt");

                //Saving the password to the file
                temp_s = sr.ReadLine();
                while (temp_s != null)
                {
                    sw.WriteLine(temp_s);
                    temp++;
                    temp_s = sr.ReadLine();
                }
                sw.WriteLine(passw);
                sw.Close();
                sr.Close();
                File.Delete($@"{path}\psw_temp.txt");
            }

            //Prints the password
            Console.Write(passw);

            Console.ReadKey();
        }

        static string pasw_gen(in char type, in int lung_passw)
        {
            Random rnd = new Random();
            string passw = "";
            int temp = 0;
            switch (type)
            {
                case 'c':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            passw += (char)rnd.Next(65, 91);
                        }
                        else
                        {
                            passw += (char)rnd.Next(97, 123);
                        }
                    }
                    break;

                case 'n':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        temp = rnd.Next(0, 3);
                        if (temp == 0)
                        {
                            passw += (char)rnd.Next(65, 91);
                        }
                        else if (temp == 1)
                        {
                            passw += (char)rnd.Next(97, 123);
                        }
                        else
                        {
                            passw += (char)rnd.Next(48, 58);
                        }
                    }
                    break;

                case 's':
                    for (int i = 0; i < lung_passw; i++)
                    {
                        temp = rnd.Next(0, 7);
                        if (temp == 0)
                        {
                            passw += (char)rnd.Next(65, 91);
                        }
                        else if (temp == 1)
                        {
                            passw += (char)rnd.Next(97, 123);
                        }
                        else if (temp == 2)
                        {
                            passw += (char)rnd.Next(48, 58);
                        }
                        else if (temp == 3)
                        {
                            passw += (char)rnd.Next(33, 48);
                        }
                        else if (temp == 4)
                        {
                            passw += (char)rnd.Next(58, 64);
                        }
                        else if (temp == 5)
                        {
                            passw += (char)rnd.Next(91, 97);
                        }
                        else if (temp == 6)
                        {
                            passw += (char)rnd.Next(123, 127);
                        }
                    }
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Type not valid");
                    return "i";
            }

            return passw;
        }
    }
}
