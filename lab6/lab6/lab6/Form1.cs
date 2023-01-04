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
     
        public Form1()
        {
            InitializeComponent();
        }

        internal class SeriesCreator //Создаёт множество точек, которые формируют график
        {
            static public Series Get(Equation equation, double x1, double x2, int quality = 100)
            {
                double CurPoint;
                Series Value = new Series();
                Value.ChartType = SeriesChartType.Line;
                double h = (x2 - x1) / quality;
                for (int i = 0; i < quality; i++)
                {
                    CurPoint = x1 + i * h;
                    Value.Points.AddXY(CurPoint, equation.GetValue(CurPoint));
                }
                return Value;
            }
        }
        void DrawFunction(double x1, double x2, Series series, Equation equation)
        {
            int N = 100;
            chart1.Series.Add(SeriesCreator.Get(equation, x1, x2, N));
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
                MessageBox.Show("Вы не выбрали значение A");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение B");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Вы не выбрали значение C");
                return;
            }
            equations = new QuadEquation(a: Convert.ToInt32(textBox3.Text), b: Convert.ToInt32(textBox4.Text), c: Convert.ToInt32(textBox5.Text));
        }
    }
}
