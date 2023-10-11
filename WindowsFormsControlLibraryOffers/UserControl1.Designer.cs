namespace WindowsFormsControlLibraryOffers
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployerLable = new System.Windows.Forms.Label();
            this.AspiranteLable = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.ComissionLabel = new System.Windows.Forms.Label();
            this.textBoxEmployer = new System.Windows.Forms.TextBox();
            this.textBoxAspirante = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.Comissions = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployerLable
            // 
            this.EmployerLable.AutoSize = true;
            this.EmployerLable.Location = new System.Drawing.Point(33, 27);
            this.EmployerLable.Name = "EmployerLable";
            this.EmployerLable.Size = new System.Drawing.Size(81, 13);
            this.EmployerLable.TabIndex = 0;
            this.EmployerLable.Text = "Работодатель:";
            this.EmployerLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // AspiranteLable
            // 
            this.AspiranteLable.AutoSize = true;
            this.AspiranteLable.Location = new System.Drawing.Point(304, 27);
            this.AspiranteLable.Name = "AspiranteLable";
            this.AspiranteLable.Size = new System.Drawing.Size(70, 13);
            this.AspiranteLable.TabIndex = 1;
            this.AspiranteLable.Text = "Соискатель:";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Location = new System.Drawing.Point(46, 72);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(68, 13);
            this.PostLabel.TabIndex = 2;
            this.PostLabel.Text = "Должность:";
            this.PostLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ComissionLabel
            // 
            this.ComissionLabel.AutoSize = true;
            this.ComissionLabel.Location = new System.Drawing.Point(27, 108);
            this.ComissionLabel.Name = "ComissionLabel";
            this.ComissionLabel.Size = new System.Drawing.Size(87, 13);
            this.ComissionLabel.TabIndex = 3;
            this.ComissionLabel.Text = "Комиссионные:";
            // 
            // textBoxEmployer
            // 
            this.textBoxEmployer.Location = new System.Drawing.Point(120, 20);
            this.textBoxEmployer.Name = "textBoxEmployer";
            this.textBoxEmployer.Size = new System.Drawing.Size(177, 20);
            this.textBoxEmployer.TabIndex = 4;
            this.textBoxEmployer.TextChanged += new System.EventHandler(this.textBoxEmployer_TextChanged);
            // 
            // textBoxAspirante
            // 
            this.textBoxAspirante.Location = new System.Drawing.Point(393, 20);
            this.textBoxAspirante.Name = "textBoxAspirante";
            this.textBoxAspirante.Size = new System.Drawing.Size(204, 20);
            this.textBoxAspirante.TabIndex = 5;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(120, 69);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(477, 20);
            this.textBoxPost.TabIndex = 6;
            // 
            // Comissions
            // 
            this.Comissions.Location = new System.Drawing.Point(120, 101);
            this.Comissions.Name = "Comissions";
            this.Comissions.Size = new System.Drawing.Size(427, 20);
            this.Comissions.TabIndex = 7;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Red;
            this.ButtonDelete.Location = new System.Drawing.Point(564, 95);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(33, 26);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "X";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.Comissions);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxAspirante);
            this.Controls.Add(this.textBoxEmployer);
            this.Controls.Add(this.ComissionLabel);
            this.Controls.Add(this.PostLabel);
            this.Controls.Add(this.AspiranteLable);
            this.Controls.Add(this.EmployerLable);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(616, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployerLable;
        private System.Windows.Forms.Label AspiranteLable;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label ComissionLabel;
        private System.Windows.Forms.TextBox textBoxEmployer;
        private System.Windows.Forms.TextBox textBoxAspirante;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox Comissions;
        private System.Windows.Forms.Button ButtonDelete;
    }
}
