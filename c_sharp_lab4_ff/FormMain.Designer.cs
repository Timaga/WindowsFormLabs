﻿namespace c_sharp_lab4_ff
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работодательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.соискательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewEmployer = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewAspirante = new System.Windows.Forms.ListView();
            this.Данные = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewOffers = new System.Windows.Forms.ListView();
            this.Aspirant = new System.Windows.Forms.ColumnHeader();
            this.Emlpoyer = new System.Windows.Forms.ColumnHeader();
            this.Должность = new System.Windows.Forms.ColumnHeader();
            this.Комиссионные = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.RabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.работодательToolStripMenuItem,
            this.соискательToolStripMenuItem,
            this.сделкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // работодательToolStripMenuItem
            // 
            this.работодательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1});
            this.работодательToolStripMenuItem.Name = "работодательToolStripMenuItem";
            this.работодательToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.работодательToolStripMenuItem.Text = "Работодатель";
            this.работодательToolStripMenuItem.Click += new System.EventHandler(this.работодательToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.создатьToolStripMenuItem1_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // соискательToolStripMenuItem
            // 
            this.соискательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.соискательToolStripMenuItem.Name = "соискательToolStripMenuItem";
            this.соискательToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.соискательToolStripMenuItem.Text = "Соискатель";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // сделкаToolStripMenuItem
            // 
            this.сделкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem2});
            this.сделкаToolStripMenuItem.Name = "сделкаToolStripMenuItem";
            this.сделкаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.сделкаToolStripMenuItem.Text = "Сделка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem2
            // 
            this.редактироватьToolStripMenuItem2.Name = "редактироватьToolStripMenuItem2";
            this.редактироватьToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem2.Text = "Редактировать";
            this.редактироватьToolStripMenuItem2.Click += new System.EventHandler(this.редактироватьToolStripMenuItem2_Click);
            // 
            // RabPage
            // 
            this.RabPage.Controls.Add(this.tabPage1);
            this.RabPage.Controls.Add(this.tabPage2);
            this.RabPage.Controls.Add(this.tabPage3);
            this.RabPage.Location = new System.Drawing.Point(12, 27);
            this.RabPage.Name = "RabPage";
            this.RabPage.SelectedIndex = 0;
            this.RabPage.Size = new System.Drawing.Size(651, 281);
            this.RabPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewEmployer);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работодатель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewEmployer
            // 
            this.listViewEmployer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewEmployer.FullRowSelect = true;
            this.listViewEmployer.GridLines = true;
            this.listViewEmployer.Location = new System.Drawing.Point(6, 4);
            this.listViewEmployer.Name = "listViewEmployer";
            this.listViewEmployer.Size = new System.Drawing.Size(631, 244);
            this.listViewEmployer.TabIndex = 1;
            this.listViewEmployer.UseCompatibleStateImageBehavior = false;
            this.listViewEmployer.View = System.Windows.Forms.View.Details;
            this.listViewEmployer.SelectedIndexChanged += new System.EventHandler(this.listViewEmployer_SelectedIndexChanged);
            this.listViewEmployer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewEmployer_KeyUp);
            this.listViewEmployer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewEmployer_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя ";
            this.columnHeader1.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewAspirante);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Соискатель";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewAspirante
            // 
            this.listViewAspirante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Данные});
            this.listViewAspirante.FullRowSelect = true;
            this.listViewAspirante.GridLines = true;
            this.listViewAspirante.Location = new System.Drawing.Point(6, 4);
            this.listViewAspirante.Name = "listViewAspirante";
            this.listViewAspirante.Size = new System.Drawing.Size(631, 244);
            this.listViewAspirante.TabIndex = 1;
            this.listViewAspirante.UseCompatibleStateImageBehavior = false;
            this.listViewAspirante.View = System.Windows.Forms.View.Details;
            this.listViewAspirante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewAspirante_KeyUp);
            this.listViewAspirante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewAspirante_KeyUp);
            // 
            // Данные
            // 
            this.Данные.Text = "Данные";
            this.Данные.Width = 400;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewOffers);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(643, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сделка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewOffers
            // 
            this.listViewOffers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Aspirant,
            this.Emlpoyer,
            this.Должность,
            this.Комиссионные});
            this.listViewOffers.FullRowSelect = true;
            this.listViewOffers.GridLines = true;
            this.listViewOffers.Location = new System.Drawing.Point(6, 6);
            this.listViewOffers.Name = "listViewOffers";
            this.listViewOffers.Size = new System.Drawing.Size(631, 244);
            this.listViewOffers.TabIndex = 0;
            this.listViewOffers.UseCompatibleStateImageBehavior = false;
            this.listViewOffers.View = System.Windows.Forms.View.Details;
            this.listViewOffers.SelectedIndexChanged += new System.EventHandler(this.listViewOffers_SelectedIndexChanged);
            this.listViewOffers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewSettlement_KeyUp);
            this.listViewOffers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewSettlement_KeyUp);
            // 
            // Aspirant
            // 
            this.Aspirant.DisplayIndex = 1;
            this.Aspirant.Text = "Соискатель";
            this.Aspirant.Width = 150;
            // 
            // Emlpoyer
            // 
            this.Emlpoyer.DisplayIndex = 0;
            this.Emlpoyer.Text = "Работодатель";
            this.Emlpoyer.Width = 150;
            // 
            // Должность
            // 
            this.Должность.Text = "Должность";
            this.Должность.Width = 100;
            // 
            // Комиссионные
            // 
            this.Комиссионные.Text = "Комиссионные";
            this.Комиссионные.Width = 100;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 344);
            this.Controls.Add(this.RabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem работодательToolStripMenuItem;
        private ToolStripMenuItem соискательToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem1;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem сделкаToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem2;
        private TabControl RabPage;
        private TabPage tabPage1;
        private ListView listViewEmployer;
        private TabPage tabPage2;
        private ListView listViewAspirante;
        private TabPage tabPage3;
        private ListView listViewOffers;
        private ColumnHeader columnHeader1;
        private ColumnHeader Данные;
        private ColumnHeader Emlpoyer;
        private ColumnHeader Aspirant;
        private ColumnHeader Должность;
        private ColumnHeader Комиссионные;
    }
}