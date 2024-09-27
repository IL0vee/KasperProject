using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectKasper
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void ExitRequestsButton_Click(object sender, EventArgs e)
        {
            ExitRequestsButton.BackColor = Color.Blue;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExitRequestsButton_MouseEnter(object sender, EventArgs e)
        {
            ExitRequestsButton.BackColor = Color.LightBlue;
        }

        private void ExitRequestsButton_MouseLeave(object sender, EventArgs e)
        {
            ExitRequestsButton.BackColor = Color.Transparent;
        }

        private void RollUp_Click(object sender, EventArgs e)
        {
            RollUp.BackColor = Color.Blue;
            this.WindowState = FormWindowState.Minimized;
        }

        private void RollUp_MouseEnter(object sender, EventArgs e)
        {
            RollUp.BackColor = Color.LightBlue;
        }

        private void RollUp_MouseLeave(object sender, EventArgs e)
        {
            RollUp.BackColor = Color.Transparent;
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            ReqestsTable.Visible = false;
            ReqestsTable.AutoGenerateColumns = true;
            ReqestsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ReqestsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReqestsOneButton_Click(object sender, EventArgs e)
        {
            ReqestsOneButton.BackColor = Color.Blue;

            ReqestsTable.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db");
            string query = "SELECT surname_mech, name_mech, middlename_mech " +
                "FROM Mechanicks " +
                "JOIN NaryadRepair ON Mechanicks.id_mech = NaryadRepair.id_mech " +
                "JOIN Cars ON NaryadRepair.id_car = Cars.id_car " +
                "WHERE Cars.date_vipusk < 1941 " +
                "GROUP BY surname_mech, name_mech, middlename_mech " +
                "ORDER BY COUNT(*) DESC " +
                "LIMIT 1;";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ReqestsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ReqestsOneButton_MouseEnter(object sender, EventArgs e)
        {
            ReqestsOneButton.BackColor = Color.LightBlue;
        }

        private void ReqestsOneButton_MouseLeave(object sender, EventArgs e)
        {
            ReqestsOneButton.BackColor = Color.Transparent;
        }

        private void ReqetstTwoButton_Click(object sender, EventArgs e)
        {
            ReqetstTwoButton.BackColor = Color.Blue;

            ReqestsTable.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db");
            string query = "SELECT * " +
                "FROM NaryadRepair " +
                "JOIN Cars ON NaryadRepair.id_car = Cars.id_car " +
                "WHERE Cars.model_car = 'Mercedec 600' " +
                "AND NaryadRepair.realdate_end > NaryadRepair.planedate_end;";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ReqestsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ReqetstTwoButton_MouseEnter(object sender, EventArgs e)
        {
            ReqetstTwoButton.BackColor = Color.LightBlue;
        }

        private void ReqetstTwoButton_MouseLeave(object sender, EventArgs e)
        {
            ReqetstTwoButton.BackColor = Color.Transparent;
        }

        private void ReqestsThreeButton_Click(object sender, EventArgs e)
        {
            ReqestsThreeButton.BackColor = Color.Blue;

            ReqestsTable.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db");
            string query = "SELECT M.surname_mech, Cl.surname_client, COUNT(NR.id_naryad) as visits " +
                "FROM Mechanicks M " +
                "JOIN NaryadRepair NR ON M.id_mech = NR.id_mech " +
                "JOIN Clients Cl ON NR.id_client = Cl.id_client " +
                "GROUP BY M.surname_mech, Cl.surname_client " +
                "HAVING COUNT(DISTINCT M.id_mech) = 1 AND COUNT(NR.id_naryad) > 1;";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ReqestsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ReqestsThreeButton_MouseEnter(object sender, EventArgs e)
        {
            ReqestsThreeButton.BackColor = Color.LightBlue;
        }

        private void ReqestsThreeButton_MouseLeave(object sender, EventArgs e)
        {
            ReqestsThreeButton.BackColor = Color.Transparent;
        }

        private void ReqestsFourButton_Click(object sender, EventArgs e)
        {
            ReqestsFourButton.BackColor = Color.Blue;

            ReqestsTable.Visible = true;
            SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db");
            string query = "WITH CategorizedQualifications AS (" +
                "SELECT " +
                "NR.category_rabota, " +
                "M.cvalification,  " +
                "COUNT(*) as frequency, " +
                "ROW_NUMBER() OVER( " +
                "PARTITION BY NR.category_rabota " +
                "ORDER BY COUNT(*) DESC " +
                ") as rank " +
                "FROM " +
                "NaryadRepair NR " +
                "JOIN " +
                "Mechanicks M ON NR.id_mech = M.id_mech " +
                "GROUP BY " +
                "NR.category_rabota, " +
                "M.cvalification " +
                ") " +
                "SELECT " +
                "category_rabota, " +
                "cvalification " +
                "FROM " +
                "CategorizedQualifications " +
                "WHERE " +
                "rank = 1;";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();

            try
            {
                SQLiteDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ReqestsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ReqestsFourButton_MouseEnter(object sender, EventArgs e)
        {
            ReqestsFourButton.BackColor = Color.LightBlue;
        }

        private void ReqestsFourButton_MouseLeave(object sender, EventArgs e)
        {
            ReqestsFourButton.BackColor = Color.Transparent;
        }

        private void BackReqestsButton_Click(object sender, EventArgs e)
        {
            BackReqestsButton.BackColor = Color.Blue;

            DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуться назад", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Tables Tables = new Tables();
                Tables.Show();
                Hide();
            }
        }

        private void BackReqestsButton_MouseEnter(object sender, EventArgs e)
        {
            BackReqestsButton.BackColor = Color.LightBlue;
        }

        private void BackReqestsButton_MouseLeave(object sender, EventArgs e)
        {
            BackReqestsButton.BackColor = Color.Transparent;
        }

        private void ReqestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdjustTableSize();
        }

        private void AdjustTableSize()
        {
            int totalColumnsWidth = 0;
            foreach (DataGridViewColumn column in ReqestsTable.Columns)
            {
                totalColumnsWidth += column.Width;
            }

            int headerHeight = ReqestsTable.ColumnHeadersHeight;

            int totalHeight = headerHeight;
            if (ReqestsTable.Rows.Count > 0)
            {
                int rowHeight = ReqestsTable.Rows[0].Height; 
                totalHeight += (rowHeight * ReqestsTable.Rows.Count);
            }

            ReqestsTable.Size = new Size(totalColumnsWidth, totalHeight);
        }
    }
}
