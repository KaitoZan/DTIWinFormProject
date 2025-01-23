using DTIWinFormProject;
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
        private void cbbDeclmal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;


        }
        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข (0-9), จุด (.) หรือปุ่มควบคุม (เช่น Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // ถ้าไม่ใช่ตัวเลขหรือจุด ให้ยกเลิกการป้อนค่า
                e.Handled = true;
            }

            // ห้ามป้อนจุดมากกว่าหนึ่งครั้ง
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข (0-9), จุด (.) หรือปุ่มควบคุม (เช่น Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // ถ้าไม่ใช่ตัวเลขหรือจุด ให้ยกเลิกการป้อนค่า
                e.Handled = true;
            }

            // ห้ามป้อนจุดมากกว่าหนึ่งครั้ง
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void btPlus_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                ShereData.showWaringMSG("ป้อนข้อมูลให้ครบก่อนคำนวณ");
            }
            else
            {
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result = num1 + num2;
                if (cbbDeclmal.SelectedIndex == 0)
                {
                    lbshowResilt.Text = result.ToString("0.00");
                }
                else if (cbbDeclmal.SelectedIndex == 1)
                {
                    lbshowResilt.Text = result.ToString("0.00000");

                }
                else
                {
                    lbshowResilt.Text = result.ToString("");
                }
            }
        }
    }
}

