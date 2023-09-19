namespace c_sharp_lab4_ff
{
    partial class SettlementForm
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
            this.EmployerBox = new System.Windows.Forms.ComboBox();
            this.AspiranteBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommissionUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dolzhBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CommissionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работодатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Соискатель";
            // 
            // EmployerBox
            // 
            this.EmployerBox.FormattingEnabled = true;
            this.EmployerBox.Location = new System.Drawing.Point(209, 55);
            this.EmployerBox.Name = "EmployerBox";
            this.EmployerBox.Size = new System.Drawing.Size(121, 23);
            this.EmployerBox.TabIndex = 2;
            this.EmployerBox.SelectedIndexChanged += new System.EventHandler(this.EmployerBox_SelectedIndexChanged);
            // 
            // AspiranteBox
            // 
            this.AspiranteBox.FormattingEnabled = true;
            this.AspiranteBox.Location = new System.Drawing.Point(209, 99);
            this.AspiranteBox.Name = "AspiranteBox";
            this.AspiranteBox.Size = new System.Drawing.Size(121, 23);
            this.AspiranteBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Комиссионные";
            // 
            // CommissionUpDown
            // 
            this.CommissionUpDown.Location = new System.Drawing.Point(209, 182);
            this.CommissionUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CommissionUpDown.Name = "CommissionUpDown";
            this.CommissionUpDown.Size = new System.Drawing.Size(120, 23);
            this.CommissionUpDown.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Location = new System.Drawing.Point(12, 266);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(437, 31);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dolzhBox
            // 
            this.dolzhBox.Location = new System.Drawing.Point(209, 143);
            this.dolzhBox.Name = "dolzhBox";
            this.dolzhBox.Size = new System.Drawing.Size(121, 23);
            this.dolzhBox.TabIndex = 11;
            // 
            // SettlementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 330);
            this.Controls.Add(this.dolzhBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CommissionUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AspiranteBox);
            this.Controls.Add(this.EmployerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettlementForm";
            this.Text = "SettlementForm";
            this.Load += new System.EventHandler(this.SettlementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommissionUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox EmployerBox;
        private ComboBox AspiranteBox;
        private Label label3;
        private Label label4;
        private NumericUpDown CommissionUpDown;
        private Button SaveBtn;
        private TextBox dolzhBox;
    }
}