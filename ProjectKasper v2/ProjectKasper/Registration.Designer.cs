namespace ProjectKasper
{
    partial class Registration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.AutorizationButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PassVisibleButton = new System.Windows.Forms.Button();
            this.RollUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(105, 142);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(197, 20);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "Логин";
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(105, 189);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(197, 20);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.Text = "Пароль";
            this.PassTextBox.Click += new System.EventHandler(this.PassTextBox_Click);
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            this.PassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTextBox_KeyPress);
            // 
            // AutorizationButton
            // 
            this.AutorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.AutorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AutorizationButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AutorizationButton.Location = new System.Drawing.Point(135, 237);
            this.AutorizationButton.Name = "AutorizationButton";
            this.AutorizationButton.Size = new System.Drawing.Size(135, 41);
            this.AutorizationButton.TabIndex = 2;
            this.AutorizationButton.Text = "Авторизация";
            this.AutorizationButton.UseVisualStyleBackColor = false;
            this.AutorizationButton.Click += new System.EventHandler(this.AutorizationButton_Click);
            this.AutorizationButton.MouseEnter += new System.EventHandler(this.AutorizationButton_MouseEnter);
            this.AutorizationButton.MouseLeave += new System.EventHandler(this.AutorizationButton_MouseLeave);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.RegistrationButton.Location = new System.Drawing.Point(135, 301);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(135, 45);
            this.RegistrationButton.TabIndex = 3;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            this.RegistrationButton.MouseEnter += new System.EventHandler(this.RegistrationButton_MouseEnter);
            this.RegistrationButton.MouseLeave += new System.EventHandler(this.RegistrationButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::ProjectKasper.Properties.Resources.Exit;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(740, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(32, 31);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // PassVisibleButton
            // 
            this.PassVisibleButton.BackColor = System.Drawing.Color.Transparent;
            this.PassVisibleButton.BackgroundImage = global::ProjectKasper.Properties.Resources.PassVisibleButton;
            this.PassVisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassVisibleButton.Location = new System.Drawing.Point(308, 183);
            this.PassVisibleButton.Name = "PassVisibleButton";
            this.PassVisibleButton.Size = new System.Drawing.Size(32, 30);
            this.PassVisibleButton.TabIndex = 5;
            this.PassVisibleButton.UseVisualStyleBackColor = false;
            this.PassVisibleButton.Click += new System.EventHandler(this.PassVisibleButton_Click);
            this.PassVisibleButton.MouseEnter += new System.EventHandler(this.PassVisibleButton_MouseEnter);
            this.PassVisibleButton.MouseLeave += new System.EventHandler(this.PassVisibleButton_MouseLeave);
            // 
            // RollUp
            // 
            this.RollUp.BackColor = System.Drawing.Color.Transparent;
            this.RollUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RollUp.BackgroundImage")));
            this.RollUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RollUp.Location = new System.Drawing.Point(671, 20);
            this.RollUp.Name = "RollUp";
            this.RollUp.Size = new System.Drawing.Size(48, 14);
            this.RollUp.TabIndex = 6;
            this.RollUp.UseVisualStyleBackColor = false;
            this.RollUp.Click += new System.EventHandler(this.RollUp_Click);
            this.RollUp.MouseEnter += new System.EventHandler(this.RollUp_MouseEnter);
            this.RollUp.MouseLeave += new System.EventHandler(this.RollUp_MouseLeave);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectKasper.Properties.Resources.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RollUp);
            this.Controls.Add(this.PassVisibleButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AutorizationButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Click += new System.EventHandler(this.Registration_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button AutorizationButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PassVisibleButton;
        private System.Windows.Forms.Button RollUp;
    }
}

