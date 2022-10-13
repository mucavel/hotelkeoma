namespace Hotel_Keoma
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.BtnsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BookingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddReservationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HotelManagementSystemLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BookingUserControl = new Hotel_Keoma.BookingUserControl();
            this.AddReservationUserControl = new Hotel_Keoma.AddReservationUserControl();
            this.SuspendLayout();
            // 
            // BtnsLabel
            // 
            this.BtnsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BtnsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnsLabel.Location = new System.Drawing.Point(0, 0);
            this.BtnsLabel.Name = "BtnsLabel";
            this.BtnsLabel.Size = new System.Drawing.Size(246, 711);
            this.BtnsLabel.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DateLabel.Location = new System.Drawing.Point(240, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(943, 73);
            this.DateLabel.TabIndex = 1;
            // 
            // BookingsBtn
            // 
            this.BookingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingsBtn.FillColor = System.Drawing.Color.White;
            this.BookingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.BookingsBtn.Location = new System.Drawing.Point(-3, 168);
            this.BookingsBtn.Name = "BookingsBtn";
            this.BookingsBtn.Size = new System.Drawing.Size(249, 65);
            this.BookingsBtn.TabIndex = 3;
            this.BookingsBtn.Text = "RESERVAS";
            this.BookingsBtn.Click += new System.EventHandler(this.BookingsBtn_Click);
            // 
            // AddReservationBtn
            // 
            this.AddReservationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddReservationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddReservationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddReservationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddReservationBtn.FillColor = System.Drawing.Color.White;
            this.AddReservationBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReservationBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.AddReservationBtn.Location = new System.Drawing.Point(-3, 248);
            this.AddReservationBtn.Name = "AddReservationBtn";
            this.AddReservationBtn.Size = new System.Drawing.Size(249, 65);
            this.AddReservationBtn.TabIndex = 3;
            this.AddReservationBtn.Text = "ADICIONAR";
            this.AddReservationBtn.Click += new System.EventHandler(this.AddReservationBtn_Click);
            // 
            // HotelManagementSystemLabel
            // 
            this.HotelManagementSystemLabel.AutoSize = true;
            this.HotelManagementSystemLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HotelManagementSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelManagementSystemLabel.ForeColor = System.Drawing.Color.White;
            this.HotelManagementSystemLabel.Location = new System.Drawing.Point(514, 20);
            this.HotelManagementSystemLabel.Name = "HotelManagementSystemLabel";
            this.HotelManagementSystemLabel.Size = new System.Drawing.Size(348, 29);
            this.HotelManagementSystemLabel.TabIndex = 4;
            this.HotelManagementSystemLabel.Text = "Sistema de Gestão Hoteleira";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 131);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desenvolvedor : Salvador Carlos Mucavele @ 2022";
            // 
            // BookingUserControl
            // 
            this.BookingUserControl.BackColor = System.Drawing.Color.White;
            this.BookingUserControl.Location = new System.Drawing.Point(252, 74);
            this.BookingUserControl.Name = "BookingUserControl";
            this.BookingUserControl.Size = new System.Drawing.Size(925, 600);
            this.BookingUserControl.TabIndex = 9;
            // 
            // AddReservationUserControl
            // 
            this.AddReservationUserControl.BackColor = System.Drawing.Color.White;
            this.AddReservationUserControl.Location = new System.Drawing.Point(252, 76);
            this.AddReservationUserControl.Name = "AddReservationUserControl";
            this.AddReservationUserControl.Size = new System.Drawing.Size(925, 600);
            this.AddReservationUserControl.TabIndex = 8;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 711);
            this.Controls.Add(this.BookingUserControl);
            this.Controls.Add(this.AddReservationUserControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HotelManagementSystemLabel);
            this.Controls.Add(this.AddReservationBtn);
            this.Controls.Add(this.BookingsBtn);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.BtnsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel  Keoma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnsLabel;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2Button BookingsBtn;
        private Guna.UI2.WinForms.Guna2Button AddReservationBtn;
        private System.Windows.Forms.Label HotelManagementSystemLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AddReservationUserControl AddReservationUserControl;
        private BookingUserControl BookingUserControl;
    }
}