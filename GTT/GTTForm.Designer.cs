namespace GTT
{
    partial class GTTForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.source_Host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.source_DBName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.source_Trusted = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.source_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.source_User = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dest_Trusted = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dest_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dest_User = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dest_Host = new System.Windows.Forms.TextBox();
            this.dest_DBName = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.CurrentStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // source_Host
            // 
            this.source_Host.Location = new System.Drawing.Point(68, 17);
            this.source_Host.Name = "source_Host";
            this.source_Host.Size = new System.Drawing.Size(198, 20);
            this.source_Host.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DB Name:";
            // 
            // source_DBName
            // 
            this.source_DBName.Location = new System.Drawing.Point(68, 94);
            this.source_DBName.Name = "source_DBName";
            this.source_DBName.Size = new System.Drawing.Size(198, 20);
            this.source_DBName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.source_Trusted);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.source_Password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.source_User);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.source_Host);
            this.groupBox1.Controls.Add(this.source_DBName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // source_Trusted
            // 
            this.source_Trusted.AutoSize = true;
            this.source_Trusted.Location = new System.Drawing.Point(111, 120);
            this.source_Trusted.Name = "source_Trusted";
            this.source_Trusted.Size = new System.Drawing.Size(155, 17);
            this.source_Trusted.TabIndex = 8;
            this.source_Trusted.Text = "Use Trusted Authentication";
            this.source_Trusted.UseVisualStyleBackColor = true;
            this.source_Trusted.CheckedChanged += new System.EventHandler(this.source_Trusted_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // source_Password
            // 
            this.source_Password.Location = new System.Drawing.Point(68, 67);
            this.source_Password.Name = "source_Password";
            this.source_Password.Size = new System.Drawing.Size(198, 20);
            this.source_Password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // source_User
            // 
            this.source_User.Location = new System.Drawing.Point(68, 43);
            this.source_User.Name = "source_User";
            this.source_User.Size = new System.Drawing.Size(198, 20);
            this.source_User.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dest_Trusted);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dest_Password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dest_User);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dest_Host);
            this.groupBox2.Controls.Add(this.dest_DBName);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // dest_Trusted
            // 
            this.dest_Trusted.AutoSize = true;
            this.dest_Trusted.Location = new System.Drawing.Point(111, 121);
            this.dest_Trusted.Name = "dest_Trusted";
            this.dest_Trusted.Size = new System.Drawing.Size(155, 17);
            this.dest_Trusted.TabIndex = 9;
            this.dest_Trusted.Text = "Use Trusted Authentication";
            this.dest_Trusted.UseVisualStyleBackColor = true;
            this.dest_Trusted.CheckedChanged += new System.EventHandler(this.dest_Trusted_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // dest_Password
            // 
            this.dest_Password.Location = new System.Drawing.Point(68, 67);
            this.dest_Password.Name = "dest_Password";
            this.dest_Password.Size = new System.Drawing.Size(198, 20);
            this.dest_Password.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "User:";
            // 
            // dest_User
            // 
            this.dest_User.Location = new System.Drawing.Point(68, 43);
            this.dest_User.Name = "dest_User";
            this.dest_User.Size = new System.Drawing.Size(198, 20);
            this.dest_User.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Host:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "DB Name:";
            // 
            // dest_Host
            // 
            this.dest_Host.Location = new System.Drawing.Point(68, 17);
            this.dest_Host.Name = "dest_Host";
            this.dest_Host.Size = new System.Drawing.Size(198, 20);
            this.dest_Host.TabIndex = 4;
            // 
            // dest_DBName
            // 
            this.dest_DBName.Location = new System.Drawing.Point(68, 94);
            this.dest_DBName.Name = "dest_DBName";
            this.dest_DBName.Size = new System.Drawing.Size(198, 20);
            this.dest_DBName.TabIndex = 7;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(215, 312);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 8;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.AutoSize = true;
            this.CurrentStatus.Location = new System.Drawing.Point(18, 317);
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(164, 13);
            this.CurrentStatus.TabIndex = 7;
            this.CurrentStatus.Text = "Welcome to \"Grand Theft Table\"";
            // 
            // GTTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 349);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GTTForm";
            this.ShowIcon = false;
            this.Text = "Grand Theft Table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source_Host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox source_DBName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox source_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox source_User;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dest_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dest_User;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dest_Host;
        private System.Windows.Forms.TextBox dest_DBName;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label CurrentStatus;
        private System.Windows.Forms.CheckBox source_Trusted;
        private System.Windows.Forms.CheckBox dest_Trusted;
    }
}

