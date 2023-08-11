namespace WindowsFormsApp1
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Флейта");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Кларнет");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Гобой");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Духовые", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Лютня");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Мандолина");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Виолончель");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Струнные", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Рояль");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Орган");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Фортепиано");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Клавишные", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.musicGroupBox = new System.Windows.Forms.GroupBox();
            this.descripRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descripGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.printGroupBox = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.pageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.descripGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.printGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 32);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "flute";
            treeNode13.Text = "Флейта";
            treeNode14.Name = "clarinet";
            treeNode14.Text = "Кларнет";
            treeNode15.Name = "oboe";
            treeNode15.Text = "Гобой";
            treeNode16.Name = "windInstr";
            treeNode16.Text = "Духовые";
            treeNode17.Name = "lute";
            treeNode17.Text = "Лютня";
            treeNode18.Name = "mandolin";
            treeNode18.Text = "Мандолина";
            treeNode19.Name = "cello";
            treeNode19.Text = "Виолончель";
            treeNode20.Name = "stringsInstr";
            treeNode20.Text = "Струнные";
            treeNode21.Name = "piano";
            treeNode21.Text = "Рояль";
            treeNode22.Name = "organ";
            treeNode22.Text = "Орган";
            treeNode23.Name = "fpiano";
            treeNode23.Text = "Фортепиано";
            treeNode24.Name = "keysInstr";
            treeNode24.Text = "Клавишные";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(252, 141);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // musicGroupBox
            // 
            this.musicGroupBox.Location = new System.Drawing.Point(9, 12);
            this.musicGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicGroupBox.Name = "musicGroupBox";
            this.musicGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicGroupBox.Size = new System.Drawing.Size(301, 331);
            this.musicGroupBox.TabIndex = 1;
            this.musicGroupBox.TabStop = false;
            this.musicGroupBox.Text = "Музыкальные инструменты";
            // 
            // descripRichTextBox
            // 
            this.descripRichTextBox.Location = new System.Drawing.Point(8, 20);
            this.descripRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripRichTextBox.Name = "descripRichTextBox";
            this.descripRichTextBox.Size = new System.Drawing.Size(599, 297);
            this.descripRichTextBox.TabIndex = 2;
            this.descripRichTextBox.Text = "";
            // 
            // descripGroupBox
            // 
            this.descripGroupBox.Controls.Add(this.exitButton);
            this.descripGroupBox.Controls.Add(this.searchGroupBox);
            this.descripGroupBox.Controls.Add(this.printGroupBox);
            this.descripGroupBox.Controls.Add(this.descripRichTextBox);
            this.descripGroupBox.Location = new System.Drawing.Point(319, 12);
            this.descripGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripGroupBox.Name = "descripGroupBox";
            this.descripGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripGroupBox.Size = new System.Drawing.Size(853, 331);
            this.descripGroupBox.TabIndex = 3;
            this.descripGroupBox.TabStop = false;
            this.descripGroupBox.Text = "Описание";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(627, 289);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 28);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 35);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(194, 22);
            this.searchTextBox.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(10, 65);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 28);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(615, 20);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchGroupBox.Size = new System.Drawing.Size(214, 110);
            this.searchGroupBox.TabIndex = 13;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Введите критерий поиска";
            // 
            // printGroupBox
            // 
            this.printGroupBox.Controls.Add(this.printButton);
            this.printGroupBox.Controls.Add(this.pageButton);
            this.printGroupBox.Location = new System.Drawing.Point(617, 137);
            this.printGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printGroupBox.Name = "printGroupBox";
            this.printGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printGroupBox.Size = new System.Drawing.Size(212, 110);
            this.printGroupBox.TabIndex = 11;
            this.printGroupBox.TabStop = false;
            this.printGroupBox.Text = "Печать";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(8, 59);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(193, 28);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // pageButton
            // 
            this.pageButton.Location = new System.Drawing.Point(9, 23);
            this.pageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageButton.Name = "pageButton";
            this.pageButton.Size = new System.Drawing.Size(193, 28);
            this.pageButton.TabIndex = 9;
            this.pageButton.Text = "Параметры страницы";
            this.pageButton.UseVisualStyleBackColor = true;
            this.pageButton.Click += new System.EventHandler(this.pageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 194);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(284, 28);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(17, 230);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(284, 28);
            this.cleanButton.TabIndex = 5;
            this.cleanButton.Text = "Очистить";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(17, 266);
            this.fontButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(284, 28);
            this.fontButton.TabIndex = 6;
            this.fontButton.Text = "Шрифт";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(17, 302);
            this.colorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(284, 28);
            this.colorButton.TabIndex = 7;
            this.colorButton.Text = "Цвет шрифтов";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 358);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descripGroupBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.musicGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Файлы";
            this.descripGroupBox.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.printGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox musicGroupBox;
        private System.Windows.Forms.RichTextBox descripRichTextBox;
        private System.Windows.Forms.GroupBox descripGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox printGroupBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button pageButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

