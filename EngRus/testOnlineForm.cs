using System;
using System.Windows.Forms;

namespace EngRus
{
    public partial class testOnlineForm : Form
    {
        bool flag = false;

        public static int possitiveCount = 0;
        public static int negativeCount = 0;

        public testOnlineForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = !flag;

            this.Size = new System.Drawing.Size(361, 464);
            hintGroupBox.Visible = true;

            if (flag)
            {
                this.Size = new System.Drawing.Size(361, 464);
                flag = true;
                trascriptionENWord.Text = mainForm.columnTranscription;
                trascriptionRusWord.Text = mainForm.columnRusTranscription;
                wordVisible.Text = mainForm.columnEngWord;
            }
            else
            {
                hintGroupBox.Visible = false;
                this.Size = new System.Drawing.Size(361, 366);
                flag = false;
            }
        }

        private void testOnlineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Закончить тестирование?", "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void testOnlineForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(361, 366);
            wordVisible.Text = mainForm.columnEngWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (translateTextBox.Text.ToLower() == mainForm.columnRusWord.ToLower())
            {
                MessageBox.Show("Верно");
                possitiveCount = possitiveCount + 1;
                positiveStat.Text = possitiveCount.ToString();
            }

            else
            {
                MessageBox.Show("Не верно");
                negativeCount = negativeCount - 1;
                negativeStat.Text = negativeCount.ToString();
            }
        }
    }
}
