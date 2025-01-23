using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinFormProject
{
    public partial class Frmwelcome : Form
    {
        public Frmwelcome()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Frmwelcome_Load(object sender, EventArgs e)
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
