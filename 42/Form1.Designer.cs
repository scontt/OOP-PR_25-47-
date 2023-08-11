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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.startBoundTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endBoundTextBox = new System.Windows.Forms.TextBox();
            this.arrayLengthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите начало диапазона значений массива";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoButton
            // 
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(81, 24);
            this.infoButton.Text = "Справка";
            // 
            // startBoundTextBox
            // 
            this.startBoundTextBox.Location = new System.Drawing.Point(345, 80);
            this.startBoundTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startBoundTextBox.Name = "startBoundTextBox";
            this.startBoundTextBox.Size = new System.Drawing.Size(79, 22);
            this.startBoundTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите конец диапазона значений массива";
            // 
            // endBoundTextBox
            // 
            this.endBoundTextBox.Location = new System.Drawing.Point(345, 112);
            this.endBoundTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endBoundTextBox.Name = "endBoundTextBox";
            this.endBoundTextBox.Size = new System.Drawing.Size(79, 22);
            this.endBoundTextBox.TabIndex = 4;
            // 
            // arrayLengthTextBox
            // 
            this.arrayLengthTextBox.Location = new System.Drawing.Point(207, 46);
            this.arrayLengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.arrayLengthTextBox.Name = "arrayLengthTextBox";
            this.arrayLengthTextBox.Size = new System.Drawing.Size(80, 22);
            this.arrayLengthTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите размер массива";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 220);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(405, 190);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Location = new System.Drawing.Point(19, 166);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(258, 20);
            this.plusRadioButton.TabIndex = 10;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "Отрицательные на положительные";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Location = new System.Drawing.Point(19, 192);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(258, 20);
            this.minusRadioButton.TabIndex = 11;
            this.minusRadioButton.TabStop = true;
            this.minusRadioButton.Text = "Положительные на отрицательные";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выберите действие с заменой чисел массива";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(19, 418);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(405, 28);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 456);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minusRadioButton);
            this.Controls.Add(this.plusRadioButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.arrayLengthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endBoundTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBoundTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Интерфейсы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoButton;
        private System.Windows.Forms.TextBox startBoundTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endBoundTextBox;
        private System.Windows.Forms.TextBox arrayLengthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
    }
}

