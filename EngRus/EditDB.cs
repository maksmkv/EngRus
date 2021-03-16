using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace EngRus
{
    public partial class EditDB : Form
    {
        mainForm ff;

        public string indexTable;

        public EditDB(mainForm ff)
        {
            InitializeComponent();
            this.ff = ff;
        }
        private void CustomizeEditDataGridView()
        {
            this.editDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.editDataGridView.MultiSelect = false;
            this.editDataGridView.AutoGenerateColumns = false;

            this.editDataGridView.ReadOnly = true;
            this.editDataGridView.RowHeadersVisible = false;
            this.editDataGridView.AllowUserToAddRows = false;  //убрать пустую строку в конце GridView

            this.editDataGridView.Columns.Clear();

            var columnId = new DataGridViewTextBoxColumn { DataPropertyName = "_id", HeaderText = "id", Width = 100 };
            var columnEngWord = new DataGridViewTextBoxColumn { DataPropertyName = "engword", HeaderText = "Английский", Width = 50 };
            var columnTranscription = new DataGridViewTextBoxColumn { DataPropertyName = "transcription", HeaderText = "Английская транскрипция" };
            var columnRusTranscription = new DataGridViewTextBoxColumn { DataPropertyName = "rustranscription", HeaderText = "Русская транскрипция", Width = 75 };
            var columnRusWord = new DataGridViewTextBoxColumn { DataPropertyName = "rusword", HeaderText = "Русский", Width = 75 };
            var columnDescription = new DataGridViewTextBoxColumn { DataPropertyName = "description", HeaderText = "Описание", Width = 250 };
            var columnLink = new DataGridViewTextBoxColumn { DataPropertyName = "link", HeaderText = "Ссылка на изображение", Width = 250 };

            this.editDataGridView.Columns.AddRange(new[] { columnId, columnEngWord, columnTranscription, columnRusTranscription, columnRusWord, columnDescription, columnLink });

            this.editDataGridView.Columns[0].Visible = false;
            this.editDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                editDataGridView.DataSource = dt;
            }
        }

        public void UpdateDataBase()
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
                editDataGridView.DataSource = dt;
            }
        }

        private void EditDB_Load(object sender, EventArgs e)
        {
            CustomizeEditDataGridView();
            ReadDBFull();
            UpdateDataBase();
        }

        private void btnAddBD_Click(object sender, EventArgs e)
        {

            if (addWordENG.Text == "" || addWordRUS.Text == "")
            {
                MessageBox.Show("Не добавлено слово/фраза на английском или русском", "Ошибка");
            }
            else
            {
                string connection = @"Data Source=.\\DBEngRus.db; Version=3";
                SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
                string stringQuery = "insert into engrusdata (engword, transcription, rustranscription, rusword, description, link) values('" + this.addWordENG.Text + "','" + this.addTransENG.Text + "' ,'" + this.addTransRUS.Text + "','" + this.addWordRUS.Text + "','" + this.addDescription.Text + "','" + this.addLink.Text + "'  )";
                sqlite_conn.Open();//Open the SqliteConnection
                var SqliteCmd = new SQLiteCommand();//Initialize the SqliteCommand
                SqliteCmd = sqlite_conn.CreateCommand();//Create the SqliteCommand
                SqliteCmd.CommandText = stringQuery;//Assigning the query to CommandText
                SqliteCmd.ExecuteNonQuery();//Execute the SqliteCommand
                sqlite_conn.Close();//Close the SqliteConnection
                MessageBox.Show("Данные в базу добавлены!", "Внимание");
            }
        }

        private void btnDeleteBD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in editDataGridView.SelectedRows)
                {
                    string connection = @"Data Source=.\\DBEngRus.db; Version=3";
                    SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
                    var stringQuery = $"DELETE FROM engrusdata WHERE _id='{this.editDataGridView.SelectedRows[0].Cells[0].Value}'";
                    sqlite_conn.Open();//Open the SqliteConnection
                    var SqliteCmd = new SQLiteCommand();//Initialize the SqliteCommand
                    SqliteCmd = sqlite_conn.CreateCommand();//Create the SqliteCommand
                    SqliteCmd.CommandText = stringQuery;//Assigning the query to CommandText
                    SqliteCmd.ExecuteNonQuery();//Execute the SqliteCommand
                    sqlite_conn.Close();
                    editDataGridView.Rows.Remove(row);
                }
            }
        }

        private void btnUpdateBD_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
        }

        private void btnEditStringBD_Click(object sender, EventArgs e)
        {
            if (editDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Данные не заполнены!", "Ошибка");
            }
            else
            {
                btnAddBD.Visible = false;
                btnDeleteBD.Visible = false;
                btnUpdateBD.Visible = false;

                btnApplyChange.Visible = true;

                indexTable = editDataGridView.SelectedRows[0].Cells[0].Value.ToString(); //номер строки
                addWordENG.Text = editDataGridView.SelectedCells[1].Value.ToString();
                addTransENG.Text = editDataGridView.SelectedCells[2].Value.ToString();
                addTransRUS.Text = editDataGridView.SelectedCells[3].Value.ToString();
                addWordRUS.Text = editDataGridView.SelectedCells[4].Value.ToString();
                addDescription.Text = editDataGridView.SelectedCells[5].Value.ToString();
                addLink.Text = editDataGridView.SelectedCells[6].Value.ToString();
            }
        }

        private void btnApplyChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите внести изменения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connection = @"Data Source=.\\DBEngRus.db; Version=3";
                SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
                var stringQuery = $"UPDATE engrusdata set engword='{this.addWordENG.Text}', transcription='{this.addTransENG.Text}', rustranscription='{this.addTransRUS.Text}', rusword='{this.addWordRUS.Text}', description='{this.addDescription.Text}',link='{this.addLink.Text}'  WHERE _id='{this.indexTable}'";
                sqlite_conn.Open();//Open the SqliteConnection
                var SqliteCmd = new SQLiteCommand();//Initialize the SqliteCommand
                SqliteCmd = sqlite_conn.CreateCommand();//Create the SqliteCommand
                SqliteCmd.CommandText = stringQuery;//Assigning the query to CommandText
                SqliteCmd.ExecuteNonQuery();//Execute the SqliteCommand
                sqlite_conn.Close();//Close the SqliteConnection
                UpdateDataBase();
                clearFormEdit();
            }
            else
            {
                clearFormEdit();
            }
        }

        private void clearFormEdit()
        {
            btnAddBD.Visible = true;
            btnDeleteBD.Visible = true;
            btnUpdateBD.Visible = true;

            btnApplyChange.Visible = false;


            addWordENG.Text = "";
            addTransENG.Text = "";
            addTransRUS.Text = "";
            addWordRUS.Text = "";
            addDescription.Text = "";
            addLink.Text = "";
        }
    }
}
