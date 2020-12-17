namespace AppointmentApplicationDesktop
{
    partial class AddClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.m_textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_textBoxPhone = new System.Windows.Forms.TextBox();
            this.m_buttonSave = new System.Windows.Forms.Button();
            this.m_buttonCancel = new System.Windows.Forms.Button();
            this.m_buttonClear = new System.Windows.Forms.Button();
            this.m_textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // m_textBoxName
            // 
            this.m_textBoxName.Location = new System.Drawing.Point(151, 53);
            this.m_textBoxName.Name = "m_textBoxName";
            this.m_textBoxName.Size = new System.Drawing.Size(100, 23);
            this.m_textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "E Posta";
            // 
            // m_textBoxEmail
            // 
            this.m_textBoxEmail.Location = new System.Drawing.Point(151, 98);
            this.m_textBoxEmail.Name = "m_textBoxEmail";
            this.m_textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.m_textBoxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // m_textBoxPhone
            // 
            this.m_textBoxPhone.Location = new System.Drawing.Point(151, 147);
            this.m_textBoxPhone.Name = "m_textBoxPhone";
            this.m_textBoxPhone.Size = new System.Drawing.Size(100, 23);
            this.m_textBoxPhone.TabIndex = 3;
            // 
            // m_buttonSave
            // 
            this.m_buttonSave.Location = new System.Drawing.Point(32, 206);
            this.m_buttonSave.Name = "m_buttonSave";
            this.m_buttonSave.Size = new System.Drawing.Size(75, 23);
            this.m_buttonSave.TabIndex = 4;
            this.m_buttonSave.Text = "Kaydet";
            this.m_buttonSave.UseVisualStyleBackColor = true;
            this.m_buttonSave.Click += new System.EventHandler(this.m_buttonSave_Click);
            // 
            // m_buttonCancel
            // 
            this.m_buttonCancel.Location = new System.Drawing.Point(262, 206);
            this.m_buttonCancel.Name = "m_buttonCancel";
            this.m_buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_buttonCancel.TabIndex = 5;
            this.m_buttonCancel.Text = "İptal";
            this.m_buttonCancel.UseVisualStyleBackColor = true;
            this.m_buttonCancel.Click += new System.EventHandler(this.m_buttonCancel_Click);
            // 
            // m_buttonClear
            // 
            this.m_buttonClear.Location = new System.Drawing.Point(156, 205);
            this.m_buttonClear.Name = "m_buttonClear";
            this.m_buttonClear.Size = new System.Drawing.Size(75, 23);
            this.m_buttonClear.TabIndex = 6;
            this.m_buttonClear.Text = "Temizle";
            this.m_buttonClear.UseVisualStyleBackColor = true;
            this.m_buttonClear.Click += new System.EventHandler(this.m_buttonClear_Click);
            // 
            // m_textBoxId
            // 
            this.m_textBoxId.Location = new System.Drawing.Point(151, 24);
            this.m_textBoxId.Name = "m_textBoxId";
            this.m_textBoxId.ReadOnly = true;
            this.m_textBoxId.Size = new System.Drawing.Size(100, 23);
            this.m_textBoxId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "İsim";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 284);
            this.Controls.Add(this.m_textBoxId);
            this.Controls.Add(this.m_buttonClear);
            this.Controls.Add(this.m_buttonCancel);
            this.Controls.Add(this.m_buttonSave);
            this.Controls.Add(this.m_textBoxPhone);
            this.Controls.Add(this.m_textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşteri Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_textBoxPhone;
        private System.Windows.Forms.Button m_buttonSave;
        private System.Windows.Forms.Button m_buttonCancel;
        private System.Windows.Forms.Button m_buttonClear;
        private System.Windows.Forms.TextBox m_textBoxId;
        private System.Windows.Forms.Label label4;
    }
}