using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Hotel_lab4_
{
    public partial class Form5 : Form
    {
        string firstName, lastName;
        double price, cost;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            lastName = textBox1.Text;
            firstName = textBox3.Text;
            price = Firms.store(lastName, firstName);
            if (price == -1) textBox2.Text = "Клиент не найден";
            else textBox2.Text = price.ToString();
        }
    }
}
