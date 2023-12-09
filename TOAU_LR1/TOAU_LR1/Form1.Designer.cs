namespace TOAU_LR1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericComponents = new System.Windows.Forms.NumericUpDown();
            this.numericProducts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.price_delta = new System.Windows.Forms.TextBox();
            this.value_delta = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите количество видов продукции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите количество компонентов, используемых при производстве:";
            // 
            // numericComponents
            // 
            this.numericComponents.Location = new System.Drawing.Point(379, 30);
            this.numericComponents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericComponents.Name = "numericComponents";
            this.numericComponents.Size = new System.Drawing.Size(48, 20);
            this.numericComponents.TabIndex = 3;
            this.numericComponents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericComponents.ValueChanged += new System.EventHandler(this.numericComponents_ValueChanged);
            // 
            // numericProducts
            // 
            this.numericProducts.Location = new System.Drawing.Point(223, 7);
            this.numericProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericProducts.Name = "numericProducts";
            this.numericProducts.Size = new System.Drawing.Size(48, 20);
            this.numericProducts.TabIndex = 4;
            this.numericProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericProducts.ValueChanged += new System.EventHandler(this.numericProducts_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ресурсы при производстве:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальный объем продаж в единицу времени на виды производимой продукции:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 273);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(806, 48);
            this.dataGridView2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Оптовые цены за единицу продаваемой продукции:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 353);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(806, 48);
            this.dataGridView3.TabIndex = 9;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 433);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(806, 48);
            this.dataGridView4.TabIndex = 10;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(40, 496);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(10, 19);
            this.dataGridView5.TabIndex = 11;
            this.dataGridView5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Текущая себестоимость производства единицы продукции:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(40, 521);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(15, 20);
            this.money.TabIndex = 19;
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.money.Visible = false;
            // 
            // price_delta
            // 
            this.price_delta.Location = new System.Drawing.Point(23, 495);
            this.price_delta.Name = "price_delta";
            this.price_delta.Size = new System.Drawing.Size(10, 20);
            this.price_delta.TabIndex = 20;
            this.price_delta.Text = "0";
            this.price_delta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price_delta.Visible = false;
            // 
            // value_delta
            // 
            this.value_delta.Location = new System.Drawing.Point(23, 521);
            this.value_delta.Name = "value_delta";
            this.value_delta.Size = new System.Drawing.Size(10, 20);
            this.value_delta.TabIndex = 21;
            this.value_delta.Text = "0";
            this.value_delta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.value_delta.Visible = false;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(669, 496);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(149, 32);
            this.buttonCalc.TabIndex = 22;
            this.buttonCalc.Text = "Вычислить";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(830, 542);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.value_delta);
            this.Controls.Add(this.price_delta);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericProducts);
            this.Controls.Add(this.numericComponents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Program";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericComponents;
        private System.Windows.Forms.NumericUpDown numericProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox price_delta;
        private System.Windows.Forms.TextBox value_delta;
        private System.Windows.Forms.Button buttonCalc;
    }
}

