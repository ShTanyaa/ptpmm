using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var5
{
    public partial class Form1 : Form
    {
        Car c1 = new Car();
        public Form1()
        {
            InitializeComponent();
        }
        class Car
        {
            public double v;
            public double kol_benz;
            public double rashod_benz;
            public double probeg;
            public double all_benz;


            public string GetInfo()
            {
                return ($"объем бака: {v}\nкол-во бензина в баке: {kol_benz}\nрасход бензина на 100км: {rashod_benz}\nпробег: {probeg}");
            }
            public double V
            {
                get { return v; }
                set { v = value; }
            }

            public double Kol_benz
            {
                get { return kol_benz; }
                set { kol_benz = value; }
            }

            public double Rashod_benz
            {
                get { return rashod_benz; }
                set { rashod_benz = value; }
            }

            public double Probeg
            {
                get { return probeg; }
                set { probeg = value; }
            }
            public string Zapravka()
            {
                kol_benz =kol_benz+all_benz;
                if (kol_benz==v)
                {
                    return ("0");
                }
                else if(kol_benz>v)
                {
                    return ($"остаток бензина-{v - kol_benz}");
                }
                else
                {
                    return ("error");
                }


            }
            public string nadoli_benz()
            {
                double ost = v * 0.1;
                if(kol_benz>ost)
                {
                    return ("можно ехать дальше");
                }
                else
                {
                    return ("нужна заправка бензина");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c1.all_benz= (int)numericUpDown5.Value;
            c1.v = (int)numericUpDown1.Value;
            c1.kol_benz = (int)numericUpDown2.Value;
            c1.rashod_benz = (int)numericUpDown3.Value;
            c1.probeg = (int)numericUpDown4.Value;
            MessageBox.Show(String.Format(c1.GetInfo()), "info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(c1.Zapravka()), "zapravka");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(c1.nadoli_benz()), "check");
        }
    }
}

