
namespace WHProject
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portMar = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.setTemLabelmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.uiLedLabel4 = new Sunny.UI.UILedLabel();
            this.uiRuler3 = new Sunny.UI.UIRuler();
            this.uiThermometer1 = new Sunny.UI.UIThermometer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.yusheBut = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.yusheBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.setTemLabelmax = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.solvebut = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.openStreamBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portsBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MubNum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiTurnSwitch1 = new Sunny.UI.UITurnSwitch();
            this.uiLine2 = new Sunny.UI.UILine();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiScrollingText1 = new Sunny.UI.UIScrollingText();
            this.uiLedLabel2 = new Sunny.UI.UILedLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvebut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // portMar
            // 
            this.portMar.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.portMar_DataReceived);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "打开风扇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(335, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 72);
            this.button2.TabIndex = 17;
            this.button2.Text = "打开灯";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(179, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 72);
            this.button3.TabIndex = 18;
            this.button3.Text = "打开水闸";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(498, 589);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "温度";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(495, 228);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "温度变化";
            // 
            // setTemLabelmin
            // 
            this.setTemLabelmin.AutoSize = true;
            this.setTemLabelmin.Font = new System.Drawing.Font("黑体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTemLabelmin.ForeColor = System.Drawing.Color.Blue;
            this.setTemLabelmin.Location = new System.Drawing.Point(107, 187);
            this.setTemLabelmin.Name = "setTemLabelmin";
            this.setTemLabelmin.Size = new System.Drawing.Size(97, 68);
            this.setTemLabelmin.TabIndex = 22;
            this.setTemLabelmin.Text = "10";
            this.setTemLabelmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WHProject.Resource1.pci1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(356, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 86);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "预定温度";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 20.94783F);
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(119, 284);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(189, 46);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(333, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 84);
            this.button4.TabIndex = 26;
            this.button4.Text = "设定温度";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uiLine1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.uiRuler3);
            this.panel2.Controls.Add(this.uiThermometer1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.yusheBut);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.yusheBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.setTemLabelmax);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.setTemLabelmin);
            this.panel2.Location = new System.Drawing.Point(498, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 540);
            this.panel2.TabIndex = 27;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineSize = 5;
            this.uiLine1.Location = new System.Drawing.Point(25, -3);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(434, 29);
            this.uiLine1.TabIndex = 117;
            this.uiLine1.Text = "当前温度";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.uiLedLabel1);
            this.panel5.Controls.Add(this.uiLedLabel4);
            this.panel5.Location = new System.Drawing.Point(43, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 119);
            this.panel5.TabIndex = 116;
            // 
            // uiLedLabel1
            // 
            this.uiLedLabel1.BackColor = System.Drawing.Color.Black;
            this.uiLedLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLedLabel1.ForeColor = System.Drawing.Color.Lime;
            this.uiLedLabel1.IntervalOn = 5;
            this.uiLedLabel1.Location = new System.Drawing.Point(99, 3);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(85, 102);
            this.uiLedLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel1.StyleCustomMode = true;
            this.uiLedLabel1.TabIndex = 115;
            this.uiLedLabel1.Text = "°C";
            // 
            // uiLedLabel4
            // 
            this.uiLedLabel4.BackColor = System.Drawing.Color.Black;
            this.uiLedLabel4.Font = new System.Drawing.Font("宋体", 36F);
            this.uiLedLabel4.ForeColor = System.Drawing.Color.Lime;
            this.uiLedLabel4.IntervalOn = 5;
            this.uiLedLabel4.Location = new System.Drawing.Point(14, 3);
            this.uiLedLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel4.Name = "uiLedLabel4";
            this.uiLedLabel4.Size = new System.Drawing.Size(114, 102);
            this.uiLedLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel4.StyleCustomMode = true;
            this.uiLedLabel4.TabIndex = 99;
            this.uiLedLabel4.Text = "--";
            // 
            // uiRuler3
            // 
            this.uiRuler3.BackColor = System.Drawing.Color.Transparent;
            this.uiRuler3.Direction = Sunny.UI.UITrackBar.BarDirection.Vertical;
            this.uiRuler3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRuler3.Location = new System.Drawing.Point(303, 25);
            this.uiRuler3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRuler3.MinorCount = 4;
            this.uiRuler3.Name = "uiRuler3";
            this.uiRuler3.Size = new System.Drawing.Size(35, 137);
            this.uiRuler3.TabIndex = 114;
            this.uiRuler3.Text = "uiRuler3";
            // 
            // uiThermometer1
            // 
            this.uiThermometer1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiThermometer1.Location = new System.Drawing.Point(347, 32);
            this.uiThermometer1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiThermometer1.Name = "uiThermometer1";
            this.uiThermometer1.Size = new System.Drawing.Size(49, 129);
            this.uiThermometer1.TabIndex = 113;
            this.uiThermometer1.Text = "uiThermometer1";
            this.uiThermometer1.Value = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Location = new System.Drawing.Point(256, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 47);
            this.panel4.TabIndex = 40;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(5, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(237, 19);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "点击此处访问云端管理系统";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // yusheBut
            // 
            this.yusheBut.ForeColor = System.Drawing.Color.Black;
            this.yusheBut.Location = new System.Drawing.Point(330, 427);
            this.yusheBut.Name = "yusheBut";
            this.yusheBut.Size = new System.Drawing.Size(143, 47);
            this.yusheBut.TabIndex = 38;
            this.yusheBut.Text = "使用预设";
            this.yusheBut.UseVisualStyleBackColor = true;
            this.yusheBut.Click += new System.EventHandler(this.yusheBut_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("黑体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(7, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 22);
            this.label12.TabIndex = 37;
            this.label12.Text = "预设调控";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yusheBox
            // 
            this.yusheBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yusheBox.FormattingEnabled = true;
            this.yusheBox.Items.AddRange(new object[] {
            "玉米",
            "花生",
            "小麦",
            "土豆"});
            this.yusheBox.Location = new System.Drawing.Point(119, 438);
            this.yusheBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 10);
            this.yusheBox.Name = "yusheBox";
            this.yusheBox.Size = new System.Drawing.Size(189, 27);
            this.yusheBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("黑体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(7, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "高温调控";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(7, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "低温调控";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.Font = new System.Drawing.Font("宋体", 20.94783F);
            this.numericUpDown2.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown2.Location = new System.Drawing.Point(119, 348);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(189, 46);
            this.numericUpDown2.TabIndex = 32;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(196, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 68);
            this.label7.TabIndex = 31;
            this.label7.Text = "~";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setTemLabelmax
            // 
            this.setTemLabelmax.AutoSize = true;
            this.setTemLabelmax.Font = new System.Drawing.Font("黑体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTemLabelmax.ForeColor = System.Drawing.Color.Blue;
            this.setTemLabelmax.Location = new System.Drawing.Point(253, 187);
            this.setTemLabelmax.Name = "setTemLabelmax";
            this.setTemLabelmax.Size = new System.Drawing.Size(97, 68);
            this.setTemLabelmax.TabIndex = 30;
            this.setTemLabelmax.Text = "25";
            this.setTemLabelmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // solvebut
            // 
            this.solvebut.BackColor = System.Drawing.Color.White;
            this.solvebut.BackgroundImage = global::WHProject.Resource1.R_C;
            this.solvebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.solvebut.Location = new System.Drawing.Point(900, 636);
            this.solvebut.Name = "solvebut";
            this.solvebut.Size = new System.Drawing.Size(62, 50);
            this.solvebut.TabIndex = 37;
            this.solvebut.TabStop = false;
            this.solvebut.Click += new System.EventHandler(this.solvebut_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.label11.Location = new System.Drawing.Point(880, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "智能分析";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // openStreamBt
            // 
            this.openStreamBt.Font = new System.Drawing.Font("宋体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openStreamBt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openStreamBt.Location = new System.Drawing.Point(262, 58);
            this.openStreamBt.Name = "openStreamBt";
            this.openStreamBt.Size = new System.Drawing.Size(189, 45);
            this.openStreamBt.TabIndex = 0;
            this.openStreamBt.Text = "打开通道";
            this.openStreamBt.UseVisualStyleBackColor = true;
            this.openStreamBt.Click += new System.EventHandler(this.openStreamBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(69, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "串  口";
            // 
            // portsBox
            // 
            this.portsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(102, 71);
            this.portsBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 10);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(142, 27);
            this.portsBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.MubNum);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(30, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 314);
            this.panel1.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("黑体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(195, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 68);
            this.label16.TabIndex = 39;
            this.label16.Text = "30";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WHProject.Resource1._3;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::WHProject.Resource1._3;
            this.pictureBox4.Location = new System.Drawing.Point(312, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 68);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(33, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 39;
            this.label15.Text = "预定湿度";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(271, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 46);
            this.button5.TabIndex = 39;
            this.button5.Text = "设定湿度";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.White;
            this.numericUpDown3.Font = new System.Drawing.Font("宋体", 20.94783F);
            this.numericUpDown3.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown3.Location = new System.Drawing.Point(118, 219);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(142, 46);
            this.numericUpDown3.TabIndex = 39;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("黑体", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(18, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 22);
            this.label14.TabIndex = 39;
            this.label14.Text = "预设湿度";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WHProject.Resource1._3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::WHProject.Resource1._3;
            this.pictureBox3.Location = new System.Drawing.Point(312, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 68);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // MubNum
            // 
            this.MubNum.AutoSize = true;
            this.MubNum.Font = new System.Drawing.Font("黑体", 41.94783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MubNum.ForeColor = System.Drawing.Color.Blue;
            this.MubNum.Location = new System.Drawing.Point(195, 33);
            this.MubNum.Name = "MubNum";
            this.MubNum.Size = new System.Drawing.Size(97, 68);
            this.MubNum.TabIndex = 39;
            this.MubNum.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.label13.Location = new System.Drawing.Point(34, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 39;
            this.label13.Text = "当前湿度";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uiTurnSwitch1);
            this.panel3.Controls.Add(this.uiLine2);
            this.panel3.Location = new System.Drawing.Point(28, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 190);
            this.panel3.TabIndex = 39;
            // 
            // uiTurnSwitch1
            // 
            this.uiTurnSwitch1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiTurnSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.uiTurnSwitch1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch1.Location = new System.Drawing.Point(134, 3);
            this.uiTurnSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch1.Name = "uiTurnSwitch1";
            this.uiTurnSwitch1.Size = new System.Drawing.Size(160, 160);
            this.uiTurnSwitch1.TabIndex = 80;
            this.uiTurnSwitch1.Text = "uiTurnSwitch1";
            this.uiTurnSwitch1.ValueChanged += new Sunny.UI.UITurnSwitch.OnValueChanged(this.uiTurnSwitch1_ValueChanged);
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.LineSize = 10;
            this.uiLine2.Location = new System.Drawing.Point(0, 159);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(423, 29);
            this.uiLine2.TabIndex = 28;
            this.uiLine2.Text = "智能控制开关";
            // 
            // timer5
            // 
            this.timer5.Interval = 4000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.White;
            this.numericUpDown4.Font = new System.Drawing.Font("宋体", 20.94783F);
            this.numericUpDown4.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown4.Location = new System.Drawing.Point(884, 715);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(91, 46);
            this.numericUpDown4.TabIndex = 41;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 13.77391F);
            this.label17.Location = new System.Drawing.Point(896, 778);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 22);
            this.label17.TabIndex = 41;
            this.label17.Text = "分钟内";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.IsCircle = true;
            this.uiSymbolButton1.Location = new System.Drawing.Point(1004, 43);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(62, 49);
            this.uiSymbolButton1.Symbol = 62108;
            this.uiSymbolButton1.SymbolOffset = new System.Drawing.Point(0, 2);
            this.uiSymbolButton1.SymbolSize = 48;
            this.uiSymbolButton1.TabIndex = 42;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            this.uiToolTip1.ToolTipTitle = "提示：";
            // 
            // uiScrollingText1
            // 
            this.uiScrollingText1.Active = true;
            this.uiScrollingText1.BackColor = System.Drawing.Color.Black;
            this.uiScrollingText1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.uiScrollingText1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiScrollingText1.ForeColor = System.Drawing.Color.Red;
            this.uiScrollingText1.Location = new System.Drawing.Point(127, 739);
            this.uiScrollingText1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollingText1.Name = "uiScrollingText1";
            this.uiScrollingText1.Offset = 30;
            this.uiScrollingText1.ScrollingType = Sunny.UI.UIScrollingText.UIScrollingType.LeftToRight;
            this.uiScrollingText1.Size = new System.Drawing.Size(324, 35);
            this.uiScrollingText1.Style = Sunny.UI.UIStyle.Custom;
            this.uiScrollingText1.StyleCustomMode = true;
            this.uiScrollingText1.TabIndex = 75;
            this.uiScrollingText1.Text = "设备未连接";
            // 
            // uiLedLabel2
            // 
            this.uiLedLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLedLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLedLabel2.Location = new System.Drawing.Point(127, 782);
            this.uiLedLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel2.Name = "uiLedLabel2";
            this.uiLedLabel2.Size = new System.Drawing.Size(324, 35);
            this.uiLedLabel2.TabIndex = 76;
            this.uiLedLabel2.Text = "00:00:00";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 13.772F);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(26, 747);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 77;
            this.uiLabel1.Text = "运行情况";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 13.772F);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(26, 789);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 78;
            this.uiLabel2.Text = "当前时间";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WHProject.Resource1.pic2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 830);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLedLabel2);
            this.Controls.Add(this.uiScrollingText1);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openStreamBt);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.solvebut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "智能控制终端V2.0";
            this.ZoomScaleRect = new System.Drawing.Rectangle(18, 18, 877, 761);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solvebut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort portMar;//串口管理
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label setTemLabelmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label setTemLabelmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox solvebut;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button yusheBut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox yusheBox;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button openStreamBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portsBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label MubNum;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label17;
        private Sunny.UI.UIThermometer uiThermometer1;
        private Sunny.UI.UIRuler uiRuler3;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private System.Windows.Forms.Panel panel5;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UITurnSwitch uiTurnSwitch1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIScrollingText uiScrollingText1;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}

