namespace Hotel_Keoma
{
    partial class Hotel_Loader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Loader));
            this.Loader_Wave = new System.Windows.Forms.Label();
            this.LoaderProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Hotel_Label = new System.Windows.Forms.Label();
            this.LoaderTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Loader_Wave
            // 
            this.Loader_Wave.Image = ((System.Drawing.Image)(resources.GetObject("Loader_Wave.Image")));
            this.Loader_Wave.Location = new System.Drawing.Point(-8, 155);
            this.Loader_Wave.Name = "Loader_Wave";
            this.Loader_Wave.Size = new System.Drawing.Size(458, 99);
            this.Loader_Wave.TabIndex = 0;
            // 
            // LoaderProgressBar
            // 
            this.LoaderProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoaderProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoaderProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoaderProgressBar.Location = new System.Drawing.Point(-5, 253);
            this.LoaderProgressBar.Name = "LoaderProgressBar";
            this.LoaderProgressBar.ProgressColor = System.Drawing.Color.White;
            this.LoaderProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.LoaderProgressBar.Size = new System.Drawing.Size(455, 10);
            this.LoaderProgressBar.TabIndex = 1;
            this.LoaderProgressBar.Text = "LoaderProgressBar";
            this.LoaderProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Hotel_Label
            // 
            this.Hotel_Label.AutoSize = true;
            this.Hotel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotel_Label.Location = new System.Drawing.Point(110, 77);
            this.Hotel_Label.Name = "Hotel_Label";
            this.Hotel_Label.Size = new System.Drawing.Size(228, 39);
            this.Hotel_Label.TabIndex = 2;
            this.Hotel_Label.Text = "Hotel Keoma";
            // 
            // LoaderTimer
            // 
            this.LoaderTimer.Tick += new System.EventHandler(this.LoaderTimer_Tick);
            // 
            // Hotel_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 263);
            this.Controls.Add(this.Hotel_Label);
            this.Controls.Add(this.LoaderProgressBar);
            this.Controls.Add(this.Loader_Wave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hotel_Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Keoma";
            this.Load += new System.EventHandler(this.Hotel_Loader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loader_Wave;
        private Guna.UI2.WinForms.Guna2ProgressBar LoaderProgressBar;
        private System.Windows.Forms.Label Hotel_Label;
        private System.Windows.Forms.Timer LoaderTimer;
    }
}