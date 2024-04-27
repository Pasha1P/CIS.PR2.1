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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// закрытие формы 2
        /// </summary>
        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// ссылка на вк
        /// </summary>
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/pasha_p2");
        }
    }
}
