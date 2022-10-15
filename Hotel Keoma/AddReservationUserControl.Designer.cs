namespace Hotel_Keoma
{
    partial class AddReservationUserControl
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
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.DateOutLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Booking = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DateInPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateOutPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PhoneNumberTexBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NationalPrefixLabel = new System.Windows.Forms.Label();
            this.RoomNumberComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ResetFieldsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BookBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLabel.Location = new System.Drawing.Point(45, 155);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(151, 20);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Nome do Cliente :";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeLabel.Location = new System.Drawing.Point(58, 222);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(138, 20);
            this.RoomTypeLabel.TabIndex = 0;
            this.RoomTypeLabel.Text = "Tipo de Quarto :";
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberLabel.Location = new System.Drawing.Point(39, 282);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(166, 20);
            this.RoomNumberLabel.TabIndex = 0;
            this.RoomNumberLabel.Text = "Número do Quarto :";
            // 
            // DateInLabel
            // 
            this.DateInLabel.AutoSize = true;
            this.DateInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInLabel.Location = new System.Drawing.Point(521, 222);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(140, 20);
            this.DateInLabel.TabIndex = 0;
            this.DateInLabel.Text = "Dia de Entrada :";
            // 
            // DateOutLabel
            // 
            this.DateOutLabel.AutoSize = true;
            this.DateOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOutLabel.Location = new System.Drawing.Point(539, 282);
            this.DateOutLabel.Name = "DateOutLabel";
            this.DateOutLabel.Size = new System.Drawing.Size(122, 20);
            this.DateOutLabel.TabIndex = 0;
            this.DateOutLabel.Text = "Dia de Saída :";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientNameTextBox.DefaultText = "";
            this.ClientNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.ClientNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientNameTextBox.Location = new System.Drawing.Point(211, 145);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.PasswordChar = '\0';
            this.ClientNameTextBox.PlaceholderText = "";
            this.ClientNameTextBox.SelectedText = "";
            this.ClientNameTextBox.Size = new System.Drawing.Size(200, 42);
            this.ClientNameTextBox.TabIndex = 1;
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.RoomTypeComboBox.ItemHeight = 36;
            this.RoomTypeComboBox.Items.AddRange(new object[] {
            "Solteiro",
            "Duplo Solteiro",
            "Casal",
            "Master",
            "Deluxe"});
            this.RoomTypeComboBox.Location = new System.Drawing.Point(211, 214);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.Size = new System.Drawing.Size(200, 42);
            this.RoomTypeComboBox.TabIndex = 2;
            // 
            // Booking
            // 
            this.Booking.AutoSize = true;
            this.Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Booking.Location = new System.Drawing.Point(373, 24);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(152, 29);
            this.Booking.TabIndex = 0;
            this.Booking.Text = "ADICIONAR";
            this.Booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(535, 155);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(89, 20);
            this.PhoneNumberLabel.TabIndex = 0;
            this.PhoneNumberLabel.Text = "Telefone :";
            // 
            // DateInPicker
            // 
            this.DateInPicker.Checked = true;
            this.DateInPicker.FillColor = System.Drawing.Color.White;
            this.DateInPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInPicker.Location = new System.Drawing.Point(678, 214);
            this.DateInPicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.DateInPicker.MinDate = new System.DateTime(2022, 10, 13, 0, 0, 0, 0);
            this.DateInPicker.Name = "DateInPicker";
            this.DateInPicker.Size = new System.Drawing.Size(200, 36);
            this.DateInPicker.TabIndex = 3;
            this.DateInPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateInPicker.Value = new System.DateTime(2022, 10, 13, 11, 17, 56, 806);
            // 
            // DateOutPicker
            // 
            this.DateOutPicker.Checked = true;
            this.DateOutPicker.FillColor = System.Drawing.Color.White;
            this.DateOutPicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOutPicker.Location = new System.Drawing.Point(678, 275);
            this.DateOutPicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.DateOutPicker.MinDate = new System.DateTime(2022, 10, 13, 0, 0, 0, 0);
            this.DateOutPicker.Name = "DateOutPicker";
            this.DateOutPicker.Size = new System.Drawing.Size(200, 36);
            this.DateOutPicker.TabIndex = 3;
            this.DateOutPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOutPicker.Value = new System.DateTime(2022, 10, 13, 11, 20, 23, 0);
            // 
            // PhoneNumberTexBox
            // 
            this.PhoneNumberTexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTexBox.DefaultText = "";
            this.PhoneNumberTexBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTexBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTexBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTexBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTexBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTexBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTexBox.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberTexBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTexBox.Location = new System.Drawing.Point(678, 145);
            this.PhoneNumberTexBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumberTexBox.MaxLength = 9;
            this.PhoneNumberTexBox.Name = "PhoneNumberTexBox";
            this.PhoneNumberTexBox.PasswordChar = '\0';
            this.PhoneNumberTexBox.PlaceholderText = "";
            this.PhoneNumberTexBox.SelectedText = "";
            this.PhoneNumberTexBox.Size = new System.Drawing.Size(200, 42);
            this.PhoneNumberTexBox.TabIndex = 4;
            this.PhoneNumberTexBox.WordWrap = false;
            // 
            // NationalPrefixLabel
            // 
            this.NationalPrefixLabel.AutoSize = true;
            this.NationalPrefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalPrefixLabel.Location = new System.Drawing.Point(623, 155);
            this.NationalPrefixLabel.Name = "NationalPrefixLabel";
            this.NationalPrefixLabel.Size = new System.Drawing.Size(55, 20);
            this.NationalPrefixLabel.TabIndex = 0;
            this.NationalPrefixLabel.Text = "(+258)";
            // 
            // RoomNumberComboBox
            // 
            this.RoomNumberComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomNumberComboBox.DropDownHeight = 150;
            this.RoomNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNumberComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumberComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumberComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberComboBox.ForeColor = System.Drawing.Color.Black;
            this.RoomNumberComboBox.IntegralHeight = false;
            this.RoomNumberComboBox.ItemHeight = 36;
            this.RoomNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.RoomNumberComboBox.Location = new System.Drawing.Point(211, 275);
            this.RoomNumberComboBox.MaxDropDownItems = 10;
            this.RoomNumberComboBox.Name = "RoomNumberComboBox";
            this.RoomNumberComboBox.Size = new System.Drawing.Size(200, 42);
            this.RoomNumberComboBox.TabIndex = 2;
            // 
            // ResetFieldsBtn
            // 
            this.ResetFieldsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetFieldsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetFieldsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetFieldsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetFieldsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFieldsBtn.ForeColor = System.Drawing.Color.White;
            this.ResetFieldsBtn.Location = new System.Drawing.Point(525, 390);
            this.ResetFieldsBtn.Name = "ResetFieldsBtn";
            this.ResetFieldsBtn.Size = new System.Drawing.Size(180, 45);
            this.ResetFieldsBtn.TabIndex = 9;
            this.ResetFieldsBtn.Text = "Limpar";
            this.ResetFieldsBtn.Click += new System.EventHandler(this.ResetFieldsBtn_Click);
            // 
            // BookBtn
            // 
            this.BookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(231, 390);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(180, 45);
            this.BookBtn.TabIndex = 9;
            this.BookBtn.Text = "Rerservar";
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // AddReservationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.ResetFieldsBtn);
            this.Controls.Add(this.PhoneNumberTexBox);
            this.Controls.Add(this.DateOutPicker);
            this.Controls.Add(this.DateInPicker);
            this.Controls.Add(this.RoomNumberComboBox);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.DateOutLabel);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.NationalPrefixLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.DateInLabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.RoomTypeLabel);
            this.Controls.Add(this.ClientNameLabel);
            this.Name = "AddReservationUserControl";
            this.Size = new System.Drawing.Size(925, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label RoomTypeLabel;
        private System.Windows.Forms.Label RoomNumberLabel;
        private System.Windows.Forms.Label DateInLabel;
        private System.Windows.Forms.Label DateOutLabel;
        private Guna.UI2.WinForms.Guna2TextBox ClientNameTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeComboBox;
        private System.Windows.Forms.Label Booking;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateInPicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOutPicker;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTexBox;
        private System.Windows.Forms.Label NationalPrefixLabel;
        private Guna.UI2.WinForms.Guna2ComboBox RoomNumberComboBox;
        private Guna.UI2.WinForms.Guna2Button ResetFieldsBtn;
        private Guna.UI2.WinForms.Guna2Button BookBtn;
    }
}
