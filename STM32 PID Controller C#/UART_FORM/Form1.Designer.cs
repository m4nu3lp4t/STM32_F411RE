namespace UART_FORM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpBxCom = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnDisconnect = new System.Windows.Forms.Button();
            this.bttnConnect = new System.Windows.Forms.Button();
            this.cmboxBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbBxPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnOFF = new System.Windows.Forms.Button();
            this.bttnUpDate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownKd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownKp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownSetPoint = new System.Windows.Forms.NumericUpDown();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnStart = new System.Windows.Forms.Button();
            this.grpBxCom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSetPoint)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxCom
            // 
            this.grpBxCom.Controls.Add(this.label2);
            this.grpBxCom.Controls.Add(this.label1);
            this.grpBxCom.Controls.Add(this.bttnDisconnect);
            this.grpBxCom.Controls.Add(this.bttnConnect);
            this.grpBxCom.Controls.Add(this.cmboxBaudRate);
            this.grpBxCom.Controls.Add(this.cmbBxPort);
            this.grpBxCom.Location = new System.Drawing.Point(41, 25);
            this.grpBxCom.Name = "grpBxCom";
            this.grpBxCom.Size = new System.Drawing.Size(151, 190);
            this.grpBxCom.TabIndex = 0;
            this.grpBxCom.TabStop = false;
            this.grpBxCom.Text = "COM Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PORT";
            // 
            // bttnDisconnect
            // 
            this.bttnDisconnect.Location = new System.Drawing.Point(37, 151);
            this.bttnDisconnect.Name = "bttnDisconnect";
            this.bttnDisconnect.Size = new System.Drawing.Size(92, 23);
            this.bttnDisconnect.TabIndex = 3;
            this.bttnDisconnect.Text = "DISCONNECT";
            this.bttnDisconnect.UseVisualStyleBackColor = true;
            this.bttnDisconnect.Click += new System.EventHandler(this.bttnDisconnect_Click);
            // 
            // bttnConnect
            // 
            this.bttnConnect.Location = new System.Drawing.Point(37, 119);
            this.bttnConnect.Name = "bttnConnect";
            this.bttnConnect.Size = new System.Drawing.Size(92, 23);
            this.bttnConnect.TabIndex = 2;
            this.bttnConnect.Text = "CONNECT";
            this.bttnConnect.UseVisualStyleBackColor = true;
            this.bttnConnect.Click += new System.EventHandler(this.bttnConnect_Click);
            // 
            // cmboxBaudRate
            // 
            this.cmboxBaudRate.DisplayMember = "115200";
            this.cmboxBaudRate.FormattingEnabled = true;
            this.cmboxBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmboxBaudRate.Location = new System.Drawing.Point(37, 84);
            this.cmboxBaudRate.Name = "cmboxBaudRate";
            this.cmboxBaudRate.Size = new System.Drawing.Size(92, 21);
            this.cmboxBaudRate.TabIndex = 1;
            // 
            // cmbBxPort
            // 
            this.cmbBxPort.DisplayMember = "COM4";
            this.cmbBxPort.FormattingEnabled = true;
            this.cmbBxPort.Location = new System.Drawing.Point(37, 41);
            this.cmbBxPort.Name = "cmbBxPort";
            this.cmbBxPort.Size = new System.Drawing.Size(92, 21);
            this.cmbBxPort.TabIndex = 0;
            this.cmbBxPort.ValueMember = "COM4";
            this.cmbBxPort.SelectedIndexChanged += new System.EventHandler(this.cmbBxPort_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnOFF);
            this.groupBox1.Controls.Add(this.bttnUpDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownKd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownKi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownKp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numUpDownSetPoint);
            this.groupBox1.Location = new System.Drawing.Point(215, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PID Setup";
            // 
            // bttnOFF
            // 
            this.bttnOFF.Location = new System.Drawing.Point(77, 158);
            this.bttnOFF.Name = "bttnOFF";
            this.bttnOFF.Size = new System.Drawing.Size(79, 23);
            this.bttnOFF.TabIndex = 8;
            this.bttnOFF.Text = "OFF";
            this.bttnOFF.UseVisualStyleBackColor = true;
            this.bttnOFF.Click += new System.EventHandler(this.bttnOFF_Click);
            // 
            // bttnUpDate
            // 
            this.bttnUpDate.Location = new System.Drawing.Point(77, 129);
            this.bttnUpDate.Name = "bttnUpDate";
            this.bttnUpDate.Size = new System.Drawing.Size(79, 23);
            this.bttnUpDate.TabIndex = 6;
            this.bttnUpDate.Text = "UPDATE";
            this.bttnUpDate.UseVisualStyleBackColor = true;
            this.bttnUpDate.Click += new System.EventHandler(this.bttnUpDate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "KD";
            // 
            // numericUpDownKd
            // 
            this.numericUpDownKd.DecimalPlaces = 2;
            this.numericUpDownKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownKd.Location = new System.Drawing.Point(77, 97);
            this.numericUpDownKd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKd.Name = "numericUpDownKd";
            this.numericUpDownKd.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownKd.TabIndex = 6;
            this.numericUpDownKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "KI";
            // 
            // numericUpDownKi
            // 
            this.numericUpDownKi.DecimalPlaces = 2;
            this.numericUpDownKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKi.Location = new System.Drawing.Point(77, 71);
            this.numericUpDownKi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKi.Name = "numericUpDownKi";
            this.numericUpDownKi.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownKi.TabIndex = 4;
            this.numericUpDownKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KP";
            // 
            // numericUpDownKp
            // 
            this.numericUpDownKp.DecimalPlaces = 2;
            this.numericUpDownKp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKp.Location = new System.Drawing.Point(77, 45);
            this.numericUpDownKp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKp.Name = "numericUpDownKp";
            this.numericUpDownKp.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownKp.TabIndex = 2;
            this.numericUpDownKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SET POINT";
            // 
            // numUpDownSetPoint
            // 
            this.numUpDownSetPoint.Location = new System.Drawing.Point(77, 19);
            this.numUpDownSetPoint.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numUpDownSetPoint.Name = "numUpDownSetPoint";
            this.numUpDownSetPoint.Size = new System.Drawing.Size(79, 20);
            this.numUpDownSetPoint.TabIndex = 0;
            this.numUpDownSetPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownSetPoint.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownSetPoint.ValueChanged += new System.EventHandler(this.numUpDownSetPoint_ValueChanged);
            // 
            // sp
            // 
            this.sp.BaudRate = 115200;
            this.sp.PortName = "COM4";
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(8, 41);
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.Size = new System.Drawing.Size(154, 20);
            this.txtBxOutput.TabIndex = 2;
            this.txtBxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxOutput.TextChanged += new System.EventHandler(this.txtBxOutput_TextChanged);
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(8, 93);
            this.txtBxInput.Multiline = true;
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(154, 20);
            this.txtBxInput.TabIndex = 3;
            this.txtBxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxInput.TextChanged += new System.EventHandler(this.txtBxInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SENT DATA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "RECEIVED DATA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxInput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBxOutput);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(215, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 132);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UART Monitor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(741, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "manuel_pat@hotmail.com";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(402, 25);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(533, 328);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(402, 371);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(107, 29);
            this.bttnStart.TabIndex = 13;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 411);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxCom);
            this.Name = "Form1";
            this.Text = "PID Motor Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxCom.ResumeLayout(false);
            this.grpBxCom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSetPoint)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnDisconnect;
        private System.Windows.Forms.Button bttnConnect;
        private System.Windows.Forms.ComboBox cmboxBaudRate;
        private System.Windows.Forms.ComboBox cmbBxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnOFF;
        private System.Windows.Forms.Button bttnUpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownKd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownKp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDownSetPoint;
        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bttnStart;
    }
}

