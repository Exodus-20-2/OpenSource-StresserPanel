namespace SimplePanel
{
    partial class MainHub
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
            this.minimize_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.attack_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attack_logs = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.port_box = new System.Windows.Forms.TextBox();
            this.method_box = new System.Windows.Forms.ComboBox();
            this.time_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StartAttack = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(547, -1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(20, 23);
            this.minimize_btn.TabIndex = 3;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Text = "_";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(568, -1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(29, 23);
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.52F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Tag = "";
            this.label1.Text = "Attack Logs";
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip_box.ForeColor = System.Drawing.Color.White;
            this.ip_box.Location = new System.Drawing.Point(13, 19);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(221, 20);
            this.ip_box.TabIndex = 9;
            this.ip_box.TabStop = false;
            this.ip_box.Text = "IP";
            this.ip_box.Click += new System.EventHandler(this.ip_box_Click);
            // 
            // attack_btn
            // 
            this.attack_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attack_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.attack_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.attack_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.attack_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack_btn.ForeColor = System.Drawing.Color.White;
            this.attack_btn.Location = new System.Drawing.Point(13, 124);
            this.attack_btn.Name = "attack_btn";
            this.attack_btn.Size = new System.Drawing.Size(221, 23);
            this.attack_btn.TabIndex = 8;
            this.attack_btn.TabStop = false;
            this.attack_btn.Text = "Attack";
            this.attack_btn.UseVisualStyleBackColor = true;
            this.attack_btn.Click += new System.EventHandler(this.attack_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.attack_logs);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 405);
            this.panel1.TabIndex = 11;
            // 
            // attack_logs
            // 
            this.attack_logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.attack_logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attack_logs.ForeColor = System.Drawing.Color.White;
            this.attack_logs.FormattingEnabled = true;
            this.attack_logs.Location = new System.Drawing.Point(13, 19);
            this.attack_logs.Name = "attack_logs";
            this.attack_logs.Size = new System.Drawing.Size(288, 366);
            this.attack_logs.TabIndex = 0;
            this.attack_logs.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.port_box);
            this.panel2.Controls.Add(this.method_box);
            this.panel2.Controls.Add(this.time_box);
            this.panel2.Controls.Add(this.ip_box);
            this.panel2.Controls.Add(this.attack_btn);
            this.panel2.Location = new System.Drawing.Point(332, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 163);
            this.panel2.TabIndex = 12;
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port_box.ForeColor = System.Drawing.Color.White;
            this.port_box.Location = new System.Drawing.Point(13, 45);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(221, 20);
            this.port_box.TabIndex = 12;
            this.port_box.TabStop = false;
            this.port_box.Text = "PORT";
            this.port_box.Click += new System.EventHandler(this.port_box_Click);
            // 
            // method_box
            // 
            this.method_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.method_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.method_box.ForeColor = System.Drawing.Color.White;
            this.method_box.FormattingEnabled = true;
            this.method_box.Location = new System.Drawing.Point(13, 97);
            this.method_box.Name = "method_box";
            this.method_box.Size = new System.Drawing.Size(221, 21);
            this.method_box.TabIndex = 11;
            this.method_box.TabStop = false;
            this.method_box.Text = "METHOD";
            // 
            // time_box
            // 
            this.time_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.time_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_box.ForeColor = System.Drawing.Color.White;
            this.time_box.Location = new System.Drawing.Point(13, 71);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(221, 20);
            this.time_box.TabIndex = 10;
            this.time_box.TabStop = false;
            this.time_box.Text = "TIME";
            this.time_box.Click += new System.EventHandler(this.time_box_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.52F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 11;
            this.label2.Tag = "";
            this.label2.Text = "Attack Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.52F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Tag = "";
            this.label3.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(332, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 171);
            this.panel3.TabIndex = 14;
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(12, 136);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(221, 23);
            this.logout_btn.TabIndex = 16;
            this.logout_btn.TabStop = false;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.52F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 11;
            this.label4.Tag = "";
            this.label4.Text = "put your settings and shit here retard";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(332, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 15;
            this.button2.TabStop = false;
            this.button2.Text = "Discord";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(332, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 23);
            this.button3.TabIndex = 16;
            this.button3.TabStop = false;
            this.button3.Text = "Website";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // StartAttack
            // 
            this.StartAttack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartAttack_DoWork);
            // 
            // MainHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainHub";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button attack_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox attack_logs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.ComboBox method_box;
        private System.Windows.Forms.TextBox time_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker StartAttack;
    }
}