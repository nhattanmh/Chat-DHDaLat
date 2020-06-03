namespace Server.Views
{
    partial class Main
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbOnl = new System.Windows.Forms.Label();
            this.lvChat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(-22, 294);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(451, 50);
            this.txtChat.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(434, 26);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 251);
            this.listBox1.TabIndex = 11;
            // 
            // lbOnl
            // 
            this.lbOnl.AutoSize = true;
            this.lbOnl.Location = new System.Drawing.Point(433, 8);
            this.lbOnl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOnl.Name = "lbOnl";
            this.lbOnl.Size = new System.Drawing.Size(115, 13);
            this.lbOnl.TabIndex = 10;
            this.lbOnl.Text = "Danh sách người dùng";
            // 
            // lvChat
            // 
            this.lvChat.HideSelection = false;
            this.lvChat.Location = new System.Drawing.Point(-22, 8);
            this.lvChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvChat.Name = "lvChat";
            this.lvChat.Size = new System.Drawing.Size(451, 270);
            this.lvChat.TabIndex = 9;
            this.lvChat.UseCompatibleStateImageBehavior = false;
            this.lvChat.View = System.Windows.Forms.View.List;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 352);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbOnl);
            this.Controls.Add(this.lvChat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbOnl;
        private System.Windows.Forms.ListView lvChat;
    }
}