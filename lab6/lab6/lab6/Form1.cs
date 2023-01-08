using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        private object equations;

        public Form1()
        {
            InitializeComponent();
        }

        internal class SeriesCreator
        {
            static public void Get(Series series, Equation equation, double x1, double x2, int quality = 100)
            {
                double Points;
                series.ChartType = SeriesChartType.Line;
                double h = (x2 - x1) / quality;
                for (int i = 0; i < quality; i++)
                {
                    Points = x1 + i * h;
                    series.Points.AddXY(Points, equation.GetValue(Points));
                }
                
            }
        }
        void DrawFunction(double x1, double x2, Equation equation, int N = 100)
        {

            SeriesCreator.Get(chart1.Series[0], equation, x1, x2, N);
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equation equations;

            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение A!");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение B!");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение C!");
                return;
            }
            equations = new QuadEquation(a: Convert.ToInt32(textBox3.Text), b: Convert.ToInt32(textBox4.Text), c: Convert.ToInt32(textBox5.Text));
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Equation equations;

            if (textBox6.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение a!"); 
            }
            else
            {
                equations = new SinEquation(a: Convert.ToInt32(textBox6.Text));
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Версия приложения:\nv.1.0.0",
        "О приложении",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение A!");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение B!");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение C!");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Введите левую границу рисования графика!");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Введите правую границу рисования графика!");
                return;
            }




            equations = new QuadEquation(a: Convert.ToInt32(textBox3.Text), b: Convert.ToInt32(textBox4.Text), c: Convert.ToInt32(textBox5.Text));
            DrawFunction(x1: Convert.ToInt32(textBox8.Text), x2: Convert.ToInt32(textBox9.Text), (Equation)equations, N: Convert.ToInt32(textBox7.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение a!");
            }
            else
            {
                equations = new SinEquation(a: Convert.ToInt32(textBox6.Text));
                DrawFunction(x1: Convert.ToInt32(textBox8.Text), x2: Convert.ToInt32(textBox9.Text), (Equation)equations, N: Convert.ToInt32(textBox7.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение A!");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение B!");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение C!");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Введите левую границу рисования графика!");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Введите правую границу рисования графика!");
                return;
            }
            equations = new QuadEquation(a: Convert.ToInt32(textBox3.Text), b: Convert.ToInt32(textBox4.Text), c: Convert.ToInt32(textBox5.Text));
            IntegratorRectangle rect = new IntegratorRectangle();
            MessageBox.Show($"{rect.ToString()} {rect.Integrate((Equation)equations, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox7.Text))}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение A!");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение B!");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение C!");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Введите левую границу рисования графика!");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Введите правую границу рисования графика!");
                return;
            }
            equations = new QuadEquation(a: Convert.ToInt32(textBox3.Text), b: Convert.ToInt32(textBox4.Text), c: Convert.ToInt32(textBox5.Text));
            IntegratorTrapezoid Trapz = new IntegratorTrapezoid();
            MessageBox.Show($"{Trapz.ToString()} {Trapz.Integrate((Equation)equations, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox7.Text))}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение a!");
            }

            equations = new SinEquation(a: Convert.ToInt32(textBox6.Text));
            IntegratorTrapezoid Trapz = new IntegratorTrapezoid();
            MessageBox.Show($"{Trapz.ToString()} {Trapz.Integrate((Equation)equations, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox7.Text))}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите разбиение!");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение a!");
            }

            equations = new SinEquation(a: Convert.ToInt32(textBox6.Text));
            IntegratorRectangle rect = new IntegratorRectangle();
            MessageBox.Show($"{rect.ToString()} {rect.Integrate((Equation)equations, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox7.Text))}");
        }
    }
    
}
