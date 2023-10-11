namespace WinFormsControlLibraryOffers
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelEmployer = new System.Windows.Forms.Label();
            this.LablerPost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAspirante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEmployer = new System.Windows.Forms.TextBox();
            this.AspiranteTextBox = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.TextBoxComission = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelEmployer
            // 
            this.LabelEmployer.AutoSize = true;
            this.LabelEmployer.Location = new System.Drawing.Point(28, 35);
            this.LabelEmployer.Name = "LabelEmployer";
            this.LabelEmployer.Size = new System.Drawing.Size(85, 15);
            this.LabelEmployer.TabIndex = 0;
            this.LabelEmployer.Text = "Работодатель:";
            this.LabelEmployer.Click += new System.EventHandler(this.label1_Click);
            // 
            // LablerPost
            // 
            this.LablerPost.AutoSize = true;
            this.LablerPost.Location = new System.Drawing.Point(41, 80);
            this.LablerPost.Name = "LablerPost";
            this.LablerPost.Size = new System.Drawing.Size(72, 15);
            this.LablerPost.TabIndex = 1;
            this.LablerPost.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Комиссионные:";
            // 
            // labelAspirante
            // 
            this.labelAspirante.AutoSize = true;
            this.labelAspirante.Location = new System.Drawing.Point(310, 34);
            this.labelAspirante.Name = "labelAspirante";
            this.labelAspirante.Size = new System.Drawing.Size(71, 15);
            this.labelAspirante.TabIndex = 3;
            this.labelAspirante.Text = "Соискатель";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(531, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "DEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmployer
            // 
            this.textBoxEmployer.Location = new System.Drawing.Point(119, 27);
            this.textBoxEmployer.Name = "textBoxEmployer";
            this.textBoxEmployer.Size = new System.Drawing.Size(171, 23);
            this.textBoxEmployer.TabIndex = 5;
            this.textBoxEmployer.TextChanged += new System.EventHandler(this.textBoxEmployer_TextChanged);
            // 
            // AspiranteTextBox
            // 
            this.AspiranteTextBox.Location = new System.Drawing.Point(387, 27);
            this.AspiranteTextBox.Name = "AspiranteTextBox";
            this.AspiranteTextBox.Size = new System.Drawing.Size(201, 23);
            this.AspiranteTextBox.TabIndex = 6;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(119, 72);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(469, 23);
            this.textBoxPost.TabIndex = 7;
            // 
            // TextBoxComission
            // 
            this.TextBoxComission.Location = new System.Drawing.Point(119, 119);
            this.TextBoxComission.Name = "TextBoxComission";
            this.TextBoxComission.Size = new System.Drawing.Size(406, 23);
            this.TextBoxComission.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxComission);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.AspiranteTextBox);
            this.Controls.Add(this.textBoxEmployer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAspirante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LablerPost);
            this.Controls.Add(this.LabelEmployer);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(603, 166);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelEmployer;
        private Label LablerPost;
        private Label label3;
        private Label labelAspirante;
        private Button button1;
        private TextBox textBoxEmployer;
        private TextBox AspiranteTextBox;
        private TextBox textBoxPost;
        private TextBox TextBoxComission;
    }
}