using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOAU_LR1
{
    public partial class FormResult : Form
    {
        double[,] simplex;
        double[] result;
        int m, n;

        public FormResult(double [,] simplex, int m, int n, double[] result)
        {
            InitializeComponent();

            this.simplex = simplex;
            this.m = m;
            this.n = n;
            this.result = result;

            listView1.Columns.Clear();
            listBox1.Items.Clear();
            OutputResult();
        }

        private void OutputResult()
        {
            listView1.Columns.Add("", "B");
            for (int j = 1; j < n; j++)
                listView1.Columns.Add("", "X" + j.ToString());
            for (int i = 0; i < m; i++)
            {
                string[] items = new string[n];
                for (int j = 0; j < n; j++)
                    items[j] = simplex[i, j].ToString();
                ListViewItem list = new ListViewItem(items);
                listView1.Items.Add(list);
            }

            for (int j = 0; j < n - 1; j++)
            {
                string s = "X[" + (j + 1) + "] = " + result[j];
                listBox1.Items.Add(s);
            }

            double money = 0;
            for (int j = 1; j < n; j++)
                money += -1 * simplex[m - 1, j] * result[j - 1];

            profit.Text = money.ToString();
        }
    }
}
