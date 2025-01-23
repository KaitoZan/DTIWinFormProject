namespace DTIWinFormProject
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslDateTime = new System.Windows.Forms.ToolStripLabel();
            this.tbRegister = new System.Windows.Forms.Button();
            this.tbSAUShop = new System.Windows.Forms.Button();
            this.ExitToLogin = new System.Windows.Forms.Button();
            this.tbLotto = new System.Windows.Forms.Button();
            this.tbShapeArea = new System.Windows.Forms.Button();
            this.tbCalculator = new System.Windows.Forms.Button();
            this.tbDooDung = new System.Windows.Forms.Button();
            this.tbWelcome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Mistral", 16.25F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tslbUsername,
            this.tslDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 498);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            this.tslbUsername.Click += new System.EventHandler(this.button1_Click);
            // 
            // tslDateTime
            // 
            this.tslDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslDateTime.Name = "tslDateTime";
            this.tslDateTime.Size = new System.Drawing.Size(63, 22);
            this.tslDateTime.Text = "datetime?";
            // 
            // tbRegister
            // 
            this.tbRegister.Image = global::DTIWinFormProject.Properties.Resources.menu7;
            this.tbRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRegister.Location = new System.Drawing.Point(395, 303);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Size = new System.Drawing.Size(117, 159);
            this.tbRegister.TabIndex = 10;
            this.tbRegister.Text = "Go to register";
            this.tbRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbRegister.UseVisualStyleBackColor = true;
            this.tbRegister.Click += new System.EventHandler(this.tbRegister_Click);
            // 
            // tbSAUShop
            // 
            this.tbSAUShop.Image = global::DTIWinFormProject.Properties.Resources.menu3;
            this.tbSAUShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSAUShop.Location = new System.Drawing.Point(395, 121);
            this.tbSAUShop.Name = "tbSAUShop";
            this.tbSAUShop.Size = new System.Drawing.Size(117, 159);
            this.tbSAUShop.TabIndex = 9;
            this.tbSAUShop.Text = "Go to SAU Shop";
            this.tbSAUShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbSAUShop.UseVisualStyleBackColor = true;
            this.tbSAUShop.Click += new System.EventHandler(this.tbSAUShop_Click);
            // 
            // ExitToLogin
            // 
            this.ExitToLogin.Image = global::DTIWinFormProject.Properties.Resources.exitapp;
            this.ExitToLogin.Location = new System.Drawing.Point(574, 303);
            this.ExitToLogin.Name = "ExitToLogin";
            this.ExitToLogin.Size = new System.Drawing.Size(117, 159);
            this.ExitToLogin.TabIndex = 8;
            this.ExitToLogin.Text = "\r\n\r\n\r\n\r\n\r\n\r\nออกจากระบบ";
            this.ExitToLogin.UseVisualStyleBackColor = true;
            this.ExitToLogin.Click += new System.EventHandler(this.ExitToLogin_Click);
            // 
            // tbLotto
            // 
            this.tbLotto.Image = global::DTIWinFormProject.Properties.Resources.menu4;
            this.tbLotto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLotto.Location = new System.Drawing.Point(574, 121);
            this.tbLotto.Name = "tbLotto";
            this.tbLotto.Size = new System.Drawing.Size(117, 159);
            this.tbLotto.TabIndex = 7;
            this.tbLotto.Text = "Go to Lotto";
            this.tbLotto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbLotto.UseVisualStyleBackColor = true;
            this.tbLotto.Click += new System.EventHandler(this.tbLotto_Click);
            // 
            // tbShapeArea
            // 
            this.tbShapeArea.Image = global::DTIWinFormProject.Properties.Resources.menu6;
            this.tbShapeArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbShapeArea.Location = new System.Drawing.Point(216, 303);
            this.tbShapeArea.Name = "tbShapeArea";
            this.tbShapeArea.Size = new System.Drawing.Size(117, 159);
            this.tbShapeArea.TabIndex = 6;
            this.tbShapeArea.Text = "Go to Shape Area";
            this.tbShapeArea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbShapeArea.UseVisualStyleBackColor = true;
            this.tbShapeArea.Click += new System.EventHandler(this.tbShapeArea_Click);
            // 
            // tbCalculator
            // 
            this.tbCalculator.Image = global::DTIWinFormProject.Properties.Resources.menu2;
            this.tbCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCalculator.Location = new System.Drawing.Point(216, 121);
            this.tbCalculator.Name = "tbCalculator";
            this.tbCalculator.Size = new System.Drawing.Size(117, 159);
            this.tbCalculator.TabIndex = 5;
            this.tbCalculator.Text = "Go to Calculator";
            this.tbCalculator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbCalculator.UseVisualStyleBackColor = true;
            this.tbCalculator.Click += new System.EventHandler(this.tbCalculator_Click);
            // 
            // tbDooDung
            // 
            this.tbDooDung.Image = global::DTIWinFormProject.Properties.Resources.menu5;
            this.tbDooDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDooDung.Location = new System.Drawing.Point(37, 303);
            this.tbDooDung.Name = "tbDooDung";
            this.tbDooDung.Size = new System.Drawing.Size(117, 159);
            this.tbDooDung.TabIndex = 4;
            this.tbDooDung.Text = "Go to DooDung";
            this.tbDooDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbDooDung.UseVisualStyleBackColor = true;
            this.tbDooDung.Click += new System.EventHandler(this.tbDooDung_Click);
            // 
            // tbWelcome
            // 
            this.tbWelcome.Image = global::DTIWinFormProject.Properties.Resources.menu1;
            this.tbWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWelcome.Location = new System.Drawing.Point(37, 121);
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.Size = new System.Drawing.Size(117, 159);
            this.tbWelcome.TabIndex = 3;
            this.tbWelcome.Text = "Go to welcome";
            this.tbWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbWelcome.UseVisualStyleBackColor = true;
            this.tbWelcome.Click += new System.EventHandler(this.tbWelcome_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbRegister);
            this.Controls.Add(this.tbSAUShop);
            this.Controls.Add(this.ExitToLogin);
            this.Controls.Add(this.tbLotto);
            this.Controls.Add(this.tbShapeArea);
            this.Controls.Add(this.tbCalculator);
            this.Controls.Add(this.tbDooDung);
            this.Controls.Add(this.tbWelcome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbWelcome;
        private System.Windows.Forms.Button tbDooDung;
        private System.Windows.Forms.Button tbShapeArea;
        private System.Windows.Forms.Button tbCalculator;
        private System.Windows.Forms.Button ExitToLogin;
        private System.Windows.Forms.Button tbLotto;
        private System.Windows.Forms.Button tbRegister;
        private System.Windows.Forms.Button tbSAUShop;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}