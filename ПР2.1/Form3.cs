using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// добавление слова
        /// </summary>
        private void Ok3_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool ok = true;
                if (string.IsNullOrEmpty(Words3.Text))
                {
                    errorProvider1.SetError(Words3, "Ошибка");
                    ok = false;
                }
                if (ok)
                {
                    Form1.words.Add(Words3.Text+" ");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex);
            }
        }
        /// <summary>
        /// закрытие формы 3
        /// </summary>
        private void Exit3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}