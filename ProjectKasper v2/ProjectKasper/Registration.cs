using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace ProjectKasper
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            SetupForm();
            PassTextBox.UseSystemPasswordChar = true;
            LoginTextBox.DoubleClick += LoginTextBox_DoubleClick;
            PassTextBox.DoubleClick += PassTextBox_DoubleClick;
        }

        private void PassTextBox_DoubleClick(object sender, EventArgs e)
        {
            PassTextBox.Clear();
        }

        private void LoginTextBox_DoubleClick(object sender, EventArgs e)
        {
            LoginTextBox.Clear();
        }

        private void SetupForm()
        {
            this.Text = "Регистрация и Авторизация";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Введите логин")
            {
                LoginTextBox.Clear();
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.ForeColor == Color.Red)
            {
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void PassTextBox_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == "Введите пароль")
            {
                PassTextBox.Clear();
                PassTextBox.ForeColor = Color.Black;
                PassTextBox.UseSystemPasswordChar = true; // Start with password hidden
            }
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PassTextBox.ForeColor == Color.Red)
            {
                PassTextBox.ForeColor = Color.Black;
            }
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            AutorizationButton.BackColor = Color.Blue;
            AutorizationButton.Text = "Авторизация";

            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PassTextBox.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
                ResetButton(AutorizationButton);
                return;
            }

            AuthenticateUser(LoginTextBox.Text.Trim(), PassTextBox.Text.Trim());
            ResetButton(AutorizationButton);
        }

        private void AuthenticateUser(string login, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE login=@login AND password=@password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы авторизовались", "Успех авторизации");
                        Tables tablesForm = new Tables();
                        tablesForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации", "Ошибка");
                        LoginTextBox.Clear();
                        PassTextBox.Clear();
                    }
                }
            }
        }

        private void AutorizationButton_MouseEnter(object sender, EventArgs e)
        {
            AutorizationButton.BackColor = Color.LightBlue;
        }

        private void AutorizationButton_MouseLeave(object sender, EventArgs e)
        {
            AutorizationButton.BackColor = Color.Transparent;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationButton.BackColor = Color.Blue;
            string login = LoginTextBox.Text.Trim();
            string password = PassTextBox.Text.Trim();

            if (!IsValidLogin(login))
            {
                MessageBox.Show("Логин может содержать только буквы и не должен начинаться с цифры.", "Ошибка");
                ResetButton(RegistrationButton);
                return;
            }

            if (DoesLoginExist(login))
            {
                MessageBox.Show("Этот логин уже занят, выберите другой", "Ошибка");
                ResetButton(RegistrationButton);
                return;
            }

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
                ResetButton(RegistrationButton);
                return;
            }

            RegisterUser(login, password);
            ResetButton(RegistrationButton);
        }

        private void RegisterUser(string login, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Users (login, password) VALUES (@login, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Регистрация завершена", "Успех регистрации");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Ошибка регистрации: " + ex.Message, "Ошибка");
                    }
                }
            }
        }

        private bool IsValidLogin(string login)
        {
            return !string.IsNullOrEmpty(login) && Regex.IsMatch(login, @"^[a-zA-Z]+$");
        }

        private void ResetButton(Button button)
        {
            button.BackColor = Color.Transparent;
            button.Text = button == AutorizationButton ? "Авторизация" : "Регистрация";
        }

        private void RegistrationButton_MouseEnter(object sender, EventArgs e)
        {
            RegistrationButton.BackColor = Color.LightBlue;
        }

        private void RegistrationButton_MouseLeave(object sender, EventArgs e)
        {
            RegistrationButton.BackColor = Color.Transparent;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Blue;
            ExitButton.BackColor = Color.Blue;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.LightBlue;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Transparent;
        }

        private bool DoesLoginExist(string login)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=ProjectKasper.db"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE login=@login";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Можно вводить только английские буквы.", "Ошибка");
            }
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Можно вводить только английские буквы.", "Ошибка");
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {

        }

        private bool isPasswordVisible = false;

        private void PassVisibleButton_Click(object sender, EventArgs e)
        {
            PassVisibleButton.BackColor = Color.Blue;
            isPasswordVisible = !isPasswordVisible; 

            PassTextBox.UseSystemPasswordChar = !isPasswordVisible; 
        }

        private void PassVisibleButton_MouseEnter(object sender, EventArgs e)
        {
            PassVisibleButton.BackColor = Color.LightBlue;
        }

        private void PassVisibleButton_MouseLeave(object sender, EventArgs e)
        {
            PassVisibleButton.BackColor = Color.Transparent;
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
    }
}