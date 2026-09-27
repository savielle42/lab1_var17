using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_var17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Створюємо об'єкт класу Tabul
            Tabul tabul = new Tabul();

            // Зчитуємо введені значення з текстових полів
            double xn = Convert.ToDouble(this.textBox1.Text);
            double xk = Convert.ToDouble(this.textBox2.Text);
            double h = Convert.ToDouble(this.textBox3.Text);
            double a = Convert.ToDouble(this.textBox4.Text);

            // Очищаємо попередні результати перед новим розрахунком
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            // Викликаємо метод табулювання
            tabul.tab(xn, xk, h, a);

            // Заповнюємо таблицю та будуємо графік
            for (int i = 0; i < tabul.n; i++)
            {
                // Додаємо рядок у DataGridView
                dataGridView1.Rows.Add(
                    Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString()
                );
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
