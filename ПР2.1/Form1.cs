using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        static string text = "";
        public static List<string> words = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Often_word.Visible = false;
        }
        /// <summary>
        /// открытие формы 2
        /// </summary>
        private void ОПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        /// <summary>
        /// открытие формы 3
        /// </summary>
        private void Adding_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Change();
        }
        /// <summary>
        /// выявление самог частого слова
        /// </summary>
        private void Learning_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word)) wordCount[word]++;
                else wordCount[word] = 1;
            }

            string mostFrequentWord = "", mostFrequentWord1 = "";
            int maxCount = 0;
            bool doub = false;

            foreach (KeyValuePair<string, int> item in wordCount)
            {
                if (item.Value > maxCount)
                {
                    mostFrequentWord = item.Key;
                    maxCount = item.Value;
                    doub = false;
                }
                if (item.Value == maxCount && item.Key != mostFrequentWord)
                {
                    doub = true;
                    mostFrequentWord1 = item.Key;
                }
            }
            if (words.Count > 0)
            {
                Often_word.Visible = true;
                if (!doub)
                {
                    Often_word.Text = "Самое часто встречаемое слово: " + mostFrequentWord;
                }
                else
                {
                    Often_word.Text = $"Есть несколько самых часто\nвстречаемых слов. Вот два первых самых\nчастых слова это {mostFrequentWord} и {mostFrequentWord1}";
                }
            }
            else MessageBox.Show("Нету слов!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// обновление textbox
        /// </summary>
        public void Change()
        {
            foreach (string word in words)
            {
                text += word + ", ";
            }
            string texting = text.Trim().Trim(',');
            text = "";
            TextBox_words.Text = texting;
        }
        /// <summary>
        /// очистка и потверждение очистки textbox 
        /// </summary>
        private void Clearing_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы учеренны?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                words.Clear();
                Change();
            }
        }
    }
}
