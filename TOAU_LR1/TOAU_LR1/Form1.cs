using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TOAU_LR1
{
    public partial class Form1 : Form
    {
        double[,] simplex;
        double[] result;

        List<int> BKK;

        public Form1()
        {
            InitializeComponent();

            BKK = new List<int>();

            updateDataGridView();
        }

        private void numericProducts_ValueChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void numericComponents_ValueChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {            
            fillEmptyCellsByZero();

            BKK.Clear();

            int m = dataGridView1.RowCount + dataGridView2.ColumnCount + 2;
            int n = dataGridView1.ColumnCount;
            simplex = new double[m, n];

            int i, j;
            //1
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                simplex[i, 0] = Convert.ToDouble(dataGridView1[n - 1, i].Value);

                for (j = 1; j < n; j++)
                    simplex[i, j] = Convert.ToDouble(dataGridView1[j - 1, i].Value);
            }
            //2
            for (int k = 1; k < dataGridView2.ColumnCount + 1; k++)
            {
                simplex[i, 0] = Convert.ToDouble(dataGridView2[k - 1, 0].Value);
                for (j = 1; j < n; j++)
                    if (k == j)
                        simplex[i, j] = 1;
                    else
                        simplex[i, j] = 0;
                i++;
            }
            //5 4
            simplex[i, 0] = Convert.ToDouble(money.Text);
            for (j = 1; j < n; j++)
            {
                if (Convert.ToDouble(dataGridView5[j - 1, 0].Value) == 0)
                    simplex[i, j] = 0;
                else
                {
                    simplex[i, j] = Convert.ToDouble(dataGridView5[j - 1, 0].Value) - Convert.ToDouble(dataGridView4[j - 1, 0].Value);
                    BKK.Add(j);
                }
            }
            i++;
            //3 (она же целевая функция)
            simplex[i, 0] = 0;
            for (j = 1; j < n; j++)
                simplex[i, j] = -1 * Convert.ToDouble(dataGridView3[j - 1, 0].Value);
            //корректируем значения в % на ВКК
            foreach(int w in BKK)
            {
                //оптовые цены
                simplex[m - 1, w] += Convert.ToDouble(price_delta.Text) * simplex[m - 1, w] / 100.0;
                //максимальный объем продаж
                simplex[dataGridView1.RowCount - 1 + w, 0] += Convert.ToDouble(value_delta.Text) * simplex[dataGridView1.RowCount - 1 + w, 0] / 100.0;
            }


            ///////////////////////
            File.Delete("Result.html");
            FileInfo fOut = new FileInfo(@"Result.html");

            result = new double[n - 1];

            Simplex Sim = new Simplex(simplex);
            Sim.Calculate(result);

            FormResult FR = new FormResult(simplex, m, n, result);
            FR.ShowDialog();
        }

        private void updateDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Columns.Clear();
            dataGridView5.Columns.Clear();

            //1
            for (int j = 0; j < numericProducts.Value; j++)
                dataGridView1.Columns.Add("", "X" + (j + 1).ToString());
            dataGridView1.Columns.Add("", "Запасы");

            for (int i = 0; i < numericComponents.Value; i++)
                dataGridView1.Rows.Add();
            //2 3 4 5
            for (int j = 0; j < numericProducts.Value; j++)
            {
                dataGridView2.Columns.Add("", "v" + (j + 1).ToString());
                dataGridView3.Columns.Add("", "p" + (j + 1).ToString());
                dataGridView4.Columns.Add("", "s" + (j + 1).ToString());
                dataGridView5.Columns.Add("", "s(вк)" + (j + 1).ToString());
            }
            dataGridView2.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView4.Rows.Add();
            dataGridView5.Rows.Add();
        }

        private void fillEmptyCellsByZero()
        {
            //1
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1[j, i] == null)
                        dataGridView1[j, i].Value = 0;
            //2
            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                if (dataGridView2[j, 0] == null)
                    dataGridView2[j, 0].Value = 0;
            //3
            for (int j = 0; j < dataGridView3.ColumnCount; j++)
                if (dataGridView3[j, 0] == null)
                    dataGridView3[j, 0].Value = 0;
            //4
            for (int j = 0; j < dataGridView4.ColumnCount; j++)
                if (dataGridView4[j, 0] == null)
                    dataGridView4[j, 0].Value = 0;
            //5
            for (int j = 0; j < dataGridView5.ColumnCount; j++)
                if (dataGridView5[j, 0] == null)
                    dataGridView5[j, 0].Value = 0;
            //money
            if (money.Text == "")
                money.Text = "0";
        }



    }
}
