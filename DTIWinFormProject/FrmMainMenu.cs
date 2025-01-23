using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DtiWinformProject;

namespace DTIWinFormProject
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShereData.loginName+"{"+ShereData.LoginType+"}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void tbWelcome_Click(object sender, EventArgs e)
        {
            Frmwelcome frmWelcome = new Frmwelcome();
            frmWelcome.Show();
            Hide(); //ปิดหน้าจอตัวเอง


        }

        private void tbCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculater frmCalculater = new FrmCalculater();
            frmCalculater.Show();
            Hide() ;
        }

        private void tbSAUShop_Click(object sender, EventArgs e)
        {
            FrmSAUShop frmSAUShop = new FrmSAUShop();
            frmSAUShop.Show();
            Hide() ;
        }

        private void tbLotto_Click(object sender, EventArgs e)
        {
            FrmLotto frmLotto = new FrmLotto();
            frmLotto.Show();
            Hide() ;
        }

        private void tbDooDung_Click(object sender, EventArgs e)
        {
            FrmDooDung frmDooDung = new FrmDooDung();
            frmDooDung.Show();
            Hide() ;
        }

        private void tbShapeArea_Click(object sender, EventArgs e)
        {
           FrmShapeArea frmShapeArea = new FrmShapeArea();
            frmShapeArea.Show();
            Hide() ;
        }

        private void tbRegister_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();
            Hide();
        }

        private void ExitToLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการบอกจากโปรแกรมใช่ไหม", "ยืนยัน",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
