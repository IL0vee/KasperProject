using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectStart
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        private int button1ClickCount = 0; // Счетчик кликов по button1

        public Form1()
        {
            InitializeComponent();
            // Подписка на события
            textBox1.MouseEnter += TextBox_MouseEnter;
            textBox2.MouseEnter += TextBox_MouseEnter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1ClickCount++; // Увеличиваем счетчик кликов
            UpdateBackgroundColor(); // Изменяем цвет фона формы

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Не верные данные", "Error");
            }
            else if (textBox1.Text.Trim() == "ILove" && textBox2.Text.Trim() == "ILove")
            {
                MessageBox.Show("Вы авторизовались", "Authorization successful");
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show($"Кнопка нажата {button1ClickCount} раз(а)", "Информация");
            }
        }

        private void UpdateBackgroundColor()
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Yellow;
            button1.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Yellow;
            button2.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;
            button2.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.Yellow;
            textBox1.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            textBox2.ForeColor = Color.Yellow;
            textBox2.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = SystemColors.Control;
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Yellow;
            button3.Font = new Font(button1.Font, FontStyle.Bold | FontStyle.Italic);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;
            button3.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВЫ офециально пошли нахйу");

        }
    }
}
