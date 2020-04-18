using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Media_Store
{
    public partial class MainWindow : Form
    {
 
        public MainWindow()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
                
        }

        private void goToStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var storeForm = new StoreForm();
            storeForm.ShowDialog();
            this.Close();
        }

        private void btn_ManagementPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manegementpanel = new ManagementForm();
            manegementpanel.ShowDialog();
            this.Close();
           
        }
    }
}
