﻿namespace ChatProgram
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
            this.insert_Text = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Contacten = new System.Windows.Forms.Panel();
            this.TopBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar1
            // 
            this.TopBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.TopBar1.Controls.Add(this.insert_Text);
            this.TopBar1.Controls.Add(this.Add_Btn);
            this.TopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar1.Location = new System.Drawing.Point(0, 0);
            this.TopBar1.Margin = new System.Windows.Forms.Padding(2);
            this.TopBar1.Name = "TopBar1";
            this.TopBar1.Size = new System.Drawing.Size(583, 34);
            this.TopBar1.TabIndex = 0;
            // 
            // insert_Text
            // 
            this.insert_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insert_Text.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.Location = new System.Drawing.Point(0, 34);
            this.insert_Text.Margin = new System.Windows.Forms.Padding(2);
            this.insert_Text.Name = "insert_Text";
            this.insert_Text.Size = new System.Drawing.Size(133, 13);
            this.insert_Text.TabIndex = 0;
            this.insert_Text.Visible = false;
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Add_Btn.Location = new System.Drawing.Point(0, 2);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(2);
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
            this.Contacten.Location = new System.Drawing.Point(0, 34);
            this.Contacten.Name = "Contacten";
            this.Contacten.Size = new System.Drawing.Size(133, 281);
            this.Contacten.TabIndex = 1;
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.Contacten);
            this.Controls.Add(this.TopBar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ChatApp";
            this.Text = "ChatProgram";
            this.Load += new System.EventHandler(this.ChatApp_Load);
            this.TopBar1.ResumeLayout(false);
            this.TopBar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Contacten;
        private System.Windows.Forms.Panel TopBar1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.TextBox insert_Text;
    }
}
