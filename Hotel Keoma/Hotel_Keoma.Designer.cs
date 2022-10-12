namespace Hotel_Keoma
{
    partial class Hotel_Keoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Keoma));
            this.BookingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BookingPanel
            // 
            this.BookingPanel.BackColor = System.Drawing.Color.White;
            this.BookingPanel.Location = new System.Drawing.Point(329, -1);
            this.BookingPanel.Name = "BookingPanel";
            this.BookingPanel.Size = new System.Drawing.Size(600, 526);
            this.BookingPanel.TabIndex = 0;
            // 
            // Hotel_Keoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(941, 555);
            this.Controls.Add(this.BookingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotel_Keoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Keoma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BookingPanel;
    }
}

