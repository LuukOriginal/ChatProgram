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
            this.components = new System.ComponentModel.Container();
            this.TopBar1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.insert_Text = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Contacten = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageWindow = new System.Windows.Forms.Panel();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.TopBar1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar1
            // 
            this.TopBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.TopBar1.Controls.Add(this.button1);
            this.TopBar1.Controls.Add(this.insert_Text);
            this.TopBar1.Controls.Add(this.Add_Btn);
            this.TopBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar1.Location = new System.Drawing.Point(0, 0);
            this.TopBar1.Name = "TopBar1";
            this.TopBar1.Size = new System.Drawing.Size(874, 52);
            this.TopBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(741, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.Add_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Location = new System.Drawing.Point(12, 10);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(102, 36);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add Friend";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Contacten
            // 
            this.Contacten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.Contacten.Dock = System.Windows.Forms.DockStyle.Left;
            this.Contacten.Location = new System.Drawing.Point(0, 52);
            this.Contacten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contacten.Name = "Contacten";
            this.Contacten.Size = new System.Drawing.Size(200, 433);
            this.Contacten.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MessageWindow);
            this.panel1.Controls.Add(this.MessageInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 433);
            this.panel1.TabIndex = 2;
            // 
            // MessageWindow
            // 
            this.MessageWindow.AutoScroll = true;
            this.MessageWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.MessageWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageWindow.Location = new System.Drawing.Point(0, 0);
            this.MessageWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageWindow.Name = "MessageWindow";
            this.MessageWindow.Padding = new System.Windows.Forms.Padding(10);
            this.MessageWindow.Size = new System.Drawing.Size(674, 411);
            this.MessageWindow.TabIndex = 6;
            // 
            // MessageInput
            // 
            this.MessageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MessageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MessageInput.ForeColor = System.Drawing.Color.Gainsboro;
            this.MessageInput.Location = new System.Drawing.Point(0, 411);
            this.MessageInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(674, 22);
            this.MessageInput.TabIndex = 5;
            this.MessageInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageInput_KeyPress);
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(874, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Contacten);
            this.Controls.Add(this.TopBar1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatApp";
            this.Text = "ChatProgram";
            this.Load += new System.EventHandler(this.ChatApp_Load);
            this.TopBar1.ResumeLayout(false);
            this.TopBar1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Contacten;
        private System.Windows.Forms.Panel TopBar1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.TextBox insert_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MessageWindow;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}

