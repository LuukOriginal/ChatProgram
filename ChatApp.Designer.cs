namespace ChatProgram
{
    partial class ChatApp
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
            this.TopBar1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.insert_Text = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Contacten = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopBar1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar1
            // 
            this.TopBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.TopBar1.Controls.Add(this.button1);
            this.TopBar1.Controls.Add(this.insert_Text);
            this.TopBar1.Controls.Add(this.Add_Btn);
            this.TopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar1.Location = new System.Drawing.Point(0, 0);
            this.TopBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopBar1.Name = "TopBar1";
            this.TopBar1.Size = new System.Drawing.Size(583, 34);
            this.TopBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_Text
            // 
            this.insert_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insert_Text.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.Location = new System.Drawing.Point(0, 34);
            this.insert_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insert_Text.Name = "insert_Text";
            this.insert_Text.Size = new System.Drawing.Size(133, 13);
            this.insert_Text.TabIndex = 0;
            this.insert_Text.Visible = false;
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Add_Btn.Location = new System.Drawing.Point(0, 2);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(104, 32);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add Friend";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Contacten
            // 
            this.Contacten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Contacten.Dock = System.Windows.Forms.DockStyle.Left;
            this.Contacten.Location = new System.Drawing.Point(0, 34);
            this.Contacten.Name = "Contacten";
            this.Contacten.Size = new System.Drawing.Size(133, 281);
            this.Contacten.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MessagePanel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(133, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 281);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.panel2);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(450, 261);
            this.MessagePanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 55);
            this.panel2.TabIndex = 0;
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Contacten);
            this.Controls.Add(this.TopBar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ChatApp";
            this.Text = "ChatProgram";
            this.Load += new System.EventHandler(this.ChatApp_Load);
            this.TopBar1.ResumeLayout(false);
            this.TopBar1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Contacten;
        private System.Windows.Forms.Panel TopBar1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.TextBox insert_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

