namespace Chat_Application_DaiHocDaLat.Views
{
    partial class Login
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
            this.lbDK = new System.Windows.Forms.LinkLabel();
            this.mtrButtonPass = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtrSingleTextUS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtrSingleTextPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDK
            // 
            this.lbDK.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbDK.AutoSize = true;
            this.lbDK.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDK.LinkColor = System.Drawing.SystemColors.GrayText;
            this.lbDK.Location = new System.Drawing.Point(87, 465);
            this.lbDK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDK.Name = "lbDK";
            this.lbDK.Size = new System.Drawing.Size(128, 20);
            this.lbDK.TabIndex = 12;
            this.lbDK.TabStop = true;
            this.lbDK.Text = "Create to account";
            this.lbDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDK_LinkClicked);
            // 
            // mtrButtonPass
            // 
            this.mtrButtonPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtrButtonPass.Depth = 0;
            this.mtrButtonPass.Location = new System.Drawing.Point(102, 404);
            this.mtrButtonPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrButtonPass.Name = "mtrButtonPass";
            this.mtrButtonPass.Primary = true;
            this.mtrButtonPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrButtonPass.Size = new System.Drawing.Size(92, 31);
            this.mtrButtonPass.TabIndex = 11;
            this.mtrButtonPass.Text = "Login";
            this.mtrButtonPass.UseVisualStyleBackColor = true;
            this.mtrButtonPass.Click += new System.EventHandler(this.mtrButtonPass_Click);
            // 
            // mtrSingleTextUS
            // 
            this.mtrSingleTextUS.Depth = 0;
            this.mtrSingleTextUS.Hint = "Password";
            this.mtrSingleTextUS.Location = new System.Drawing.Point(45, 356);
            this.mtrSingleTextUS.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrSingleTextUS.Name = "mtrSingleTextUS";
            this.mtrSingleTextUS.PasswordChar = '\0';
            this.mtrSingleTextUS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrSingleTextUS.SelectedText = "";
            this.mtrSingleTextUS.SelectionLength = 0;
            this.mtrSingleTextUS.SelectionStart = 0;
            this.mtrSingleTextUS.Size = new System.Drawing.Size(210, 23);
            this.mtrSingleTextUS.TabIndex = 10;
            this.mtrSingleTextUS.TabStop = false;
            this.mtrSingleTextUS.UseSystemPasswordChar = false;
            // 
            // mtrSingleTextPass
            // 
            this.mtrSingleTextPass.Depth = 0;
            this.mtrSingleTextPass.Hint = "Username";
            this.mtrSingleTextPass.Location = new System.Drawing.Point(45, 318);
            this.mtrSingleTextPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrSingleTextPass.Name = "mtrSingleTextPass";
            this.mtrSingleTextPass.PasswordChar = '\0';
            this.mtrSingleTextPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrSingleTextPass.SelectedText = "";
            this.mtrSingleTextPass.SelectionLength = 0;
            this.mtrSingleTextPass.SelectionStart = 0;
            this.mtrSingleTextPass.Size = new System.Drawing.Size(210, 23);
            this.mtrSingleTextPass.TabIndex = 9;
            this.mtrSingleTextPass.TabStop = false;
            this.mtrSingleTextPass.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(13, 450);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(264, 1);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chat_Application_DaiHocDaLat.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 494);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lbDK);
            this.Controls.Add(this.mtrButtonPass);
            this.Controls.Add(this.mtrSingleTextUS);
            this.Controls.Add(this.mtrSingleTextPass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbDK;
        private MaterialSkin.Controls.MaterialRaisedButton mtrButtonPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtrSingleTextUS;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtrSingleTextPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}