using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_password_generator_csharp__form_
{
    public partial class Form1 : Form
    {
        int psw_length = 0, temp = 0;
        char[] password;
        string passw_temp;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void lenght_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            //Checking if the password lenght box is empty
            if (lenght_box.Text == "" || lenght_box.Text == " ")
            {
                MessageBox.Show("You need to set the password lenght", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Converting the number
            psw_length = Convert.ToInt32(lenght_box.Text);

            //Setting the char lenght
            password = new char[psw_length];

            //Generating password
            if (c_but.Checked)
            {
                for (int i = 0; i < psw_length; i++)
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
            } else if (cn_but.Checked)
            {
                for (int i = 0; i < psw_length; i++)
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
            }
            else
            {
                for (int i = 0; i < psw_length; i++)
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
            }

            //Converting the char to a string
            passw_temp = new string(password);

            //Putting the password in the password text box
            password_box.Text = passw_temp;
        }
    }
}
