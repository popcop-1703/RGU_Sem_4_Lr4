using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_lab4_
{
    public partial class Form3 : Form
    {
        string name, lastname, number;
        double massa, cost;

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox3.Text != "")
                    {
                        if (textBox4.Text != "")
                        {
                            try
            {
                name = textBox1.Text;
                lastname = textBox2.Text;
                number = textBox3.Text;
                massa = double.Parse(textBox4.Text);
                                if (massa >= 0)
                                {
                                    label4.Text = Firms.addPerson(name, lastname, number, massa, cost);
                                }
                                else label4.Text = "количество задается положительным числом";
                            }
            catch(Exception ex) {
                label4.Text = "Ошибка. тариф некорректного формата";
            }
            }
            else
            {
                MessageBox.Show("Укажите количество товара");
            }
        }
            else
            {
               MessageBox.Show("Укажите товар");
            }
            }
            else
            {
                MessageBox.Show("Укажите фамилию");
            }
        }
            else
            {
                MessageBox.Show("Укажите имя");
            }

}
    }
}
