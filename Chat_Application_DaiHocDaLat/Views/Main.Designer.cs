namespace Chat_Application_DaiHocDaLat.Views
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
            this.lbOnl = new System.Windows.Forms.Label();
            this.lvChat = new System.Windows.Forms.ListView();
            this.lb_ClientOnline = new System.Windows.Forms.ListBox();
            this.mtrButtonPass = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(11, 348);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(451, 31);
            this.txtChat.TabIndex = 8;
            // 
            // lbOnl
            // 
            this.lbOnl.AutoSize = true;
            this.lbOnl.Location = new System.Drawing.Point(472, 77);
            this.lbOnl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOnl.Name = "lbOnl";
            this.lbOnl.Size = new System.Drawing.Size(115, 13);
            this.lbOnl.TabIndex = 6;
            this.lbOnl.Text = "Danh sách người dùng";
            // 
            // lvChat
            // 
            this.lvChat.HideSelection = false;
            this.lvChat.Location = new System.Drawing.Point(11, 77);
            this.lvChat.Margin = new System.Windows.Forms.Padding(2);
            this.lvChat.Name = "lvChat";
            this.lvChat.Size = new System.Drawing.Size(451, 266);
            this.lvChat.TabIndex = 5;
            this.lvChat.UseCompatibleStateImageBehavior = false;
            this.lvChat.View = System.Windows.Forms.View.List;
            // 
            // lb_ClientOnline
            // 
            this.lb_ClientOnline.FormattingEnabled = true;
            this.lb_ClientOnline.Location = new System.Drawing.Point(475, 92);
            this.lb_ClientOnline.Margin = new System.Windows.Forms.Padding(2);
            this.lb_ClientOnline.Name = "lb_ClientOnline";
            this.lb_ClientOnline.Size = new System.Drawing.Size(126, 251);
            this.lb_ClientOnline.TabIndex = 10;
            // 
            // mtrButtonPass
            // 
            this.mtrButtonPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtrButtonPass.Depth = 0;
            this.mtrButtonPass.Location = new System.Drawing.Point(475, 348);
            this.mtrButtonPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrButtonPass.Name = "mtrButtonPass";
            this.mtrButtonPass.Primary = true;
            this.mtrButtonPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrButtonPass.Size = new System.Drawing.Size(124, 31);
            this.mtrButtonPass.TabIndex = 12;
            this.mtrButtonPass.Text = "Send";
            this.mtrButtonPass.UseVisualStyleBackColor = true;
            this.mtrButtonPass.Click += new System.EventHandler(this.mtrButtonPass_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 383);
            this.Controls.Add(this.mtrButtonPass);
            this.Controls.Add(this.lb_ClientOnline);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lbOnl);
            this.Controls.Add(this.lvChat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Messager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label lbOnl;
        private System.Windows.Forms.ListView lvChat;
        private System.Windows.Forms.ListBox lb_ClientOnline;
        private MaterialSkin.Controls.MaterialRaisedButton mtrButtonPass;
    }
}