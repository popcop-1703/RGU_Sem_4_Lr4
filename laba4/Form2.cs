using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_lab4_
{
    public partial class Form2 : Form
    {
        string num;
        double price;
        tariff room;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
            {

                try
            {
                num = textBox1.Text;
                price = double.Parse(textBox2.Text);
                if(price >= 0)
                {
                    room = new tariff(num, price);
                    if (Firms.addTariff(room)) {
                        label3.Text = "товар добавлен";
                    } 
                    else label3.Text = "товар уже существует";
                }
                else label3.Text = "Стоимость должна быть положительным числом";

            }
            catch (Exception ex)
            {
                label3.Text = "Ошибка";
            }
                
            }
            else
            {
               MessageBox.Show("Укажите стоимость товара");
            }
            }
            else
            {
                MessageBox.Show("Укажите наименование товара");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != ',')
            {
                e.Handled = true;
            }
        }
    }
}
