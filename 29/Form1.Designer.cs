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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fillArrayButton = new System.Windows.Forms.Button();
            this.startBoundTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endBoundTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numChangeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numChangeButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(16, 51);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 538);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // fillArrayButton
            // 
            this.fillArrayButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fillArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillArrayButton.Location = new System.Drawing.Point(657, 209);
            this.fillArrayButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillArrayButton.Name = "fillArrayButton";
            this.fillArrayButton.Size = new System.Drawing.Size(242, 78);
            this.fillArrayButton.TabIndex = 2;
            this.fillArrayButton.Text = "Заполнить массив случайными числами";
            this.fillArrayButton.UseVisualStyleBackColor = false;
            this.fillArrayButton.Click += new System.EventHandler(this.fillArrayButton_Click);
            // 
            // startBoundTextBox
            // 
            this.startBoundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBoundTextBox.Location = new System.Drawing.Point(818, 68);
            this.startBoundTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startBoundTextBox.Name = "startBoundTextBox";
            this.startBoundTextBox.Size = new System.Drawing.Size(81, 26);
            this.startBoundTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(653, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Первая граница дипазона чисел массива";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endBoundTextBox
            // 
            this.endBoundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endBoundTextBox.Location = new System.Drawing.Point(818, 155);
            this.endBoundTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endBoundTextBox.Name = "endBoundTextBox";
            this.endBoundTextBox.Size = new System.Drawing.Size(81, 26);
            this.endBoundTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(652, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 74);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вторая граница дипазона чисел массива";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numChangeTextBox
            // 
            this.numChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChangeTextBox.Location = new System.Drawing.Point(818, 331);
            this.numChangeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numChangeTextBox.Name = "numChangeTextBox";
            this.numChangeTextBox.Size = new System.Drawing.Size(81, 27);
            this.numChangeTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(665, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите число";
            // 
            // numChangeButton
            // 
            this.numChangeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numChangeButton.Location = new System.Drawing.Point(657, 378);
            this.numChangeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numChangeButton.Name = "numChangeButton";
            this.numChangeButton.Size = new System.Drawing.Size(242, 71);
            this.numChangeButton.TabIndex = 9;
            this.numChangeButton.Text = "Заменить положительные элементы, размещенные в столбцах с четным номером";
            this.numChangeButton.UseVisualStyleBackColor = false;
            this.numChangeButton.Click += new System.EventHandler(this.numChangeButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(657, 465);
            this.sumButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(242, 62);
            this.sumButton.TabIndex = 10;
            this.sumButton.Text = "Вывести сумму всех отрицательных элементов массива";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MistyRose;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(780, 551);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 38);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(16, 11);
            this.infoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(243, 34);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "Что делает программа?";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(656, 551);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(914, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.numChangeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numChangeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endBoundTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBoundTextBox);
            this.Controls.Add(this.fillArrayButton);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Работа с массивом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button fillArrayButton;
        private System.Windows.Forms.TextBox startBoundTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endBoundTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numChangeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button numChangeButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button button1;
    }
}

