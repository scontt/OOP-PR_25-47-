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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addElemTextBox = new System.Windows.Forms.TextBox();
            this.addElemButton = new System.Windows.Forms.Button();
            this.addArrayLabel = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время работы приложения 0 минут";
            // 
            // addElemTextBox
            // 
            this.addElemTextBox.Location = new System.Drawing.Point(163, 36);
            this.addElemTextBox.Name = "addElemTextBox";
            this.addElemTextBox.Size = new System.Drawing.Size(78, 20);
            this.addElemTextBox.TabIndex = 1;
            this.addElemTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addElemTextBox_KeyDown);
            this.addElemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addElemTextBox_KeyPress);
            // 
            // addElemButton
            // 
            this.addElemButton.BackColor = System.Drawing.Color.White;
            this.addElemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addElemButton.Location = new System.Drawing.Point(247, 34);
            this.addElemButton.Name = "addElemButton";
            this.addElemButton.Size = new System.Drawing.Size(82, 23);
            this.addElemButton.TabIndex = 2;
            this.addElemButton.Text = "Добавить";
            this.addElemButton.UseVisualStyleBackColor = false;
            this.addElemButton.Click += new System.EventHandler(this.addElemButton_Click);
            // 
            // addArrayLabel
            // 
            this.addArrayLabel.AutoSize = true;
            this.addArrayLabel.Location = new System.Drawing.Point(9, 30);
            this.addArrayLabel.Name = "addArrayLabel";
            this.addArrayLabel.Size = new System.Drawing.Size(148, 26);
            this.addArrayLabel.TabIndex = 3;
            this.addArrayLabel.Text = "Введите элемент массива. \r\nОсталось";
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.White;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Location = new System.Drawing.Point(247, 82);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(82, 25);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(229, 25);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Массив:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(247, 122);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 25);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoButton
            // 
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(65, 20);
            this.infoButton.Text = "Справка";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 158);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.addArrayLabel);
            this.Controls.Add(this.addElemButton);
            this.Controls.Add(this.addElemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Библиотеки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addElemTextBox;
        private System.Windows.Forms.Button addElemButton;
        private System.Windows.Forms.Label addArrayLabel;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoButton;
    }
}

