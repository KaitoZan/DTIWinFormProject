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

        private void btOl_Click_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Trim().Length == 0)
            {
                ShereData.showWaringMSG("ปเอนชื่อด้วย....");

            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShereData.showWaringMSG("ปีเกิดต้องน้แนกส่าปีปัจจุบัน....");

            }

            else
            {
                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;
                string birthDate = dtpBirthDate.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyyy", new CultureInfo("th-TH"));

                string gender = rdMale.Checked == true ? "ฃาย" : "หญิง";
                string detaShow = "ฃื่อ :" + tbName.Text + "\n" +
                                  "วันเกิด :" + birthDate + "\n" +
                                   "อายุ :" + age + "ปี\n" +
                                   "เพศ :" + gender + "\n";
                lbShowResult.Text = detaShow;
            }
        }
    }
}
