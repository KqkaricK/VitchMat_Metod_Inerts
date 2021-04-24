
namespace VitchMat_Metod_Inerts
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
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.t_ab = new DarkUI.Controls.DarkLabel();
            this.t_x = new DarkUI.Controls.DarkLabel();
            this.t_n = new DarkUI.Controls.DarkLabel();
            this.t_n2 = new DarkUI.Controls.DarkLabel();
            this.t_x2 = new DarkUI.Controls.DarkLabel();
            this.t_ab2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.darkLabel11 = new DarkUI.Controls.DarkLabel();
            this.darkLabel12 = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(35, 272);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(118, 23);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "Поехали";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(191, 27);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(100, 20);
            this.darkTextBox1.TabIndex = 1;
            this.darkTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.darkTextBox1_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(35, 29);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(130, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Введите погрешность е:";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(35, 55);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(89, 13);
            this.darkLabel2.TabIndex = 3;
            this.darkLabel2.Text = "x^3 + 8x + 13 = 0";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(35, 84);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(59, 13);
            this.darkLabel3.TabIndex = 4;
            this.darkLabel3.Text = "Интервал:";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(35, 108);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(91, 13);
            this.darkLabel4.TabIndex = 5;
            this.darkLabel4.Text = "Значение корня:";
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(35, 133);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(92, 13);
            this.darkLabel5.TabIndex = 6;
            this.darkLabel5.Text = "Число итераций:";
            // 
            // t_ab
            // 
            this.t_ab.AutoSize = true;
            this.t_ab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_ab.Location = new System.Drawing.Point(143, 84);
            this.t_ab.Name = "t_ab";
            this.t_ab.Size = new System.Drawing.Size(13, 13);
            this.t_ab.TabIndex = 7;
            this.t_ab.Text = "0";
            // 
            // t_x
            // 
            this.t_x.AutoSize = true;
            this.t_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_x.Location = new System.Drawing.Point(143, 108);
            this.t_x.Name = "t_x";
            this.t_x.Size = new System.Drawing.Size(13, 13);
            this.t_x.TabIndex = 8;
            this.t_x.Text = "0";
            // 
            // t_n
            // 
            this.t_n.AutoSize = true;
            this.t_n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_n.Location = new System.Drawing.Point(143, 133);
            this.t_n.Name = "t_n";
            this.t_n.Size = new System.Drawing.Size(13, 13);
            this.t_n.TabIndex = 9;
            this.t_n.Text = "0";
            // 
            // t_n2
            // 
            this.t_n2.AutoSize = true;
            this.t_n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_n2.Location = new System.Drawing.Point(140, 239);
            this.t_n2.Name = "t_n2";
            this.t_n2.Size = new System.Drawing.Size(13, 13);
            this.t_n2.TabIndex = 15;
            this.t_n2.Text = "0";
            // 
            // t_x2
            // 
            this.t_x2.AutoSize = true;
            this.t_x2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_x2.Location = new System.Drawing.Point(140, 214);
            this.t_x2.Name = "t_x2";
            this.t_x2.Size = new System.Drawing.Size(13, 13);
            this.t_x2.TabIndex = 14;
            this.t_x2.Text = "0";
            // 
            // t_ab2
            // 
            this.t_ab2.AutoSize = true;
            this.t_ab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_ab2.Location = new System.Drawing.Point(140, 190);
            this.t_ab2.Name = "t_ab2";
            this.t_ab2.Size = new System.Drawing.Size(13, 13);
            this.t_ab2.TabIndex = 13;
            this.t_ab2.Text = "0";
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(32, 239);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(92, 13);
            this.darkLabel9.TabIndex = 12;
            this.darkLabel9.Text = "Число итераций:";
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(32, 214);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(91, 13);
            this.darkLabel10.TabIndex = 11;
            this.darkLabel10.Text = "Значение корня:";
            // 
            // darkLabel11
            // 
            this.darkLabel11.AutoSize = true;
            this.darkLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel11.Location = new System.Drawing.Point(32, 190);
            this.darkLabel11.Name = "darkLabel11";
            this.darkLabel11.Size = new System.Drawing.Size(59, 13);
            this.darkLabel11.TabIndex = 10;
            this.darkLabel11.Text = "Интервал:";
            // 
            // darkLabel12
            // 
            this.darkLabel12.AutoSize = true;
            this.darkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel12.Location = new System.Drawing.Point(35, 161);
            this.darkLabel12.Name = "darkLabel12";
            this.darkLabel12.Size = new System.Drawing.Size(97, 13);
            this.darkLabel12.TabIndex = 16;
            this.darkLabel12.Text = "3x + cos (x) + 1 = 0";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(175, 29);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(16, 13);
            this.darkLabel6.TabIndex = 17;
            this.darkLabel6.Text = "0,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 339);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.darkLabel12);
            this.Controls.Add(this.t_n2);
            this.Controls.Add(this.t_x2);
            this.Controls.Add(this.t_ab2);
            this.Controls.Add(this.darkLabel9);
            this.Controls.Add(this.darkLabel10);
            this.Controls.Add(this.darkLabel11);
            this.Controls.Add(this.t_n);
            this.Controls.Add(this.t_x);
            this.Controls.Add(this.t_ab);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkButton1);
            this.Name = "Form1";
            this.Text = "Метод Итераций";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel t_ab;
        private DarkUI.Controls.DarkLabel t_x;
        private DarkUI.Controls.DarkLabel t_n;
        private DarkUI.Controls.DarkLabel t_n2;
        private DarkUI.Controls.DarkLabel t_x2;
        private DarkUI.Controls.DarkLabel t_ab2;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private DarkUI.Controls.DarkLabel darkLabel11;
        private DarkUI.Controls.DarkLabel darkLabel12;
        private DarkUI.Controls.DarkLabel darkLabel6;
    }
}

