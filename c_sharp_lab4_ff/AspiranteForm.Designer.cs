namespace c_sharp_lab4_ff
{
    partial class AspiranteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.Qualification_box = new System.Windows.Forms.TextBox();
            this.activityBox = new System.Windows.Forms.TextBox();
            this.OthereData_Box = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pay)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.Location = new System.Drawing.Point(129, 36);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(100, 23);
            this.SecondNameBox.TabIndex = 0;
            this.SecondNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(129, 78);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(129, 127);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 23);
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Qualification_box
            // 
            this.Qualification_box.Location = new System.Drawing.Point(129, 177);
            this.Qualification_box.Name = "Qualification_box";
            this.Qualification_box.Size = new System.Drawing.Size(100, 23);
            this.Qualification_box.TabIndex = 3;
            this.Qualification_box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // activityBox
            // 
            this.activityBox.Location = new System.Drawing.Point(129, 231);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(100, 23);
            this.activityBox.TabIndex = 4;
            this.activityBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // OthereData_Box
            // 
            this.OthereData_Box.Location = new System.Drawing.Point(129, 281);
            this.OthereData_Box.Name = "OthereData_Box";
            this.OthereData_Box.Size = new System.Drawing.Size(100, 23);
            this.OthereData_Box.TabIndex = 5;
            this.OthereData_Box.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(129, 331);
            this.pay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(120, 23);
            this.pay.TabIndex = 6;
            this.pay.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Квалификация:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вид деятельности:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Иные данные:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "ЗП:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AspiranteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.OthereData_Box);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.Qualification_box);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SecondNameBox);
            this.Name = "AspiranteForm";
            this.Text = "Aspirante";
            this.Load += new System.EventHandler(this.AspiranteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SecondNameBox;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox Qualification_box;
        private TextBox activityBox;
        private TextBox OthereData_Box;
        private NumericUpDown pay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}