namespace ProjectKasper
{
    partial class Requests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.ExitRequestsButton = new System.Windows.Forms.Button();
            this.RollUp = new System.Windows.Forms.Button();
            this.ReqestsTable = new System.Windows.Forms.DataGridView();
            this.ReqestsOneButton = new System.Windows.Forms.Button();
            this.ReqetstTwoButton = new System.Windows.Forms.Button();
            this.ReqestsThreeButton = new System.Windows.Forms.Button();
            this.ReqestsFourButton = new System.Windows.Forms.Button();
            this.BackReqestsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReqestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitRequestsButton
            // 
            this.ExitRequestsButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitRequestsButton.BackgroundImage = global::ProjectKasper.Properties.Resources.Exit;
            this.ExitRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitRequestsButton.Location = new System.Drawing.Point(757, 13);
            this.ExitRequestsButton.Name = "ExitRequestsButton";
            this.ExitRequestsButton.Size = new System.Drawing.Size(31, 34);
            this.ExitRequestsButton.TabIndex = 0;
            this.ExitRequestsButton.UseVisualStyleBackColor = false;
            this.ExitRequestsButton.Click += new System.EventHandler(this.ExitRequestsButton_Click);
            this.ExitRequestsButton.MouseEnter += new System.EventHandler(this.ExitRequestsButton_MouseEnter);
            this.ExitRequestsButton.MouseLeave += new System.EventHandler(this.ExitRequestsButton_MouseLeave);
            // 
            // RollUp
            // 
            this.RollUp.BackColor = System.Drawing.Color.Transparent;
            this.RollUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RollUp.BackgroundImage")));
            this.RollUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RollUp.Location = new System.Drawing.Point(691, 23);
            this.RollUp.Name = "RollUp";
            this.RollUp.Size = new System.Drawing.Size(48, 14);
            this.RollUp.TabIndex = 8;
            this.RollUp.UseVisualStyleBackColor = false;
            this.RollUp.Click += new System.EventHandler(this.RollUp_Click);
            this.RollUp.MouseEnter += new System.EventHandler(this.RollUp_MouseEnter);
            this.RollUp.MouseLeave += new System.EventHandler(this.RollUp_MouseLeave);
            // 
            // ReqestsTable
            // 
            this.ReqestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReqestsTable.Location = new System.Drawing.Point(359, 72);
            this.ReqestsTable.Name = "ReqestsTable";
            this.ReqestsTable.Size = new System.Drawing.Size(429, 68);
            this.ReqestsTable.TabIndex = 9;
            this.ReqestsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReqestsTable_CellContentClick);
            // 
            // ReqestsOneButton
            // 
            this.ReqestsOneButton.BackColor = System.Drawing.Color.Transparent;
            this.ReqestsOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReqestsOneButton.ForeColor = System.Drawing.Color.Gold;
            this.ReqestsOneButton.Location = new System.Drawing.Point(119, 72);
            this.ReqestsOneButton.Name = "ReqestsOneButton";
            this.ReqestsOneButton.Size = new System.Drawing.Size(175, 44);
            this.ReqestsOneButton.TabIndex = 10;
            this.ReqestsOneButton.Text = "Запрос \"Довоенные авто\"";
            this.ReqestsOneButton.UseVisualStyleBackColor = false;
            this.ReqestsOneButton.Click += new System.EventHandler(this.ReqestsOneButton_Click);
            this.ReqestsOneButton.MouseEnter += new System.EventHandler(this.ReqestsOneButton_MouseEnter);
            this.ReqestsOneButton.MouseLeave += new System.EventHandler(this.ReqestsOneButton_MouseLeave);
            // 
            // ReqetstTwoButton
            // 
            this.ReqetstTwoButton.BackColor = System.Drawing.Color.Transparent;
            this.ReqetstTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReqetstTwoButton.ForeColor = System.Drawing.Color.Gold;
            this.ReqetstTwoButton.Location = new System.Drawing.Point(119, 174);
            this.ReqetstTwoButton.Name = "ReqetstTwoButton";
            this.ReqetstTwoButton.Size = new System.Drawing.Size(175, 44);
            this.ReqetstTwoButton.TabIndex = 11;
            this.ReqetstTwoButton.Text = "Запрос \"Ремонт задержался\"";
            this.ReqetstTwoButton.UseVisualStyleBackColor = false;
            this.ReqetstTwoButton.Click += new System.EventHandler(this.ReqetstTwoButton_Click);
            this.ReqetstTwoButton.MouseEnter += new System.EventHandler(this.ReqetstTwoButton_MouseEnter);
            this.ReqetstTwoButton.MouseLeave += new System.EventHandler(this.ReqetstTwoButton_MouseLeave);
            // 
            // ReqestsThreeButton
            // 
            this.ReqestsThreeButton.BackColor = System.Drawing.Color.Transparent;
            this.ReqestsThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReqestsThreeButton.ForeColor = System.Drawing.Color.Gold;
            this.ReqestsThreeButton.Location = new System.Drawing.Point(119, 275);
            this.ReqestsThreeButton.Name = "ReqestsThreeButton";
            this.ReqestsThreeButton.Size = new System.Drawing.Size(175, 44);
            this.ReqestsThreeButton.TabIndex = 12;
            this.ReqestsThreeButton.Text = "Запрос \"Постоянный клиент\"";
            this.ReqestsThreeButton.UseVisualStyleBackColor = false;
            this.ReqestsThreeButton.Click += new System.EventHandler(this.ReqestsThreeButton_Click);
            this.ReqestsThreeButton.MouseEnter += new System.EventHandler(this.ReqestsThreeButton_MouseEnter);
            this.ReqestsThreeButton.MouseLeave += new System.EventHandler(this.ReqestsThreeButton_MouseLeave);
            // 
            // ReqestsFourButton
            // 
            this.ReqestsFourButton.BackColor = System.Drawing.Color.Transparent;
            this.ReqestsFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReqestsFourButton.ForeColor = System.Drawing.Color.Gold;
            this.ReqestsFourButton.Location = new System.Drawing.Point(119, 375);
            this.ReqestsFourButton.Name = "ReqestsFourButton";
            this.ReqestsFourButton.Size = new System.Drawing.Size(175, 44);
            this.ReqestsFourButton.TabIndex = 13;
            this.ReqestsFourButton.Text = "Запрос \"Работа по разряду\"";
            this.ReqestsFourButton.UseVisualStyleBackColor = false;
            this.ReqestsFourButton.Click += new System.EventHandler(this.ReqestsFourButton_Click);
            this.ReqestsFourButton.MouseEnter += new System.EventHandler(this.ReqestsFourButton_MouseEnter);
            this.ReqestsFourButton.MouseLeave += new System.EventHandler(this.ReqestsFourButton_MouseLeave);
            // 
            // BackReqestsButton
            // 
            this.BackReqestsButton.BackColor = System.Drawing.Color.Transparent;
            this.BackReqestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackReqestsButton.ForeColor = System.Drawing.Color.Gold;
            this.BackReqestsButton.Location = new System.Drawing.Point(119, 520);
            this.BackReqestsButton.Name = "BackReqestsButton";
            this.BackReqestsButton.Size = new System.Drawing.Size(175, 44);
            this.BackReqestsButton.TabIndex = 14;
            this.BackReqestsButton.Text = "<----------------";
            this.BackReqestsButton.UseVisualStyleBackColor = false;
            this.BackReqestsButton.Click += new System.EventHandler(this.BackReqestsButton_Click);
            this.BackReqestsButton.MouseEnter += new System.EventHandler(this.BackReqestsButton_MouseEnter);
            this.BackReqestsButton.MouseLeave += new System.EventHandler(this.BackReqestsButton_MouseLeave);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectKasper.Properties.Resources.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BackReqestsButton);
            this.Controls.Add(this.ReqestsFourButton);
            this.Controls.Add(this.ReqestsThreeButton);
            this.Controls.Add(this.ReqetstTwoButton);
            this.Controls.Add(this.ReqestsOneButton);
            this.Controls.Add(this.ReqestsTable);
            this.Controls.Add(this.RollUp);
            this.Controls.Add(this.ExitRequestsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Requests";
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReqestsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitRequestsButton;
        private System.Windows.Forms.Button RollUp;
        private System.Windows.Forms.DataGridView ReqestsTable;
        private System.Windows.Forms.Button ReqestsOneButton;
        private System.Windows.Forms.Button ReqetstTwoButton;
        private System.Windows.Forms.Button ReqestsThreeButton;
        private System.Windows.Forms.Button ReqestsFourButton;
        private System.Windows.Forms.Button BackReqestsButton;
    }
}