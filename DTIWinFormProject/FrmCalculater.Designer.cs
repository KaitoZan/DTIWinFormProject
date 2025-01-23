namespace DTIWinFormProject
{
    partial class FrmCalculater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculater));
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btNultiply = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.btPow = new System.Windows.Forms.Button();
            this.cbbDeclmal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbshowResilt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("Mistral", 12.25F);
            this.tbNum1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNum1.Location = new System.Drawing.Point(174, 150);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(256, 27);
            this.tbNum1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mistral", 15.25F);
            this.label2.Location = new System.Drawing.Point(62, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "ป้อนตัวเลข";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Mistral", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 70);
            this.label1.TabIndex = 12;
            this.label1.Text = "Calculater";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("Mistral", 12.25F);
            this.tbNum2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNum2.Location = new System.Drawing.Point(174, 197);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(256, 27);
            this.tbNum2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mistral", 15.25F);
            this.label3.Location = new System.Drawing.Point(62, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "ป้อนตัวเลข";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.ForeColor = System.Drawing.Color.Blue;
            this.btPlus.Location = new System.Drawing.Point(69, 258);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(63, 59);
            this.btPlus.TabIndex = 18;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.Location = new System.Drawing.Point(174, 258);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(63, 59);
            this.btMinus.TabIndex = 19;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            // 
            // btNultiply
            // 
            this.btNultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNultiply.ForeColor = System.Drawing.Color.Blue;
            this.btNultiply.Location = new System.Drawing.Point(277, 258);
            this.btNultiply.Name = "btNultiply";
            this.btNultiply.Size = new System.Drawing.Size(63, 59);
            this.btNultiply.TabIndex = 20;
            this.btNultiply.Text = "X";
            this.btNultiply.UseVisualStyleBackColor = true;
            // 
            // btDevide
            // 
            this.btDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevide.ForeColor = System.Drawing.Color.Blue;
            this.btDevide.Location = new System.Drawing.Point(382, 258);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(63, 59);
            this.btDevide.TabIndex = 21;
            this.btDevide.Text = "÷";
            this.btDevide.UseVisualStyleBackColor = true;
            // 
            // btPow
            // 
            this.btPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPow.ForeColor = System.Drawing.Color.Blue;
            this.btPow.Location = new System.Drawing.Point(489, 258);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(63, 59);
            this.btPow.TabIndex = 22;
            this.btPow.Text = "^";
            this.btPow.UseVisualStyleBackColor = true;
            // 
            // cbbDeclmal
            // 
            this.cbbDeclmal.FormattingEnabled = true;
            this.cbbDeclmal.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.cbbDeclmal.Location = new System.Drawing.Point(128, 351);
            this.cbbDeclmal.Name = "cbbDeclmal";
            this.cbbDeclmal.Size = new System.Drawing.Size(344, 21);
            this.cbbDeclmal.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "ผลลัพธ์";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbshowResilt
            // 
            this.lbshowResilt.BackColor = System.Drawing.Color.Yellow;
            this.lbshowResilt.Font = new System.Drawing.Font("Modern No. 20", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshowResilt.ForeColor = System.Drawing.Color.Red;
            this.lbshowResilt.Location = new System.Drawing.Point(139, 398);
            this.lbshowResilt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbshowResilt.Name = "lbshowResilt";
            this.lbshowResilt.Size = new System.Drawing.Size(413, 90);
            this.lbshowResilt.TabIndex = 25;
            this.lbshowResilt.Text = "?????";
            this.lbshowResilt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mistral", 12.25F);
            this.button1.Image = global::DTIWinFormProject.Properties.Resources.pevious1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(567, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 13;
            this.button1.Text = "\r\n\r\nหน้าจอหลัก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.toolStrip1.TabIndex = 26;
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
            // 
            // tslDateTime
            // 
            this.tslDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslDateTime.Name = "tslDateTime";
            this.tslDateTime.Size = new System.Drawing.Size(63, 22);
            this.tslDateTime.Text = "datetime?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCalculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 523);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbshowResilt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbDeclmal);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btNultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอเครื่องคิดเลข - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmCalculater_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btNultiply;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.ComboBox cbbDeclmal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbshowResilt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}