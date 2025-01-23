using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinFormProject
{
    public partial class FrmCalculater : Form
    {
        public FrmCalculater()
        {
            InitializeComponent();
        }


        private void FrmCalculater_Load(object sender, EventArgs e)
        {

            tslbUsername.Text = ShereData.loginName + "{" + ShereData.LoginType + "}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
            Hide();
        }
    }
}
