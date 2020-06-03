using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        Registerr frmDK = new Registerr();
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
        }

        private void lbDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDK.Show();
        }

        private void mtrButtonPass_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            frmMain.Show();
        }
    }
}
