using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_lab4_
{
    public partial class Form4 : Form
    {
        int index = -1;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

            try
            {
                Firms.showTariffs(dataGridView1, 0);
                {

                    double balans = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        double incom;
                        double.TryParse((row.Cells[1].Value ?? "0").ToString().Replace(".", ","), out incom);
                        balans += incom;
                    }
                    textBox1.Text = balans.ToString();
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Тарифов нет";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
