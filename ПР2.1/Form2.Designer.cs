namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picture = new System.Windows.Forms.PictureBox();
            this.Exit2 = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.Label();
            this.developed = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(118, 57);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(207, 95);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 25;
            this.picture.TabStop = false;
            // 
            // Exit2
            // 
            this.Exit2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Exit2.Image = global::ПР2.Properties.Resources._5;
            this.Exit2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit2.Location = new System.Drawing.Point(337, 218);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(94, 38);
            this.Exit2.TabIndex = 24;
            this.Exit2.Text = "Назад";
            this.Exit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit2.UseVisualStyleBackColor = true;
            this.Exit2.Click += new System.EventHandler(this.buttonDown_Click_1);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(68, 228);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(145, 13);
            this.link.TabIndex = 23;
            this.link.TabStop = true;
            this.link.Text = "pavel121120062@gmail.com";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(11, 224);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 17);
            this.email.TabIndex = 22;
            this.email.Text = "E-mail:";
            // 
            // specialization
            // 
            this.specialization.AutoSize = true;
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialization.Location = new System.Drawing.Point(11, 193);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(443, 17);
            this.specialization.TabIndex = 21;
            this.specialization.Text = "Специальность: Информационные Системы и Программирование";
            // 
            // developed
            // 
            this.developed.AutoSize = true;
            this.developed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developed.Location = new System.Drawing.Point(11, 166);
            this.developed.Name = "developed";
            this.developed.Size = new System.Drawing.Size(238, 17);
            this.developed.TabIndex = 20;
            this.developed.Text = "Разработал: студент Погудин П.Д.";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading.Location = new System.Drawing.Point(29, 11);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(408, 24);
            this.heading.TabIndex = 19;
            this.heading.Text = "Программа \"Практическая работа №2.1\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 266);
            this.ControlBox = false;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Exit2);
            this.Controls.Add(this.link);
            this.Controls.Add(this.email);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.developed);
            this.Controls.Add(this.heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        public System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.Label developed;
        private System.Windows.Forms.Label heading;
    }
}