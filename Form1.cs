using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        double a = 0.0, b = 0.0, x = 0.0, f = 0.0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                x = Convert.ToDouble(textBox3.Text);
                f = 3 * Math.Pow(Math.Pow(x, 2), 1 / 3) + Math.Abs(2 * x) * (5 * Math.Pow(x, 4) - 2 * a * b) / (Math.Pow(Math.Tan(Math.Pow(x, -2)), 2));
                
            }
            catch (DivideByZeroException E)
            {
                MessageBox.Show("Деление на 0");
            }
            catch (FormatException E)
            {
                MessageBox.Show("Ошибка ввода(поменяйте . на ,)");
            }
            finally
            {
                textBox4.Text = Convert.ToString(Math.Round(f,3));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
