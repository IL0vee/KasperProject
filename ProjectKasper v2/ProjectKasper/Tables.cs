using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectKasper
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            SetupForm();

        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            TableCars.Visible = false;
            ClientsTable.Visible = false;
            MechanicksTable.Visible = false;
            StoTable.Visible = false;
            NaryadRepairTable.Visible = false;
        }

        private void ExitButtonTables_Click(object sender, EventArgs e)
        {
            ExitButtonTables.BackColor = Color.Blue;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 

            }
        }

        private void ExitTablesButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButtonTables.BackColor = Color.LightBlue;
        }

        private void ExitTablesButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButtonTables.BackColor = Color.Transparent;
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

        private void ExitAccount_Click(object sender, EventArgs e)
        {
            ExitAccount.BackColor = Color.Blue;

            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Registration Registration = new Registration();
                Registration.Show();
                Hide();
            }
        }

        private void TableCarsButton_Click(object sender, EventArgs e)
        {
            TableCarsButton.BackColor = Color.Blue;
            TableCars.Visible = true;
            ClientsTable.Visible = false;
            MechanicksTable.Visible = false;
            StoTable.Visible = false;
            NaryadRepairTable.Visible = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Cars", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        TableCars.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableCarsButton_MouseEnter(object sender, EventArgs e)
        {
            TableCarsButton.BackColor = Color.LightBlue;
        }

        private void TableCarsButton_MouseLeave(object sender, EventArgs e)
        {
            TableCarsButton.BackColor = Color.Transparent;
        }

        private void TableClientsButton_Click(object sender, EventArgs e)
        {
            TableClientsButton.BackColor = Color.Blue;
            TableCars.Visible = false;
            ClientsTable.Visible = true;
            MechanicksTable.Visible = false;
            StoTable.Visible = false;
            NaryadRepairTable.Visible = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Clients", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        ClientsTable.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableClientsButton_MouseEnter(object sender, EventArgs e)
        {
            TableClientsButton.BackColor = Color.LightBlue;
        }

        private void TableClientsButton_MouseLeave(object sender, EventArgs e)
        {
            TableClientsButton.BackColor = Color.Transparent;
        }

        private void ExitAccount_MouseEnter(object sender, EventArgs e)
        {
            ExitAccount.BackColor = Color.LightBlue;
        }

        private void ExitAccount_MouseLeave(object sender, EventArgs e)
        {
            ExitAccount.BackColor = Color.Transparent;
        }

        private void TableMechanicksButton_Click(object sender, EventArgs e)
        {
            TableMechanicksButton.BackColor = Color.Blue;
            TableCars.Visible = false;
            ClientsTable.Visible = false;
            MechanicksTable.Visible = true;
            StoTable.Visible = false;
            NaryadRepairTable.Visible = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
                {
                    conn.Open();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM Mechanicks", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MechanicksTable.DataSource = dt;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableMechanicksButton_MouseEnter(object sender, EventArgs e)
        {
            TableMechanicksButton.BackColor = Color.LightBlue;
        }

        private void TableMechanicksButton_MouseLeave(object sender, EventArgs e)
        {
            TableMechanicksButton.BackColor = Color.Transparent;
        }

        private void StoTableButton_Click(object sender, EventArgs e)
        {
            StoTableButton.BackColor = Color.Blue;
            TableCars.Visible = false;
            ClientsTable.Visible = false;
            MechanicksTable.Visible = false;
            StoTable.Visible = true;
            NaryadRepairTable.Visible = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM STO", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        StoTable.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StoTableButton_MouseEnter(object sender, EventArgs e)
        {
            StoTableButton.BackColor = Color.LightBlue;
        }

        private void StoTableButton_MouseLeave(object sender, EventArgs e)
        {
            StoTableButton.BackColor = Color.Transparent;
        }

        private void NaryadRepairTableButton_Click(object sender, EventArgs e)
        {
            NaryadRepairTableButton.BackColor = Color.Blue;
            TableCars.Visible = false;
            ClientsTable.Visible = false;
            MechanicksTable.Visible = false;
            StoTable.Visible = false;
            NaryadRepairTable.Visible = true;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
                {
                    conn.Open();
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM NaryadRepair", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        NaryadRepairTable.DataSource = dt;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NaryadRepairTableButton_MouseEnter(object sender, EventArgs e)
        {
            NaryadRepairTableButton.BackColor = Color.LightBlue;
        }

        private void NaryadRepairTableButton_MouseLeave(object sender, EventArgs e)
        {
            NaryadRepairTableButton.BackColor = Color.Transparent;
        }

        private void RequestsButton_Click(object sender, EventArgs e)
        {
            RequestsButton.BackColor = Color.Blue;
            Requests Requests = new Requests();
            Requests.Show();
            Hide();
        }

        private void RequestsButton_MouseEnter(object sender, EventArgs e)
        {
            RequestsButton.BackColor = Color.LightBlue;
        }

        private void RequestsButton_MouseLeave(object sender, EventArgs e)
        {
            RequestsButton.BackColor = Color.Transparent;
        }
    }
}
