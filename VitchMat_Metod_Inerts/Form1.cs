using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace VitchMat_Metod_Inerts
{
    public partial class Form1 : DarkForm
    {
        double yr1(double x) //ур 1
        {
            return (x * x * x) + 8 * x + 13;
        }
        double yr2(double x) //ур 2
        {
            return 3 * x + Math.Cos(x) + 1;
        }
        double yr_1(double x) 
        {
            return -13 / ((x * x + 8));
        }
        double yr_2(double x)
        {
            return (-1 - Math.Cos(x)) / 3;
        }
   
        public Form1()
        {
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (darkTextBox1.Text == "")
            {
                MessageBox.Show("Пустое поле!");
            }
            else
            {
                double x = 0, X, E = Convert.ToDouble("0," + darkTextBox1.Text);
                int h = 1, n = 1;
                for (int i = -10; i <= 10; i += h)
                {
                    if (yr1(i) * yr1(i + h) < 0)
                    {
                        t_ab.Text = Convert.ToString(i) + " ; " + Convert.ToString(i + h);
                        x = (i + i + h) / 2;
                        break;
                    }
                }
                X = yr_1(x);
                while (Math.Abs(x - X) > E)
                {
                    x = X;
                    X = yr_1(x);
                    n++;
                }
                t_n.Text = Convert.ToString(n);
                t_x.Text = Convert.ToString(x);
                n = 1;
                for (int i = -10; i <= 10; i += h)
                {
                    if (yr2(i) * yr2(i + h) < 0)
                    {
                        t_ab2.Text = Convert.ToString(i) + " ; " + Convert.ToString(i + h);
                        x = (i + i + h) / 2;
                        break;
                    }
                }
                X = yr_2(x);
                while (Math.Abs(x - X) > E)
                {
                    x = X;
                    X = yr_2(x);
                    n++;
                }
                t_n2.Text = Convert.ToString(n);
                t_x2.Text = Convert.ToString(x);
            }

            
        }

        private void darkTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace в а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
