namespace ChatProgram
{
    partial class Form1
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
            this.Contacten = new System.Windows.Forms.Panel();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.insert_Text = new System.Windows.Forms.TextBox();
            this.Add_Txt = new System.Windows.Forms.TextBox();
            this.TopBar1.SuspendLayout();
            this.Contacten.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar1
            // 
            this.TopBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopBar1.Controls.Add(this.insert_Text);
            this.TopBar1.Controls.Add(this.Add_Btn);
            this.TopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar1.Location = new System.Drawing.Point(0, 0);
            this.TopBar1.Name = "TopBar1";
            this.TopBar1.Size = new System.Drawing.Size(875, 52);
            this.TopBar1.TabIndex = 0;
            this.TopBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Contacten
            // 
            this.Contacten.Controls.Add(this.Add_Txt);
            this.Contacten.Location = new System.Drawing.Point(0, 52);
            this.Contacten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contacten.Name = "Contacten";
            this.Contacten.Size = new System.Drawing.Size(200, 433);
            this.Contacten.TabIndex = 1;
            this.Contacten.Paint += new System.Windows.Forms.PaintEventHandler(this.Contacten_Paint);
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Add_Btn.Location = new System.Drawing.Point(0, 3);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(156, 49);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add Friend";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_Text
            // 
            this.insert_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insert_Text.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.insert_Text.Location = new System.Drawing.Point(0, 52);
            this.insert_Text.Name = "insert_Text";
            this.insert_Text.Size = new System.Drawing.Size(200, 19);
            this.insert_Text.TabIndex = 0;
            this.insert_Text.Visible = false;
            this.insert_Text.TextChanged += new System.EventHandler(this.insert_Text_TextChanged);
            // 
            // Add_Txt
            // 
            this.Add_Txt.Location = new System.Drawing.Point(0, 0);
            this.Add_Txt.Name = "Add_Txt";
            this.Add_Txt.Size = new System.Drawing.Size(200, 26);
            this.Add_Txt.TabIndex = 0;
            this.Add_Txt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(875, 485);
            this.Controls.Add(this.Contacten);
            this.Controls.Add(this.TopBar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ChatProgram";
            this.TopBar1.ResumeLayout(false);
            this.TopBar1.PerformLayout();
            this.Contacten.ResumeLayout(false);
            this.Contacten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Contacten;
        private System.Windows.Forms.Panel TopBar1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.TextBox insert_Text;
        private System.Windows.Forms.TextBox Add_Txt;
    }
}

