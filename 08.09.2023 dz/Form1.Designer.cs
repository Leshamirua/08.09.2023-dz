namespace _08._09._2023_dz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_eql = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_divide2 = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_double = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_coma = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button_eql);
            this.panel1.Controls.Add(this.button_plus);
            this.panel1.Controls.Add(this.button_divide2);
            this.panel1.Controls.Add(this.button_change);
            this.panel1.Controls.Add(this.button_root);
            this.panel1.Controls.Add(this.button_double);
            this.panel1.Controls.Add(this.button_divide);
            this.panel1.Controls.Add(this.button_mult);
            this.panel1.Controls.Add(this.button_minus);
            this.panel1.Controls.Add(this.button_coma);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_CE);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 310);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(15, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 40);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_eql
            // 
            this.button_eql.Location = new System.Drawing.Point(199, 204);
            this.button_eql.Name = "button_eql";
            this.button_eql.Size = new System.Drawing.Size(40, 86);
            this.button_eql.TabIndex = 23;
            this.button_eql.Text = "=";
            this.button_eql.UseVisualStyleBackColor = true;
            this.button_eql.Click += new System.EventHandler(this.button_eql_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(153, 250);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(40, 40);
            this.button_plus.TabIndex = 22;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_divide2
            // 
            this.button_divide2.Location = new System.Drawing.Point(199, 66);
            this.button_divide2.Name = "button_divide2";
            this.button_divide2.Size = new System.Drawing.Size(40, 40);
            this.button_divide2.TabIndex = 21;
            this.button_divide2.Text = "%";
            this.button_divide2.UseVisualStyleBackColor = true;
            this.button_divide2.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(154, 66);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(40, 40);
            this.button_change.TabIndex = 20;
            this.button_change.Text = "+/-";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_root
            // 
            this.button_root.Location = new System.Drawing.Point(199, 158);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(40, 40);
            this.button_root.TabIndex = 19;
            this.button_root.Text = "√";
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.button_root_Click);
            // 
            // button_double
            // 
            this.button_double.Location = new System.Drawing.Point(199, 112);
            this.button_double.Name = "button_double";
            this.button_double.Size = new System.Drawing.Size(40, 40);
            this.button_double.TabIndex = 18;
            this.button_double.Text = "x²";
            this.button_double.UseVisualStyleBackColor = true;
            this.button_double.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(153, 112);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(40, 40);
            this.button_divide.TabIndex = 17;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_mult
            // 
            this.button_mult.Location = new System.Drawing.Point(153, 158);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(40, 40);
            this.button_mult.TabIndex = 16;
            this.button_mult.Text = "х";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(153, 204);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(40, 40);
            this.button_minus.TabIndex = 15;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_coma
            // 
            this.button_coma.Location = new System.Drawing.Point(107, 250);
            this.button_coma.Name = "button_coma";
            this.button_coma.Size = new System.Drawing.Size(40, 40);
            this.button_coma.TabIndex = 14;
            this.button_coma.Text = ",";
            this.button_coma.UseVisualStyleBackColor = true;
            this.button_coma.Click += new System.EventHandler(this.button_coma_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(106, 66);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(40, 40);
            this.button_C.TabIndex = 2;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(15, 250);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(86, 40);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(60, 66);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(40, 40);
            this.button_CE.TabIndex = 11;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(14, 66);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(40, 40);
            this.button_back.TabIndex = 10;
            this.button_back.Text = "<==";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(14, 204);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(40, 40);
            this.button_7.TabIndex = 9;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(60, 204);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(40, 40);
            this.button_8.TabIndex = 8;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(107, 112);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(40, 40);
            this.button_3.TabIndex = 7;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(106, 204);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(40, 40);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(61, 112);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(40, 40);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(106, 158);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(40, 40);
            this.button_6.TabIndex = 4;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(15, 112);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(40, 40);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(60, 158);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(40, 40);
            this.button_5.TabIndex = 24;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(14, 158);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(40, 40);
            this.button_4.TabIndex = 13;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 310);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_eql;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_divide2;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_double;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_coma;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
    }
}

