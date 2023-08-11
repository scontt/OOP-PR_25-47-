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
            this.arrayDataGridView = new System.Windows.Forms.DataGridView();
            this.createArrayButton = new System.Windows.Forms.Button();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.intRadioButton = new System.Windows.Forms.RadioButton();
            this.doubleRadioButton = new System.Windows.Forms.RadioButton();
            this.averageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteArrayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayDataGridView
            // 
            this.arrayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayDataGridView.Location = new System.Drawing.Point(15, 120);
            this.arrayDataGridView.Name = "arrayDataGridView";
            this.arrayDataGridView.Size = new System.Drawing.Size(341, 150);
            this.arrayDataGridView.TabIndex = 0;
            // 
            // createArrayButton
            // 
            this.createArrayButton.Location = new System.Drawing.Point(226, 53);
            this.createArrayButton.Name = "createArrayButton";
            this.createArrayButton.Size = new System.Drawing.Size(130, 23);
            this.createArrayButton.TabIndex = 2;
            this.createArrayButton.Text = "Создать массив";
            this.createArrayButton.UseVisualStyleBackColor = true;
            this.createArrayButton.Click += new System.EventHandler(this.createArrayButton_Click);
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(155, 68);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(26, 20);
            this.columnsTextBox.TabIndex = 1;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(194, 68);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(26, 20);
            this.rowsTextBox.TabIndex = 3;
            // 
            // intRadioButton
            // 
            this.intRadioButton.AutoSize = true;
            this.intRadioButton.Location = new System.Drawing.Point(142, 32);
            this.intRadioButton.Name = "intRadioButton";
            this.intRadioButton.Size = new System.Drawing.Size(106, 17);
            this.intRadioButton.TabIndex = 4;
            this.intRadioButton.TabStop = true;
            this.intRadioButton.Text = "Целочисленный";
            this.intRadioButton.UseVisualStyleBackColor = true;
            this.intRadioButton.CheckedChanged += new System.EventHandler(this.intRadioButton_CheckedChanged);
            // 
            // doubleRadioButton
            // 
            this.doubleRadioButton.AutoSize = true;
            this.doubleRadioButton.Location = new System.Drawing.Point(254, 32);
            this.doubleRadioButton.Name = "doubleRadioButton";
            this.doubleRadioButton.Size = new System.Drawing.Size(102, 17);
            this.doubleRadioButton.TabIndex = 5;
            this.doubleRadioButton.TabStop = true;
            this.doubleRadioButton.Text = "Вещественный";
            this.doubleRadioButton.UseVisualStyleBackColor = true;
            this.doubleRadioButton.CheckedChanged += new System.EventHandler(this.intRadioButton_CheckedChanged);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(15, 321);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(209, 38);
            this.averageButton.TabIndex = 7;
            this.averageButton.Text = "Среднее арифметическое каждого столбца";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите тип массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите размер массива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите массив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Среднее арифметическое соответственных столбцов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoButton
            // 
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(65, 20);
            this.infoButton.Text = "Справка";
            this.infoButton.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(243, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.ColumnHeadersVisible = false;
            this.resultDataGridView.Location = new System.Drawing.Point(15, 289);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.Size = new System.Drawing.Size(341, 26);
            this.resultDataGridView.TabIndex = 15;
            // 
            // deleteArrayButton
            // 
            this.deleteArrayButton.Location = new System.Drawing.Point(226, 82);
            this.deleteArrayButton.Name = "deleteArrayButton";
            this.deleteArrayButton.Size = new System.Drawing.Size(130, 23);
            this.deleteArrayButton.TabIndex = 16;
            this.deleteArrayButton.Text = "Удалить массив";
            this.deleteArrayButton.UseVisualStyleBackColor = true;
            this.deleteArrayButton.Click += new System.EventHandler(this.deleteArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 376);
            this.Controls.Add(this.deleteArrayButton);
            this.Controls.Add(this.resultDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.doubleRadioButton);
            this.Controls.Add(this.intRadioButton);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.createArrayButton);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.arrayDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Перегрузка";
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createArrayButton;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.RadioButton intRadioButton;
        private System.Windows.Forms.RadioButton doubleRadioButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView arrayDataGridView;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button deleteArrayButton;
    }
}

