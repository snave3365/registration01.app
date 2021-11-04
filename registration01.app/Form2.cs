using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration01.app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Логін_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = texBox2.Text;

            if (login.Length < 5) {

                textBox1.ToolTip = "Не коректно";
            } else if (password.Lenght < 5) {
                textBox2.ToolTip = "Не коректно";
            }
            else { textBox1.ToolTip = "";
                textBox2.ToolTip = "";
                MassageBox.Show("Вітаю");
            }



        }
else
{
    textBoxLogin.ToolTip = "";
    MessageBox.Show("Вітаємо")


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
