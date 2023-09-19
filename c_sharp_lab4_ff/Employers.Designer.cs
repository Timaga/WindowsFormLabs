namespace c_sharp_lab4_ff
{
    partial class Employers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.activityBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адресс:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер  телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид деятельности:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(167, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 4;
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(167, 69);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(100, 23);
            this.adressBox.TabIndex = 5;
            // 
            // activityBox
            // 
            this.activityBox.Location = new System.Drawing.Point(167, 149);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(100, 23);
            this.activityBox.TabIndex = 7;
            // 
            // save_button
            // 
            this.save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_button.Location = new System.Drawing.Point(167, 198);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 27);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(167, 116);
            this.PhoneBox.Mask = "(999) 000-0000";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 23);
            this.PhoneBox.TabIndex = 9;
            // 
            // Employers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 245);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employers";
            this.Text = "Заказчик";
            this.Load += new System.EventHandler(this.Employers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameBox;
        private TextBox adressBox;
        private TextBox activityBox;
        private Button save_button;
        private MaskedTextBox PhoneBox;
    }
}