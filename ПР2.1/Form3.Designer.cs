namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Words3 = new System.Windows.Forms.TextBox();
            this.LabelWords3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Exit3 = new System.Windows.Forms.Button();
            this.Ok3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Words3
            // 
            this.Words3.Location = new System.Drawing.Point(12, 42);
            this.Words3.Multiline = true;
            this.Words3.Name = "Words3";
            this.Words3.Size = new System.Drawing.Size(201, 39);
            this.Words3.TabIndex = 2;
            // 
            // LabelWords3
            // 
            this.LabelWords3.AutoSize = true;
            this.LabelWords3.Location = new System.Drawing.Point(12, 26);
            this.LabelWords3.Name = "LabelWords3";
            this.LabelWords3.Size = new System.Drawing.Size(85, 13);
            this.LabelWords3.TabIndex = 3;
            this.LabelWords3.Text = "Введите слово:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Exit3
            // 
            this.Exit3.Image = global::ПР2.Properties.Resources._1__2_;
            this.Exit3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit3.Location = new System.Drawing.Point(118, 96);
            this.Exit3.Name = "Exit3";
            this.Exit3.Size = new System.Drawing.Size(95, 23);
            this.Exit3.TabIndex = 5;
            this.Exit3.Text = "Отмена";
            this.Exit3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit3.UseVisualStyleBackColor = true;
            this.Exit3.Click += new System.EventHandler(this.Exit3_Click);
            // 
            // Ok3
            // 
            this.Ok3.Image = global::ПР2.Properties.Resources._3;
            this.Ok3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ok3.Location = new System.Drawing.Point(15, 96);
            this.Ok3.Name = "Ok3";
            this.Ok3.Size = new System.Drawing.Size(95, 23);
            this.Ok3.TabIndex = 4;
            this.Ok3.Text = "Добавить";
            this.Ok3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ok3.UseVisualStyleBackColor = true;
            this.Ok3.Click += new System.EventHandler(this.Ok3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 131);
            this.ControlBox = false;
            this.Controls.Add(this.Exit3);
            this.Controls.Add(this.Ok3);
            this.Controls.Add(this.LabelWords3);
            this.Controls.Add(this.Words3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление слова";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Words3;
        private System.Windows.Forms.Label LabelWords3;
        private System.Windows.Forms.Button Ok3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Exit3;
    }
}