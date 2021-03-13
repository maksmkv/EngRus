//https://www.youtube.com/watch?v=29q1Lz8ErMc
// https://www.cyberforum.ru/windows-forms/thread1646009.html отображение начальной формы, при закрытии дочерней

using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EngRus
{
    public partial class mainForm : Form
    {
        public static int columnId { get; set; }
        public static string columnEngWord { get; set; }
        public static string columnTranscription { get; set; }
        public static string columnRusTranscription { get; set; }
        public static string columnRusWord { get; set; }
        public static string columnDescription { get; set; }
        public static string columnLink { get; set; }

        public mainForm()
        {
            InitializeComponent();
        }

        private void CustomizeDataGridView()
        {
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.AutoGenerateColumns = false;

            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.AllowUserToAddRows = false;  //убрать пустую строку в конце GridView

            this.dataGridView.Columns.Clear();

            var columnId = new DataGridViewTextBoxColumn { DataPropertyName = "_id", HeaderText = "id", Width = 100 };
            var columnEngWord = new DataGridViewTextBoxColumn { DataPropertyName = "engword", HeaderText = "Английский", Width = 50 };
            var columnTranscription = new DataGridViewTextBoxColumn { DataPropertyName = "transcription", HeaderText = "Транскрипция" };
            var columnRusTranscription = new DataGridViewTextBoxColumn { DataPropertyName = "rustranscription", HeaderText = "Русский", Width = 75 };
            var columnRusWord = new DataGridViewTextBoxColumn { DataPropertyName = "rusword", HeaderText = "Русский", Width = 75 };
            var columnDescription = new DataGridViewTextBoxColumn { DataPropertyName = "description", HeaderText = "Описание", Width = 250 };
            var columnLink = new DataGridViewTextBoxColumn { DataPropertyName = "link", HeaderText = "Ссылка на изображение", Width = 250 };

            this.dataGridView.Columns.AddRange(new[] { columnId, columnEngWord, columnTranscription, columnRusTranscription, columnRusWord, columnDescription, columnLink });

            this.dataGridView.Columns[0].Visible = false;
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadDBFull()
        {
            SQLiteConnection myconnection = new SQLiteConnection("Data Source=.\\DBEngRus.db; Version=3");
            myconnection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "Select * from engrusdata";

            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                myconnection.Close();
                dataGridView.DataSource = dt;
            }
        }

        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomizeDataGridView();
            ReadDBFull();
        }

        private void начатьТестированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Данные не заполнены!");
            }
            else
            {
                randGetWord();
                testOnlineForm f2 = new testOnlineForm();
                this.Hide();
                f2.ShowDialog(); //Отображать  изначальную форму
                this.Show();
            }
        }

        public void randGetWord()
        {
            int countRow = this.dataGridView.Rows.Count;
            Random rnd = new Random(); // выбор рандомной строки и взятие значения из 1-го столбца (слово на английском)
            this.dataGridView.Rows[rnd.Next(0, countRow)].Selected = true;

            columnEngWord = this.dataGridView.SelectedCells[1].Value.ToString();
            columnTranscription = this.dataGridView.SelectedCells[2].Value.ToString();
            columnRusTranscription = this.dataGridView.SelectedCells[3].Value.ToString();
            columnRusWord = this.dataGridView.SelectedCells[4].Value.ToString();
            columnDescription = this.dataGridView.SelectedCells[5].Value.ToString();
            columnLink = this.dataGridView.SelectedCells[6].Value.ToString();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Закрыть программу?", "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
