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
            this.symbTextBox = new System.Windows.Forms.TextBox();
            this.addElemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sumCheckBox = new System.Windows.Forms.CheckBox();
            this.countCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthCheckBox = new System.Windows.Forms.CheckBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.arrayListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // symbTextBox
            // 
            this.symbTextBox.Location = new System.Drawing.Point(100, 13);
            this.symbTextBox.Name = "symbTextBox";
            this.symbTextBox.Size = new System.Drawing.Size(153, 20);
            this.symbTextBox.TabIndex = 0;
            this.symbTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.symbTextBox_KeyPress);
            // 
            // addElemButton
            // 
            this.addElemButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addElemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addElemButton.Location = new System.Drawing.Point(8, 37);
            this.addElemButton.Name = "addElemButton";
            this.addElemButton.Size = new System.Drawing.Size(245, 34);
            this.addElemButton.TabIndex = 1;
            this.addElemButton.Text = "Добавить элемент в массив";
            this.addElemButton.UseVisualStyleBackColor = false;
            this.addElemButton.Click += new System.EventHandler(this.addElemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите символ";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(257, 71);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(246, 182);
            this.resultRichTextBox.TabIndex = 5;
            this.resultRichTextBox.Text = "";
            // 
            // sumCheckBox
            // 
            this.sumCheckBox.AutoSize = true;
            this.sumCheckBox.Location = new System.Drawing.Point(510, 69);
            this.sumCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sumCheckBox.Name = "sumCheckBox";
            this.sumCheckBox.Size = new System.Drawing.Size(233, 17);
            this.sumCheckBox.TabIndex = 8;
            this.sumCheckBox.Text = "Сумма первого и последнего элементов";
            this.sumCheckBox.UseVisualStyleBackColor = true;
            // 
            // countCheckBox
            // 
            this.countCheckBox.AutoSize = true;
            this.countCheckBox.Location = new System.Drawing.Point(510, 90);
            this.countCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countCheckBox.Name = "countCheckBox";
            this.countCheckBox.Size = new System.Drawing.Size(235, 17);
            this.countCheckBox.TabIndex = 9;
            this.countCheckBox.Text = "Количество символов с нечетным кодом";
            this.countCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthCheckBox
            // 
            this.lengthCheckBox.AutoSize = true;
            this.lengthCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthCheckBox.Location = new System.Drawing.Point(510, 111);
            this.lengthCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lengthCheckBox.Name = "lengthCheckBox";
            this.lengthCheckBox.Size = new System.Drawing.Size(159, 17);
            this.lengthCheckBox.TabIndex = 10;
            this.lengthCheckBox.Text = "Длина массива символов";
            this.lengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionButton.Location = new System.Drawing.Point(509, 133);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(212, 28);
            this.actionButton.TabIndex = 11;
            this.actionButton.Text = "Выполнить";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(508, 178);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(213, 28);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // arrayListBox
            // 
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.Location = new System.Drawing.Point(8, 99);
            this.arrayListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(246, 160);
            this.arrayListBox.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(510, 223);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(213, 28);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Массив";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Результат";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(259, 7);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(464, 45);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "Данная программа позволяет пользователю ввести элементы массива и выбрать действи" +
    "я, реализуемые над массивом ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 267);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.arrayListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.lengthCheckBox);
            this.Controls.Add(this.countCheckBox);
            this.Controls.Add(this.sumCheckBox);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addElemButton);
            this.Controls.Add(this.symbTextBox);
            this.Name = "Form1";
            this.Text = "События";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox symbTextBox;
        private System.Windows.Forms.Button addElemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.CheckBox sumCheckBox;
        private System.Windows.Forms.CheckBox countCheckBox;
        private System.Windows.Forms.CheckBox lengthCheckBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox arrayListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

