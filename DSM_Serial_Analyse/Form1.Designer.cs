namespace DSM_Serial_Analyse
{
    partial class Form1
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
            this.cmbDevList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radID = new System.Windows.Forms.RadioButton();
            this.radNumber = new System.Windows.Forms.RadioButton();
            this.radSerial = new System.Windows.Forms.RadioButton();
            this.radDescription = new System.Windows.Forms.RadioButton();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbxVal1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tbxVal2 = new System.Windows.Forms.TextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.tbxVal3 = new System.Windows.Forms.TextBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.tbxVal4 = new System.Windows.Forms.TextBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.tbxVal5 = new System.Windows.Forms.TextBox();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.tbxVal6 = new System.Windows.Forms.TextBox();
            this.tbxCH5 = new System.Windows.Forms.TextBox();
            this.tbxCH4 = new System.Windows.Forms.TextBox();
            this.tbxCH3 = new System.Windows.Forms.TextBox();
            this.tbxCH2 = new System.Windows.Forms.TextBox();
            this.tbxCH1 = new System.Windows.Forms.TextBox();
            this.tbxCH0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPercent6 = new System.Windows.Forms.TextBox();
            this.tbxPercent5 = new System.Windows.Forms.TextBox();
            this.tbxPercent4 = new System.Windows.Forms.TextBox();
            this.tbxPercent3 = new System.Windows.Forms.TextBox();
            this.tbxPercent2 = new System.Windows.Forms.TextBox();
            this.tbxPercent1 = new System.Windows.Forms.TextBox();
            this.tbxMode2 = new System.Windows.Forms.TextBox();
            this.lblBind = new System.Windows.Forms.Label();
            this.LblRange = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDevList
            // 
            this.cmbDevList.Location = new System.Drawing.Point(64, 43);
            this.cmbDevList.Name = "cmbDevList";
            this.cmbDevList.Size = new System.Drawing.Size(253, 21);
            this.cmbDevList.TabIndex = 8;
            this.cmbDevList.SelectedIndexChanged += new System.EventHandler(this.cmbDevList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radID);
            this.panel1.Controls.Add(this.radNumber);
            this.panel1.Controls.Add(this.radSerial);
            this.panel1.Controls.Add(this.radDescription);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 25);
            this.panel1.TabIndex = 9;
            // 
            // radID
            // 
            this.radID.Location = new System.Drawing.Point(224, 7);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(44, 15);
            this.radID.TabIndex = 17;
            this.radID.Text = "ID";
            this.radID.CheckedChanged += new System.EventHandler(this.radx_CheckedChanged);
            // 
            // radNumber
            // 
            this.radNumber.Location = new System.Drawing.Point(146, 6);
            this.radNumber.Name = "radNumber";
            this.radNumber.Size = new System.Drawing.Size(62, 15);
            this.radNumber.TabIndex = 14;
            this.radNumber.Text = "Number";
            this.radNumber.CheckedChanged += new System.EventHandler(this.radx_CheckedChanged);
            // 
            // radSerial
            // 
            this.radSerial.Location = new System.Drawing.Point(93, 6);
            this.radSerial.Name = "radSerial";
            this.radSerial.Size = new System.Drawing.Size(51, 15);
            this.radSerial.TabIndex = 15;
            this.radSerial.Text = "Serial";
            this.radSerial.CheckedChanged += new System.EventHandler(this.radx_CheckedChanged);
            // 
            // radDescription
            // 
            this.radDescription.Checked = true;
            this.radDescription.Location = new System.Drawing.Point(9, 6);
            this.radDescription.Name = "radDescription";
            this.radDescription.Size = new System.Drawing.Size(79, 15);
            this.radDescription.TabIndex = 16;
            this.radDescription.TabStop = true;
            this.radDescription.Text = "Description";
            this.radDescription.CheckedChanged += new System.EventHandler(this.radx_CheckedChanged);
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "125000",
            "131000",
            "138000",
            "230400",
            "460800",
            "921600"});
            this.cmbBaud.Location = new System.Drawing.Point(189, 68);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(128, 21);
            this.cmbBaud.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "BAUD RATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DEVICE";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Enabled = false;
            this.BtnOpen.Location = new System.Drawing.Point(329, 42);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(71, 30);
            this.BtnOpen.TabIndex = 13;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(329, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 30);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbxVal1
            // 
            this.tbxVal1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal1.CausesValidation = false;
            this.tbxVal1.Enabled = false;
            this.tbxVal1.Location = new System.Drawing.Point(51, 138);
            this.tbxVal1.Name = "tbxVal1";
            this.tbxVal1.ReadOnly = true;
            this.tbxVal1.Size = new System.Drawing.Size(39, 20);
            this.tbxVal1.TabIndex = 15;
            this.tbxVal1.TabStop = false;
            this.tbxVal1.WordWrap = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(138, 138);
            this.progressBar1.Maximum = 1023;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 18);
            this.progressBar1.TabIndex = 16;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(138, 170);
            this.progressBar2.Maximum = 1024;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(265, 18);
            this.progressBar2.TabIndex = 18;
            // 
            // tbxVal2
            // 
            this.tbxVal2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal2.CausesValidation = false;
            this.tbxVal2.Enabled = false;
            this.tbxVal2.Location = new System.Drawing.Point(51, 170);
            this.tbxVal2.Name = "tbxVal2";
            this.tbxVal2.ReadOnly = true;
            this.tbxVal2.Size = new System.Drawing.Size(39, 20);
            this.tbxVal2.TabIndex = 17;
            this.tbxVal2.TabStop = false;
            this.tbxVal2.WordWrap = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(138, 202);
            this.progressBar3.Maximum = 1024;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(265, 18);
            this.progressBar3.TabIndex = 20;
            // 
            // tbxVal3
            // 
            this.tbxVal3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal3.CausesValidation = false;
            this.tbxVal3.Enabled = false;
            this.tbxVal3.Location = new System.Drawing.Point(51, 202);
            this.tbxVal3.Name = "tbxVal3";
            this.tbxVal3.ReadOnly = true;
            this.tbxVal3.Size = new System.Drawing.Size(39, 20);
            this.tbxVal3.TabIndex = 19;
            this.tbxVal3.TabStop = false;
            this.tbxVal3.WordWrap = false;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(138, 234);
            this.progressBar4.Maximum = 1024;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(265, 18);
            this.progressBar4.TabIndex = 22;
            // 
            // tbxVal4
            // 
            this.tbxVal4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal4.CausesValidation = false;
            this.tbxVal4.Enabled = false;
            this.tbxVal4.Location = new System.Drawing.Point(51, 234);
            this.tbxVal4.Name = "tbxVal4";
            this.tbxVal4.ReadOnly = true;
            this.tbxVal4.Size = new System.Drawing.Size(39, 20);
            this.tbxVal4.TabIndex = 21;
            this.tbxVal4.TabStop = false;
            this.tbxVal4.WordWrap = false;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(138, 266);
            this.progressBar5.Maximum = 1024;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(265, 18);
            this.progressBar5.TabIndex = 24;
            // 
            // tbxVal5
            // 
            this.tbxVal5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal5.CausesValidation = false;
            this.tbxVal5.Enabled = false;
            this.tbxVal5.Location = new System.Drawing.Point(51, 266);
            this.tbxVal5.Name = "tbxVal5";
            this.tbxVal5.ReadOnly = true;
            this.tbxVal5.Size = new System.Drawing.Size(39, 20);
            this.tbxVal5.TabIndex = 23;
            this.tbxVal5.TabStop = false;
            this.tbxVal5.WordWrap = false;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(138, 298);
            this.progressBar6.Maximum = 1024;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(265, 18);
            this.progressBar6.TabIndex = 26;
            // 
            // tbxVal6
            // 
            this.tbxVal6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxVal6.CausesValidation = false;
            this.tbxVal6.Enabled = false;
            this.tbxVal6.Location = new System.Drawing.Point(51, 298);
            this.tbxVal6.Name = "tbxVal6";
            this.tbxVal6.ReadOnly = true;
            this.tbxVal6.Size = new System.Drawing.Size(39, 20);
            this.tbxVal6.TabIndex = 25;
            this.tbxVal6.TabStop = false;
            this.tbxVal6.WordWrap = false;
            // 
            // tbxCH5
            // 
            this.tbxCH5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH5.CausesValidation = false;
            this.tbxCH5.Enabled = false;
            this.tbxCH5.Location = new System.Drawing.Point(5, 298);
            this.tbxCH5.Name = "tbxCH5";
            this.tbxCH5.ReadOnly = true;
            this.tbxCH5.Size = new System.Drawing.Size(40, 20);
            this.tbxCH5.TabIndex = 32;
            this.tbxCH5.TabStop = false;
            this.tbxCH5.WordWrap = false;
            // 
            // tbxCH4
            // 
            this.tbxCH4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH4.CausesValidation = false;
            this.tbxCH4.Enabled = false;
            this.tbxCH4.Location = new System.Drawing.Point(5, 266);
            this.tbxCH4.Name = "tbxCH4";
            this.tbxCH4.ReadOnly = true;
            this.tbxCH4.Size = new System.Drawing.Size(40, 20);
            this.tbxCH4.TabIndex = 31;
            this.tbxCH4.TabStop = false;
            this.tbxCH4.WordWrap = false;
            // 
            // tbxCH3
            // 
            this.tbxCH3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH3.CausesValidation = false;
            this.tbxCH3.Enabled = false;
            this.tbxCH3.Location = new System.Drawing.Point(5, 234);
            this.tbxCH3.Name = "tbxCH3";
            this.tbxCH3.ReadOnly = true;
            this.tbxCH3.Size = new System.Drawing.Size(40, 20);
            this.tbxCH3.TabIndex = 30;
            this.tbxCH3.TabStop = false;
            this.tbxCH3.WordWrap = false;
            // 
            // tbxCH2
            // 
            this.tbxCH2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH2.CausesValidation = false;
            this.tbxCH2.Enabled = false;
            this.tbxCH2.Location = new System.Drawing.Point(5, 202);
            this.tbxCH2.Name = "tbxCH2";
            this.tbxCH2.ReadOnly = true;
            this.tbxCH2.Size = new System.Drawing.Size(40, 20);
            this.tbxCH2.TabIndex = 29;
            this.tbxCH2.TabStop = false;
            this.tbxCH2.WordWrap = false;
            // 
            // tbxCH1
            // 
            this.tbxCH1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH1.CausesValidation = false;
            this.tbxCH1.Enabled = false;
            this.tbxCH1.Location = new System.Drawing.Point(5, 170);
            this.tbxCH1.Name = "tbxCH1";
            this.tbxCH1.ReadOnly = true;
            this.tbxCH1.Size = new System.Drawing.Size(40, 20);
            this.tbxCH1.TabIndex = 28;
            this.tbxCH1.TabStop = false;
            this.tbxCH1.WordWrap = false;
            // 
            // tbxCH0
            // 
            this.tbxCH0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxCH0.CausesValidation = false;
            this.tbxCH0.Enabled = false;
            this.tbxCH0.Location = new System.Drawing.Point(5, 138);
            this.tbxCH0.Name = "tbxCH0";
            this.tbxCH0.ReadOnly = true;
            this.tbxCH0.Size = new System.Drawing.Size(40, 20);
            this.tbxCH0.TabIndex = 27;
            this.tbxCH0.TabStop = false;
            this.tbxCH0.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Channel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mode";
            // 
            // tbxMode
            // 
            this.tbxMode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxMode.CausesValidation = false;
            this.tbxMode.Enabled = false;
            this.tbxMode.Location = new System.Drawing.Point(95, 94);
            this.tbxMode.Name = "tbxMode";
            this.tbxMode.ReadOnly = true;
            this.tbxMode.Size = new System.Drawing.Size(36, 20);
            this.tbxMode.TabIndex = 36;
            this.tbxMode.TabStop = false;
            this.tbxMode.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "%";
            // 
            // tbxPercent6
            // 
            this.tbxPercent6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent6.CausesValidation = false;
            this.tbxPercent6.Enabled = false;
            this.tbxPercent6.Location = new System.Drawing.Point(96, 298);
            this.tbxPercent6.Name = "tbxPercent6";
            this.tbxPercent6.ReadOnly = true;
            this.tbxPercent6.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent6.TabIndex = 43;
            this.tbxPercent6.TabStop = false;
            this.tbxPercent6.WordWrap = false;
            // 
            // tbxPercent5
            // 
            this.tbxPercent5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent5.CausesValidation = false;
            this.tbxPercent5.Enabled = false;
            this.tbxPercent5.Location = new System.Drawing.Point(96, 266);
            this.tbxPercent5.Name = "tbxPercent5";
            this.tbxPercent5.ReadOnly = true;
            this.tbxPercent5.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent5.TabIndex = 42;
            this.tbxPercent5.TabStop = false;
            this.tbxPercent5.WordWrap = false;
            // 
            // tbxPercent4
            // 
            this.tbxPercent4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent4.CausesValidation = false;
            this.tbxPercent4.Enabled = false;
            this.tbxPercent4.Location = new System.Drawing.Point(96, 234);
            this.tbxPercent4.Name = "tbxPercent4";
            this.tbxPercent4.ReadOnly = true;
            this.tbxPercent4.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent4.TabIndex = 41;
            this.tbxPercent4.TabStop = false;
            this.tbxPercent4.WordWrap = false;
            // 
            // tbxPercent3
            // 
            this.tbxPercent3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent3.CausesValidation = false;
            this.tbxPercent3.Enabled = false;
            this.tbxPercent3.Location = new System.Drawing.Point(96, 202);
            this.tbxPercent3.Name = "tbxPercent3";
            this.tbxPercent3.ReadOnly = true;
            this.tbxPercent3.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent3.TabIndex = 40;
            this.tbxPercent3.TabStop = false;
            this.tbxPercent3.WordWrap = false;
            // 
            // tbxPercent2
            // 
            this.tbxPercent2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent2.CausesValidation = false;
            this.tbxPercent2.Enabled = false;
            this.tbxPercent2.Location = new System.Drawing.Point(96, 170);
            this.tbxPercent2.Name = "tbxPercent2";
            this.tbxPercent2.ReadOnly = true;
            this.tbxPercent2.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent2.TabIndex = 39;
            this.tbxPercent2.TabStop = false;
            this.tbxPercent2.WordWrap = false;
            // 
            // tbxPercent1
            // 
            this.tbxPercent1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxPercent1.CausesValidation = false;
            this.tbxPercent1.Enabled = false;
            this.tbxPercent1.Location = new System.Drawing.Point(96, 138);
            this.tbxPercent1.Name = "tbxPercent1";
            this.tbxPercent1.ReadOnly = true;
            this.tbxPercent1.Size = new System.Drawing.Size(35, 20);
            this.tbxPercent1.TabIndex = 38;
            this.tbxPercent1.TabStop = false;
            this.tbxPercent1.WordWrap = false;
            // 
            // tbxMode2
            // 
            this.tbxMode2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxMode2.CausesValidation = false;
            this.tbxMode2.Enabled = false;
            this.tbxMode2.Location = new System.Drawing.Point(138, 94);
            this.tbxMode2.Name = "tbxMode2";
            this.tbxMode2.ReadOnly = true;
            this.tbxMode2.Size = new System.Drawing.Size(46, 20);
            this.tbxMode2.TabIndex = 44;
            this.tbxMode2.TabStop = false;
            this.tbxMode2.WordWrap = false;
            // 
            // lblBind
            // 
            this.lblBind.AutoSize = true;
            this.lblBind.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBind.Location = new System.Drawing.Point(200, 99);
            this.lblBind.Name = "lblBind";
            this.lblBind.Size = new System.Drawing.Size(33, 13);
            this.lblBind.TabIndex = 45;
            this.lblBind.Text = "BIND";
            this.lblBind.Visible = false;
            // 
            // LblRange
            // 
            this.LblRange.AutoSize = true;
            this.LblRange.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblRange.Location = new System.Drawing.Point(239, 99);
            this.LblRange.Name = "LblRange";
            this.LblRange.Size = new System.Drawing.Size(73, 13);
            this.LblRange.TabIndex = 46;
            this.LblRange.Text = "Range Check";
            this.LblRange.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 328);
            this.Controls.Add(this.LblRange);
            this.Controls.Add(this.lblBind);
            this.Controls.Add(this.tbxMode2);
            this.Controls.Add(this.tbxPercent6);
            this.Controls.Add(this.tbxPercent5);
            this.Controls.Add(this.tbxPercent4);
            this.Controls.Add(this.tbxPercent3);
            this.Controls.Add(this.tbxPercent2);
            this.Controls.Add(this.tbxPercent1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCH5);
            this.Controls.Add(this.tbxCH4);
            this.Controls.Add(this.tbxCH3);
            this.Controls.Add(this.tbxCH2);
            this.Controls.Add(this.tbxCH1);
            this.Controls.Add(this.tbxCH0);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.tbxVal6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.tbxVal5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.tbxVal4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.tbxVal3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.tbxVal2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbxVal1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbDevList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radNumber;
        private System.Windows.Forms.RadioButton radSerial;
        private System.Windows.Forms.RadioButton radDescription;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbxVal1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox tbxVal2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox tbxVal3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.TextBox tbxVal4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.TextBox tbxVal5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.TextBox tbxVal6;
        private System.Windows.Forms.TextBox tbxCH5;
        private System.Windows.Forms.TextBox tbxCH4;
        private System.Windows.Forms.TextBox tbxCH3;
        private System.Windows.Forms.TextBox tbxCH2;
        private System.Windows.Forms.TextBox tbxCH1;
        private System.Windows.Forms.TextBox tbxCH0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPercent6;
        private System.Windows.Forms.TextBox tbxPercent5;
        private System.Windows.Forms.TextBox tbxPercent4;
        private System.Windows.Forms.TextBox tbxPercent3;
        private System.Windows.Forms.TextBox tbxPercent2;
        private System.Windows.Forms.TextBox tbxPercent1;
        private System.Windows.Forms.TextBox tbxMode2;
        private System.Windows.Forms.Label lblBind;
        private System.Windows.Forms.Label LblRange;
    }
}

