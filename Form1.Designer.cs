
namespace IQPrinterKicker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.redtAbout = new System.Windows.Forms.RichTextBox();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.edtKickString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.cmbxPrinterList = new System.Windows.Forms.ComboBox();
            this.tabIQReportCode = new System.Windows.Forms.TabPage();
            this.redtIQReportCode = new System.Windows.Forms.RichTextBox();
            this.dlgFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.chckbxEnableDebugMode = new System.Windows.Forms.CheckBox();
            this.tbctrlMain.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabTest.SuspendLayout();
            this.tabIQReportCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Controls.Add(this.tabInfo);
            this.tbctrlMain.Controls.Add(this.tabTest);
            this.tbctrlMain.Controls.Add(this.tabIQReportCode);
            this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlMain.Location = new System.Drawing.Point(0, 0);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(465, 201);
            this.tbctrlMain.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.redtAbout);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(457, 175);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // redtAbout
            // 
            this.redtAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redtAbout.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redtAbout.Location = new System.Drawing.Point(3, 3);
            this.redtAbout.Name = "redtAbout";
            this.redtAbout.Size = new System.Drawing.Size(451, 169);
            this.redtAbout.TabIndex = 0;
            this.redtAbout.Text = resources.GetString("redtAbout.Text");
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.chckbxEnableDebugMode);
            this.tabTest.Controls.Add(this.edtKickString);
            this.tabTest.Controls.Add(this.label4);
            this.tabTest.Controls.Add(this.label3);
            this.tabTest.Controls.Add(this.btnTest);
            this.tabTest.Controls.Add(this.cmbxPrinterList);
            this.tabTest.Location = new System.Drawing.Point(4, 22);
            this.tabTest.Name = "tabTest";
            this.tabTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabTest.Size = new System.Drawing.Size(457, 175);
            this.tabTest.TabIndex = 1;
            this.tabTest.Text = "Test Software";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // edtKickString
            // 
            this.edtKickString.Location = new System.Drawing.Point(10, 100);
            this.edtKickString.Name = "edtKickString";
            this.edtKickString.Size = new System.Drawing.Size(432, 20);
            this.edtKickString.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Printer Kick Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Printer";
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(158, 135);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(158, 32);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Kick Interface";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbxPrinterList
            // 
            this.cmbxPrinterList.FormattingEnabled = true;
            this.cmbxPrinterList.Location = new System.Drawing.Point(10, 48);
            this.cmbxPrinterList.Name = "cmbxPrinterList";
            this.cmbxPrinterList.Size = new System.Drawing.Size(435, 21);
            this.cmbxPrinterList.TabIndex = 2;
            // 
            // tabIQReportCode
            // 
            this.tabIQReportCode.Controls.Add(this.redtIQReportCode);
            this.tabIQReportCode.Location = new System.Drawing.Point(4, 22);
            this.tabIQReportCode.Name = "tabIQReportCode";
            this.tabIQReportCode.Size = new System.Drawing.Size(457, 175);
            this.tabIQReportCode.TabIndex = 2;
            this.tabIQReportCode.Text = "IQRetail Report Code";
            this.tabIQReportCode.UseVisualStyleBackColor = true;
            // 
            // redtIQReportCode
            // 
            this.redtIQReportCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redtIQReportCode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redtIQReportCode.Location = new System.Drawing.Point(0, 0);
            this.redtIQReportCode.Name = "redtIQReportCode";
            this.redtIQReportCode.Size = new System.Drawing.Size(457, 175);
            this.redtIQReportCode.TabIndex = 0;
            this.redtIQReportCode.Text = resources.GetString("redtIQReportCode.Text");
            // 
            // chckbxEnableDebugMode
            // 
            this.chckbxEnableDebugMode.AutoSize = true;
            this.chckbxEnableDebugMode.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbxEnableDebugMode.Location = new System.Drawing.Point(308, 26);
            this.chckbxEnableDebugMode.Name = "chckbxEnableDebugMode";
            this.chckbxEnableDebugMode.Size = new System.Drawing.Size(134, 19);
            this.chckbxEnableDebugMode.TabIndex = 12;
            this.chckbxEnableDebugMode.Text = "Enable Debug Mode";
            this.chckbxEnableDebugMode.UseVisualStyleBackColor = true;
            this.chckbxEnableDebugMode.CheckedChanged += new System.EventHandler(this.chckbxEnableDebugMode_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.tbctrlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(481, 240);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer Kicker";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tbctrlMain.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.tabIQReportCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cmbxPrinterList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabIQReportCode;
        private System.Windows.Forms.RichTextBox redtIQReportCode;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderSelector;
        private System.Windows.Forms.TextBox edtKickString;
        private System.Windows.Forms.RichTextBox redtAbout;
        private System.Windows.Forms.CheckBox chckbxEnableDebugMode;
    }
}

