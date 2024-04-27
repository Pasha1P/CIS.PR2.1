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
        /// textbox
        public void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Сведения = new System.Windows.Forms.ToolStripMenuItem();
            this.ОПрограмме = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox_words = new System.Windows.Forms.TextBox();
            this.Word = new System.Windows.Forms.Label();
            this.Adding = new System.Windows.Forms.Button();
            this.Learn = new System.Windows.Forms.Button();
            this.Often_word = new System.Windows.Forms.Label();
            this.Clearing = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Сведения});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Сведения
            // 
            this.Сведения.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОПрограмме});
            this.Сведения.Name = "Сведения";
            this.Сведения.Size = new System.Drawing.Size(71, 20);
            this.Сведения.Text = "Сведения";
            // 
            // ОПрограмме
            // 
            this.ОПрограмме.Name = "ОПрограмме";
            this.ОПрограмме.Size = new System.Drawing.Size(149, 22);
            this.ОПрограмме.Text = "О программе";
            this.ОПрограмме.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click_1);
            // 
            // TextBox_words
            // 
            this.TextBox_words.Location = new System.Drawing.Point(12, 49);
            this.TextBox_words.Multiline = true;
            this.TextBox_words.Name = "TextBox_words";
            this.TextBox_words.ReadOnly = true;
            this.TextBox_words.Size = new System.Drawing.Size(210, 45);
            this.TextBox_words.TabIndex = 1;
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Location = new System.Drawing.Point(9, 33);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(70, 13);
            this.Word.TabIndex = 2;
            this.Word.Text = "Ваши слова:";
            // 
            // Adding
            // 
            this.Adding.Location = new System.Drawing.Point(12, 100);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(75, 23);
            this.Adding.TabIndex = 3;
            this.Adding.Text = "Добавить слово";
            this.Adding.UseVisualStyleBackColor = true;
            this.Adding.Click += new System.EventHandler(this.Adding_Click);
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(40, 129);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(130, 38);
            this.Learn.TabIndex = 4;
            this.Learn.Text = "Узнать самое часто встречаемое слово";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learning_Click);
            // 
            // Often_word
            // 
            this.Often_word.AutoSize = true;
            this.Often_word.Location = new System.Drawing.Point(12, 193);
            this.Often_word.Name = "Often_word";
            this.Often_word.Size = new System.Drawing.Size(179, 13);
            this.Often_word.TabIndex = 5;
            this.Often_word.Text = "Самое часто встречаемое слово: ";
            this.Often_word.Visible = false;
            // 
            // Clearing
            // 
            this.Clearing.Location = new System.Drawing.Point(147, 100);
            this.Clearing.Name = "Clearing";
            this.Clearing.Size = new System.Drawing.Size(75, 23);
            this.Clearing.TabIndex = 6;
            this.Clearing.Text = "Очистить";
            this.Clearing.UseVisualStyleBackColor = true;
            this.Clearing.Click += new System.EventHandler(this.Clearing_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 241);
            this.Controls.Add(this.Clearing);
            this.Controls.Add(this.Often_word);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.TextBox_words);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПР 2.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Сведения;
        private System.Windows.Forms.ToolStripMenuItem ОПрограмме;
        private System.Windows.Forms.TextBox TextBox_words;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Button Adding;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Label Often_word;
        private System.Windows.Forms.Button Clearing;
    }
}

