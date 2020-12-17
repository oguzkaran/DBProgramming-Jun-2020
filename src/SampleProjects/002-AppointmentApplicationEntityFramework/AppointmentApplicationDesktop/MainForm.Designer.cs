namespace AppointmentApplicationDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_buttonNewClient = new System.Windows.Forms.Button();
            this.m_buttonClientsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_buttonNewClient
            // 
            this.m_buttonNewClient.Location = new System.Drawing.Point(66, 59);
            this.m_buttonNewClient.Name = "m_buttonNewClient";
            this.m_buttonNewClient.Size = new System.Drawing.Size(151, 23);
            this.m_buttonNewClient.TabIndex = 0;
            this.m_buttonNewClient.Text = "Yeni Müşteri";
            this.m_buttonNewClient.UseVisualStyleBackColor = true;
            this.m_buttonNewClient.Click += new System.EventHandler(this.m_buttonNewClient_Click);
            // 
            // m_buttonClientsList
            // 
            this.m_buttonClientsList.Location = new System.Drawing.Point(66, 108);
            this.m_buttonClientsList.Name = "m_buttonClientsList";
            this.m_buttonClientsList.Size = new System.Drawing.Size(151, 23);
            this.m_buttonClientsList.TabIndex = 0;
            this.m_buttonClientsList.Text = "Tüm Müşteriler";
            this.m_buttonClientsList.UseVisualStyleBackColor = true;
            this.m_buttonClientsList.Click += new System.EventHandler(this.m_buttonClientsList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 248);
            this.Controls.Add(this.m_buttonClientsList);
            this.Controls.Add(this.m_buttonNewClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dişçi Randevu Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonNewClient;
        private System.Windows.Forms.Button m_buttonClientsList;
    }
}

