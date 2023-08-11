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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oddLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoButton
            // 
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(65, 20);
            this.infoButton.Text = "Справка";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(98, 40);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(158, 20);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userTextBox_KeyPress);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(12, 76);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(244, 31);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Среднее арифметическое кодов символов строки, имеющих четный индекс: ";
            // 
            // calculButton
            // 
            this.calculButton.BackColor = System.Drawing.Color.White;
            this.calculButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculButton.Location = new System.Drawing.Point(262, 31);
            this.calculButton.Name = "calculButton";
            this.calculButton.Size = new System.Drawing.Size(112, 36);
            this.calculButton.TabIndex = 4;
            this.calculButton.Text = "Высчитать ср. арифм. кодов";
            this.calculButton.UseVisualStyleBackColor = false;
            this.calculButton.Click += new System.EventHandler(this.calculButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(298, 117);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(76, 29);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // oddLabel
            // 
            this.oddLabel.Location = new System.Drawing.Point(12, 115);
            this.oddLabel.Name = "oddLabel";
            this.oddLabel.Size = new System.Drawing.Size(234, 31);
            this.oddLabel.TabIndex = 6;
            this.oddLabel.Text = "Количество символов, имеющих нечетный код:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 162);
            this.Controls.Add(this.oddLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Коды символов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label oddLabel;
    }
}

