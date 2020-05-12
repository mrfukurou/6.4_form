using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[][] Input()
        {
            int n = int.Parse(Nn.Text);
            int[][] a = new int[n][];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {

                    a[i][j] = rand.Next(-100, 200);

                }
            }
            return a;
        }

        public void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                newmas.Text+= a[i]+" ";
        }

        public void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                    Mass.Text += a[i][j] + " ";
                Mass.Text += Environment.NewLine;
            }
        }

        static int Mas(int[] a)
        {
            int mas = a[0];
            for (int i = 1; i < a.Length; ++i)
                mas += a[i];
            return mas;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[][] myArray = Input();
                Print2(myArray);
                int[] rez = new int[myArray.Length];
                for (int i = 0; i < myArray.Length; ++i)
                    rez[i] = Mas(myArray[i]);
                Print1(rez);
                int max = rez[0];
                for (int i = 0; i < myArray.Length; ++i)
                {
                    if (rez[i] > max) max = rez[i];
                }
                Rez.Text=Convert.ToString("Максимальное число в массиве: " + max);
            }
            catch { Rez.Text = Convert.ToString("Некорректный ввод!");
                Mass.Clear();
                newmas.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mass.Clear();
            newmas.Clear();
            Rez.Clear();
            Nn.Clear();
        }
    }
}
