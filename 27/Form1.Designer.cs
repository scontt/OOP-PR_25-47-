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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainItalicButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBoldButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainUnderlineButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFontSizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFontSizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainSearchingWordButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSearchingWordTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainSearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDeleteWordButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDeleteWordTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainDeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainClearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSizeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontSizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchingWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteWordTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.mainButton,
            this.infoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1035, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveButton,
            this.fileOpenButton,
            this.выйтиToolStripMenuItem});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(59, 24);
            this.fileButton.Text = "Файл";
            // 
            // fileSaveButton
            // 
            this.fileSaveButton.Name = "fileSaveButton";
            this.fileSaveButton.Size = new System.Drawing.Size(217, 26);
            this.fileSaveButton.Text = "Сохранить в файл";
            this.fileSaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(217, 26);
            this.fileOpenButton.Text = "Открыть";
            this.fileOpenButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // mainButton
            // 
            this.mainButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainItalicButton,
            this.mainBoldButton,
            this.mainUnderlineButton,
            this.mainFontSizeButton,
            this.mainSearchingWordButton,
            this.mainDeleteWordButton,
            this.mainClearButton});
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(79, 24);
            this.mainButton.Text = "Главная";
            // 
            // mainItalicButton
            // 
            this.mainItalicButton.Name = "mainItalicButton";
            this.mainItalicButton.Size = new System.Drawing.Size(201, 26);
            this.mainItalicButton.Text = "Курсив";
            this.mainItalicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // mainBoldButton
            // 
            this.mainBoldButton.Name = "mainBoldButton";
            this.mainBoldButton.Size = new System.Drawing.Size(201, 26);
            this.mainBoldButton.Text = "Полужирный";
            this.mainBoldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // mainUnderlineButton
            // 
            this.mainUnderlineButton.Name = "mainUnderlineButton";
            this.mainUnderlineButton.Size = new System.Drawing.Size(201, 26);
            this.mainUnderlineButton.Text = "Подчеркнутый";
            this.mainUnderlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // mainFontSizeButton
            // 
            this.mainFontSizeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFontSizeTextBox});
            this.mainFontSizeButton.Name = "mainFontSizeButton";
            this.mainFontSizeButton.Size = new System.Drawing.Size(201, 26);
            this.mainFontSizeButton.Text = "Размер шрифта";
            // 
            // mainFontSizeTextBox
            // 
            this.mainFontSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFontSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainFontSizeTextBox.Name = "mainFontSizeTextBox";
            this.mainFontSizeTextBox.Size = new System.Drawing.Size(180, 27);
            this.mainFontSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fontSizeTextBox_KeyPress);
            this.mainFontSizeTextBox.Validated += new System.EventHandler(this.fontSizeTextBox_Validated);
            // 
            // mainSearchingWordButton
            // 
            this.mainSearchingWordButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainSearchingWordTextBox,
            this.mainSearchButton});
            this.mainSearchingWordButton.Name = "mainSearchingWordButton";
            this.mainSearchingWordButton.Size = new System.Drawing.Size(201, 26);
            this.mainSearchingWordButton.Text = "Найти слова";
            // 
            // mainSearchingWordTextBox
            // 
            this.mainSearchingWordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainSearchingWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSearchingWordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainSearchingWordTextBox.Name = "mainSearchingWordTextBox";
            this.mainSearchingWordTextBox.Size = new System.Drawing.Size(180, 27);
            // 
            // mainSearchButton
            // 
            this.mainSearchButton.Name = "mainSearchButton";
            this.mainSearchButton.Size = new System.Drawing.Size(254, 26);
            this.mainSearchButton.Text = "Найти";
            this.mainSearchButton.Click += new System.EventHandler(this.mainSearchButton_Click);
            // 
            // mainDeleteWordButton
            // 
            this.mainDeleteWordButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainDeleteWordTextBox,
            this.mainDeleteButton});
            this.mainDeleteWordButton.Name = "mainDeleteWordButton";
            this.mainDeleteWordButton.Size = new System.Drawing.Size(201, 26);
            this.mainDeleteWordButton.Text = "Удалить слова";
            // 
            // mainDeleteWordTextBox
            // 
            this.mainDeleteWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDeleteWordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainDeleteWordTextBox.Name = "mainDeleteWordTextBox";
            this.mainDeleteWordTextBox.Size = new System.Drawing.Size(180, 27);
            // 
            // mainDeleteButton
            // 
            this.mainDeleteButton.Name = "mainDeleteButton";
            this.mainDeleteButton.Size = new System.Drawing.Size(254, 26);
            this.mainDeleteButton.Text = "Удалить";
            this.mainDeleteButton.Click += new System.EventHandler(this.mainDeleteButton_Click);
            // 
            // mainClearButton
            // 
            this.mainClearButton.Name = "mainClearButton";
            this.mainClearButton.Size = new System.Drawing.Size(201, 26);
            this.mainClearButton.Text = "Очистить поле";
            this.mainClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(81, 24);
            this.infoButton.Text = "Справка";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.italicButton,
            this.boldButton,
            this.underlineButton,
            this.toolStripSeparator1,
            this.fontSizeButton,
            this.clearButton,
            this.saveButton,
            this.openButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.Color.Transparent;
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(29, 29);
            this.italicButton.Text = "К";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.Color.Transparent;
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(36, 29);
            this.boldButton.Text = "Ж";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.BackColor = System.Drawing.Color.Transparent;
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(29, 29);
            this.underlineButton.Text = "Ч";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // fontSizeButton
            // 
            this.fontSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.fontSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontSizeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeTextBox});
            this.fontSizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("fontSizeButton.Image")));
            this.fontSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontSizeButton.Name = "fontSizeButton";
            this.fontSizeButton.Size = new System.Drawing.Size(182, 29);
            this.fontSizeButton.Text = "Размер шрифта";
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.Size = new System.Drawing.Size(180, 27);
            this.fontSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fontSizeTextBox_KeyPress);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(158, 29);
            this.clearButton.Text = "Очистить поле";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(187, 29);
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 29);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 64);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(815, 438);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(824, 148);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(199, 39);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchingWordTextBox
            // 
            this.searchingWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchingWordTextBox.Location = new System.Drawing.Point(823, 117);
            this.searchingWordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchingWordTextBox.Name = "searchingWordTextBox";
            this.searchingWordTextBox.Size = new System.Drawing.Size(199, 27);
            this.searchingWordTextBox.TabIndex = 4;
            this.searchingWordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchingWordTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(851, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите слово";
            // 
            // deleteWordTextBox
            // 
            this.deleteWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteWordTextBox.Location = new System.Drawing.Point(821, 242);
            this.deleteWordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteWordTextBox.Name = "deleteWordTextBox";
            this.deleteWordTextBox.Size = new System.Drawing.Size(199, 27);
            this.deleteWordTextBox.TabIndex = 6;
            this.deleteWordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deleteWordTextBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(821, 276);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(199, 53);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить слова с этой буквой";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(851, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ввведите букву";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1035, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteWordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchingWordTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Text Worker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem mainButton;
        private System.Windows.Forms.ToolStripMenuItem infoButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripMenuItem fileSaveButton;
        private System.Windows.Forms.ToolStripMenuItem fileOpenButton;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainItalicButton;
        private System.Windows.Forms.ToolStripMenuItem mainBoldButton;
        private System.Windows.Forms.ToolStripMenuItem mainUnderlineButton;
        private System.Windows.Forms.ToolStripMenuItem mainFontSizeButton;
        private System.Windows.Forms.ToolStripMenuItem mainSearchingWordButton;
        private System.Windows.Forms.ToolStripTextBox mainSearchingWordTextBox;
        private System.Windows.Forms.ToolStripMenuItem mainSearchButton;
        private System.Windows.Forms.ToolStripMenuItem mainDeleteWordButton;
        private System.Windows.Forms.ToolStripTextBox mainDeleteWordTextBox;
        private System.Windows.Forms.ToolStripMenuItem mainDeleteButton;
        private System.Windows.Forms.ToolStripMenuItem mainClearButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripTextBox mainFontSizeTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton fontSizeButton;
        private System.Windows.Forms.ToolStripTextBox fontSizeTextBox;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchingWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteWordTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton openButton;
    }
}

