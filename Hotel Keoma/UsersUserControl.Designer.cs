namespace Hotel_Keoma
{
    partial class UsersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Users = new System.Windows.Forms.Label();
            this.AddUserTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.AddUserPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UsersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Users.Location = new System.Drawing.Point(379, 19);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(144, 29);
            this.Users.TabIndex = 1;
            this.Users.Text = "USUÁRIOS";
            this.Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUserTextBox
            // 
            this.AddUserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUserTextBox.DefaultText = "";
            this.AddUserTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUserTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUserTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUserTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUserTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUserTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserTextBox.ForeColor = System.Drawing.Color.Black;
            this.AddUserTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUserTextBox.Location = new System.Drawing.Point(210, 124);
            this.AddUserTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUserTextBox.Name = "AddUserTextBox";
            this.AddUserTextBox.PasswordChar = '\0';
            this.AddUserTextBox.PlaceholderText = "";
            this.AddUserTextBox.SelectedText = "";
            this.AddUserTextBox.Size = new System.Drawing.Size(200, 42);
            this.AddUserTextBox.TabIndex = 3;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(122, 134);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(81, 20);
            this.ClientNameLabel.TabIndex = 2;
            this.ClientNameLabel.Text = "Usuário :";
            // 
            // AddUserPassTextBox
            // 
            this.AddUserPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddUserPassTextBox.DefaultText = "";
            this.AddUserPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddUserPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddUserPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUserPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddUserPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUserPassTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserPassTextBox.ForeColor = System.Drawing.Color.Black;
            this.AddUserPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUserPassTextBox.Location = new System.Drawing.Point(583, 124);
            this.AddUserPassTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUserPassTextBox.Name = "AddUserPassTextBox";
            this.AddUserPassTextBox.PasswordChar = '\0';
            this.AddUserPassTextBox.PlaceholderText = "";
            this.AddUserPassTextBox.SelectedText = "";
            this.AddUserPassTextBox.Size = new System.Drawing.Size(200, 42);
            this.AddUserPassTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palavra-Passe :";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.Location = new System.Drawing.Point(210, 200);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(180, 45);
            this.AddUserBtn.TabIndex = 12;
            this.AddUserBtn.Text = "Adicionar";
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.DeleteUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteUserBtn.Location = new System.Drawing.Point(603, 200);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Apagar";
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UsersDataGridView.ColumnHeadersHeight = 30;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UsersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDataGridView.Location = new System.Drawing.Point(0, 275);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.UsersDataGridView.ShowEditingIcon = false;
            this.UsersDataGridView.Size = new System.Drawing.Size(925, 325);
            this.UsersDataGridView.TabIndex = 14;
            this.UsersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UsersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.UsersDataGridView.ThemeStyle.ReadOnly = true;
            this.UsersDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UsersDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.UsersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UsersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetUserID);
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.AddUserPassTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUserTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.Users);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(925, 600);
            this.Load += new System.EventHandler(this.UsersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Users;
        private Guna.UI2.WinForms.Guna2TextBox AddUserTextBox;
        private System.Windows.Forms.Label ClientNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox AddUserPassTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddUserBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteUserBtn;
        private Guna.UI2.WinForms.Guna2DataGridView UsersDataGridView;
    }
}
