using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Sunny.UI;

namespace WHProject
{ 
    public partial class Form1 : UIForm
    {
       public static string sqlConnStr = @"Server=103.42.30.126;Port=3308;Database=IntelligentGreenhouse;Uid=huanqing;Pwd=huanqing;SslMode=none;";
        /// <summary>
        /// 连接数据库
        /// </summary>
        public static MySqlConnection conn = new MySqlConnection(sqlConnStr);
        
        ///   /// <summary>
        ///记录数据上限 
        /// </summary>
        public const int HokmaNum = 30;
      
        public static string str;
        public static string[] strs;
        public Form1()
        {
           
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取电脑当前可用串口并添加到选项列表中
            portsBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            portsBox.Text = "COM3";
            openStreamBt.BackColor = Color.ForestGreen;
            button1.BackColor = Color.ForestGreen;
            button2.BackColor = Color.ForestGreen;
            button3.BackColor = Color.ForestGreen;
            //temlabel.Text = "--";
            uiThermometer1.Value = 0;
            button1.Enabled = false;
            button1.Symbol = 61534;
     
            button2.Enabled = false;
            button2.Symbol = 61534;
            button3.Enabled = false;
            button3.Symbol = 61534;
            uiScrollingText1.Text = "未连接到设备";
            uiScrollingText1.ForeColor = Color.Black;
            uiToolTip1.SetToolTip(uiSymbolButton1, "查看帮助信息","功能提示",61530, 32, UIColor.Green);
            uiToolTip2.SetToolTip(uiSymbolButton5, "查看帮助信息", "功能提示", 61530, 32, UIColor.Green);
            max = 0;
            min = 100;
            timer2.Start();
            timer5.Start();
            
            
            /*
            try
            {
                conn.Open();
                string sql = @"CREATE TABLE `WH` (
                `id` INT NOT NULL AUTO_INCREMENT,
                `name` VARCHAR(255) NOT NULL,
                PRIMARY KEY(`id`)
                 ); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           */
        }





        private void portMar_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                //因为要访问UI资源，所以需要使用invoke方式同步ui
                this.Invoke((EventHandler)(delegate
                {
                    str = portMar.ReadExisting();
                    ////
                    strs = str.Split('#');
                    if (strs.Length >= 2)
                    {

                        strs = strs[strs.Length - 1].Split('-');

                        uiLedLabel4.Text = strs[0];
                        if (strs.Length > 1)
                        {
                            uiLedLabel3.Text = strs[1];
                        }
                    }
                }
                   )
                );

            }
            catch (Exception ex)
            {
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                
                this.ShowErrorDialog("错误提示", ex.Message, UIStyle.Red, true, 5000);

            }

        }
        public static bool f1 = true, f2 = true, f3 = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (portMar.IsOpen)
            {
                //串口处于开启状态，将发送区文本发送
                portMar.Write("a");
            }
            if (f1)
            {
               
                button1.Text = "关闭风扇";
                button1.BackColor = Color.Firebrick;
            }
            else
            {
                button1.Text = "打开风扇";
                button1.BackColor = Color.ForestGreen;
              

            }
            f1 = !f1;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (portMar.IsOpen)
            {
                //串口处于开启状态，将发送区文本发送
                portMar.Write("b");
            }
            if (f2)
            {
              
                button2.Text = "关闭灯光";
                button2.BackColor = Color.Firebrick;
            }
            else
            {
                button2.Text = "打开灯光";
                button2.BackColor = Color.ForestGreen;
           

            }
            f2 = !f2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            portMar.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(uiLedLabel4.Text);
                Convert.ToInt32(uiLedLabel3.Text);
                conn.Open();
                string sql = @"INSERT INTO `IntelligentGreenhouse`.
                `data`(`temp`, `source`, `humidity`) 
                 VALUES ('"+ uiLedLabel4.Text+ "', '上位机', '"+ uiLedLabel3.Text+ "'); ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

                uiThermometer1.Value= Convert.ToInt32(uiLedLabel4.Text);
                conn.Close();
            }
            catch {
                
            }
        }
        private int a, b;
        /// <summary>
        /// 向服务器更新配置温度，湿度
        /// </summary>
        public void  sqlInSever() {
            try
            {
                conn.Open();
                string sql = @"UPDATE `IntelligentGreenhouse`.`config` 
                SET `mintemp` = '"+ setTemLabelmin.Text + "', `maxtemp` = '"+ setTemLabelmax.Text + "', `humidity` = '"+ label16.Text + "' WHERE `id` = 0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(numericUpDown1.Value.ToString()); 
            b=Convert.ToInt32(numericUpDown2.Value.ToString());
            if (b>=a) {
                setTemLabelmin.Text =a.ToString();
                setTemLabelmax.Text =b.ToString();
                sqlInSever();
            }
            else
            {
                string errorMessage = "最高温度不能低于最低温度！";

                this.ShowErrorDialog("提示",errorMessage, UIStyle.Red, true, 5000);
            }
        }
        public int tem, mu;
        public bool cont1 = true, cont2 = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                mu = Convert.ToInt32(label16.Text);
                tem = Convert.ToInt32(uiLedLabel4.Text);
               /*
                if (portMar.IsOpen)
                {
                    tem = Convert.ToInt32(temlabel.Text);
                    if (tem > max)
                    {
                        max = tem;
                        maxTT = DateTime.Now;
                    }
                    if (tem < min)
                    {
                        min = tem;
                        minTT = DateTime.Now;
                    }
                }*/
                if (sw && portMar.IsOpen)
                {
                 

                    if (tem > Convert.ToInt32(setTemLabelmax.Text))
                    {
                        cont1 = false;
                        button1.Enabled = false;
                        button1.Symbol=61475;
                        button2.Enabled = true;
                        button2.Symbol = 57453;
                        uiScrollingText1.Text = "温室过热，风扇强制启动中";
                        Console.Beep(2280, 1500);
                        uiScrollingText1.ForeColor = Color.Red;
                        if (f2 == false) {
                            f2 = true;
                            button2.Text = "打开灯光";
                            button2.BackColor = Color.ForestGreen;
                            portMar.Write("b");
                        }else
                        if (f1 == true)
                        {
                            f1 = false;
                            button1.Text = "关闭风扇";
                            button1.BackColor = Color.Firebrick;
                            portMar.Write("a");

                        }
                    }
                    else
                    if (tem < Convert.ToInt32(setTemLabelmin.Text))
                    {
                        cont1 = false;
                        button1.Symbol = 57453;
                        button1.Enabled = true;
                        button2.Symbol = 61475;
                        button2.Enabled = false;
                       
                        uiScrollingText1.Text = "温度过低，补光灯强制启动中";
                        uiScrollingText1.ForeColor = Color.Red;
                        Console.Beep(2280, 1500);
                        if (f1 == false)
                        {
                            f1= true;
                            button2.Text = "打开风扇";
                            button2.BackColor = Color.ForestGreen;
                            portMar.Write("a");
                        }else
                        if (f2 == true)
                        {
                            f2 = false;
                            button2.Text = "关闭灯光";
                            button2.BackColor = Color.Firebrick;
                            portMar.Write("b");


                        }
                    }
                    else
                    {
                        if (f1 == false)
                        {
                            f1 = true;
                            button2.Text = "打开风扇";
                            button2.BackColor = Color.ForestGreen;
                            portMar.Write("a");
                        }else
                        if (f2 == false)
                        {
                            f2 = true;
                            button2.Text = "打开灯光";
                            button2.BackColor = Color.ForestGreen;
                            portMar.Write("b");
                        }
                        button2.Enabled = true;
                        button2.Symbol = 57453;
                        button1.Enabled = true;
                        button1.Symbol = 57453;
                        cont1 = true;
                    }
                }
                else if (portMar.IsOpen)
                {
                    button3.Enabled = true;
                    button3.Symbol = 57453;
                    button1.Enabled = true;
                    button1.Symbol = 57453;
                    button2.Enabled = true;
                    button2.Symbol = 57453;
               
                  
                    uiScrollingText1.Text = "提示：智能控制已关闭";
                    uiScrollingText1.ForeColor = Color.ForestGreen;
                }
            }
            catch {
                ;
            }
        }
        /*
                    if (mu> Convert.ToInt32(MubNum.Text)) {
                        button3.Enabled = false;
                        textBox1.Text = "湿度过低，水闸强制启动中";
                        textBox1.BackColor = Color.Red;
                        if (f3 == true)
                        {
                            f3 = false;
                            button3.Text = "打开水闸";
                            button3.BackColor = Color.Green;
                            portMar.Write("c");


                        }
                    } else if (mu< Convert.ToInt32(MubNum.Text)){
                        button3.Enabled = true;
                        textBox1.Text = "一切正常";
                        textBox1.BackColor = Color.Green;
                        if (f3 == false)
                        {
                            f3 = true;
                            button3.Text = "关闭水闸";
                            button3.BackColor = Color.Firebrick;
                            portMar.Write("c");


                        }

                    }else{
                        button3.Enabled = true;
                        textBox1.Text = "一切正常";
                        textBox1.BackColor = Color.ForestGreen;
                    }*/
        public static bool sw = false;//自动控制开关
      
        private void Init_Chart()
        {
            #region chart1  
            chart1.Series[0].IsValueShownAsLabel = true;//让点集0在图像上显示数值
            chart1.Series[0].SmartLabelStyle.Enabled = true;
            chart1.Series[0].XValueType = ChartValueType.DateTime;//坐标轴type改为时间

            //去掉滚动条的按钮
            chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.None;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            chart1.ChartAreas[0].AxisX.ScrollBar.Size = 20;
            chart1.ChartAreas[0].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 20;
            chart1.ChartAreas[0].AxisX.ScaleView.MinSize = 15;
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 1;
            chart1.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            //这个interval可以用来修改显示间隔
            chart1.ChartAreas[0].AxisX.Interval = DateTime.Parse("00:00:01").Second;
            chart1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            //显示格式为时:分:秒
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            #endregion
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            //让滚动条滚动到最新位置
            this.chart1.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
            string now = DateTime.Now.ToLongTimeString();
            //转换time的格式用于输出
            DateTime time = DateTime.Parse(now);
            //在点集0(serials[0])中加入新的点XY
            //TIP:如果你使用数组存放要绘制的点,每次绘图从上一次绘制结束的位置开始即可
            //不需要每次画图都从第一个点开始绘制
            this.chart1.Series[0].Points.AddXY(time, uiLedLabel4.Text);
            ///记录操作
            if (chart1.Series[0].Points.Count > HokmaNum)
            {
                // 保留最后一个点
                DataPoint lastPoint = chart1.Series[0].Points.Last();
                /*
                string path = "temp.ini"; // 替换为你想要保存数据的txt文件路径
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    // 将最后一个点的坐标写入文件
                    string line ="时间："+ lastPoint.XValue.ToString() + "  温度：" + lastPoint.YValues[0].ToString()
                        +" maxTT:"+maxTT+" max:"+max+" minTT:"+minTT+" min:"+min;
                    streamWriter.WriteLine(line);
                    max = 0;
                    min = 100;
                }*/
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.Add(lastPoint);
            }
        }
        private Form2 fr2;//帮助窗体

        private void yusheBut_Click(object sender, EventArgs e)
        {
            string str = yusheBox.Text;
            if (str == "玉米")
            {
                setTemLabelmin.Text = "20";
                setTemLabelmax.Text = "30";
            }
            else if (str == "花生")
            {
                setTemLabelmin.Text = "25";
                setTemLabelmax.Text = "30";
            }
            else if (str == "小麦")
            {
                setTemLabelmin.Text = "15";
                setTemLabelmax.Text = "20";
            }
            else if (str == "土豆")
            {
                setTemLabelmin.Text = "18";
                setTemLabelmax.Text = "22";
            }
            sqlInSever();
        }
        public int max, min;
        public DateTime maxTT, minTT;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://103.42.30.126/");
        
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                ///
                this.ShowStatusForm(100, "数据加载中......", 0);
                for (int i = 0; i < 96; i++)
                {
                    SystemEx.Delay(20);
                    this.SetStatusFormDescription("数据加载中(" + i + "%)......");
                    this.SetStatusFormStepIt();
                }

                ///
                conn.Open();
                string sql = @"SELECT * FROM `IntelligentGreenhouse`.
                `config` LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    setTemLabelmin.Text = reader.GetString("mintemp");
                    setTemLabelmax.Text = reader.GetString("maxtemp");
                    label16.Text = reader.GetString("humidity");
                    numericUpDown1.Value = Convert.ToInt32(reader.GetString("mintemp"));
                    numericUpDown2.Value = Convert.ToInt32(reader.GetString("maxtemp"));
                    numericUpDown3.Value = Convert.ToInt32(reader.GetString("humidity"));
                }
                conn.Close();
                this.HideStatusForm();
            }
            catch (Exception ex)
            {
                this.HideStatusForm();
                Console.WriteLine(ex.Message);
                this.ShowErrorDialog("错误","错误！无法连接网络。", UIStyle.Red, true, 5000);

            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Form2();
                fr2.Show();
            }
            else
            {
                fr2.Focus();
            }
        }

        private void uiTurnSwitch1_ValueChanged(object sender, bool value)
        {
            if (value)
            {
                sw = false;
            }
            else
            {
                sw = true;
                if (portMar.IsOpen)
                {
                    uiScrollingText1.Text = "一切正常";
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                mu = Convert.ToInt32(label16.Text);
                tem = Convert.ToInt32(uiLedLabel4.Text);
                /*
                 if (portMar.IsOpen)
                 {
                     tem = Convert.ToInt32(temlabel.Text);
                     if (tem > max)
                     {
                         max = tem;
                         maxTT = DateTime.Now;
                     }
                     if (tem < min)
                     {
                         min = tem;
                         minTT = DateTime.Now;
                     }
                 }*/
                if (sw && portMar.IsOpen)
                {



                    if (mu > Convert.ToInt32(uiLedLabel3.Text))
                    {
                        cont2 = false;
                        button3.Enabled = false;
                        button3.Symbol = 61475;
                        uiScrollingText1.Text = "湿度过低，水闸强制启动中";
                        uiScrollingText1.ForeColor = Color.Red;
                        if (f3 == true)
                        {
                            f3 = false;
                            button3.Text = "关闭水闸";
                            button3.BackColor = Color.Firebrick;
                            portMar.Write("c");


                        }
                    }
                    else if (mu <= Convert.ToInt32(uiLedLabel3.Text))
                    {
                        cont2 = true;
                        button3.Enabled = true;
                        button3.Symbol = 57453;
                        if (cont2 & cont1)
                        {
                            uiScrollingText1.Text = "一切正常";
                            uiScrollingText1.ForeColor = Color.Green;
                        }
                        if (f3 == false)
                        {
                            f3 = true;
                            button3.Text = "打开水闸";
                            button3.BackColor = Color.Green;
                            portMar.Write("c");


                        }

                    }
                    
                }
                else if (portMar.IsOpen)
                {
                    button3.Enabled = true;
                    button3.Symbol = 57453;
                    button1.Enabled = true;
                    button1.Symbol = 57453;
                    button2.Enabled = true;
                    button2.Symbol = 57453;
                    uiScrollingText1.Text = "提示：智能控制已关闭";
                    uiScrollingText1.ForeColor = Color.ForestGreen;
                }
            }
            catch
            {
                ;
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            label16.Text = numericUpDown3.Value.ToString();
            sqlInSever();
        }
        
        private void timer4_Tick(object sender, EventArgs e)
        {
            uiLedLabel2.Text = DateTime.Now.ToString();
        }
        /*
                private void solvebut_Click(object sender, EventArgs e)
                {
                    if (portMar.IsOpen) {
                        string str = "最高温度：" + max + "℃，出现在" + maxTT.ToString("MM月dd日 HH:mm:ss") + "\n"
                      + "最低温度：" + min + "℃，出现在" + minTT.ToString("MM月dd日 HH:mm:ss") + "\n"
                      + "温差：" + (max - min) + "℃\n";
                        MessageBox.Show(str, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }*/
        private async void solvebut_Click(object sender, EventArgs e)
        {
            if (portMar.IsOpen)
            {
                // 使用异步方式从指定URL获取数据
                using (var client = new WebClient())
                {
                    var jsonContent = await client.DownloadStringTaskAsync(new Uri("http://103.42.30.126/ajax?act=AnalysisMinute&minute="+ numericUpDown4.Value));

                    // 反序列化JSON数据
                    dynamic dataObject = JsonConvert.DeserializeObject(jsonContent);

                    // 检查返回的状态码是否为0
                    if ((int)dataObject["code"] == 0)
                    {
                        // 获取并拼接要显示的数据
                        string str = $"自动开启降温次数：{dataObject["data"]["fan"]}\n"
                                  + $"自动开启增温次数：{dataObject["data"]["light"]}\n"
                                  + $"自动开启灌溉次数：{dataObject["data"]["sluice"]}\n"
                                  + $"最低温度：{dataObject["data"]["minTemp"]}℃\n"
                                  + $"最高温度：{dataObject["data"]["maxTemp"]}℃\n"+
                                  $"最大温差：{Convert.ToInt32(dataObject["data"]["maxTemp"])- Convert.ToInt32(dataObject["data"]["minTemp"])}℃\n";
                        this.ShowInfoDialog("信息提示", str,UIStyle.Gray,true);
                    }
                    else
                    {
                        this.ShowErrorDialog("错误提示", "无法获取或解析服务器数据", UIStyle.Red, true, 5000);
                    }
                }
            }
            else
            {
                this.ShowErrorDialog("错误提示", "端口未打开，无法获取远程数据", UIStyle.Red, true, 5000);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (portMar.IsOpen)
            {
                //串口处于开启状态，将发送区文本发送
                portMar.Write("c");
            }
            if (f3)
            {
                
                button3.Text = "关闭水闸";
                button3.BackColor = Color.Firebrick;
            }
            else
            {

                button3.Text = "打开水闸";
                button3.BackColor = Color.ForestGreen;
                portsBox.Enabled = true;

            }
            f3 = !f3;
        }

        private void openStreamBt_Click(object sender, EventArgs e)
        {
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (portMar.IsOpen)
                {
                    //串口已经处于打开状态
                    portMar.Close();    //关闭串口
                    openStreamBt.Text = "打开通道";
                    openStreamBt.BackColor = Color.ForestGreen;
                    portsBox.Enabled = true;
                    button1.Enabled = false;
                    button1.Symbol = 61534;
                    button2.Enabled = false;
                    button2.Symbol = 61534;
                    button3.Enabled = false;
                    button3.Symbol = 61534;
                 
                    uiLedLabel4.Text = "--";
                    uiLedLabel3.Text = "--";
                    timer1.Stop();
                    uiThermometer1.Value = 0;
                    uiScrollingText1.Text = "未连接到设备";
                    uiScrollingText1.ForeColor = Color.Black;
                    Init_Chart();
                    timer3.Stop();
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    portsBox.Enabled = false;
                    button1.Enabled = true;
                    button1.Symbol = 57453;
                    button2.Enabled = true;
                    button2.Symbol = 57453;
                    button3.Enabled = true;
                    button3.Symbol = 57453;
                    portMar.PortName = portsBox.Text;
                    portMar.BaudRate = 115200;
                    portMar.DataBits = 8;
                    portMar.Parity = System.IO.Ports.Parity.None;
                    portMar.StopBits = System.IO.Ports.StopBits.One;
                    portMar.Open();     //打开串口
                    openStreamBt.Text = "关闭通道";
                    openStreamBt.BackColor = Color.Firebrick;
                    timer1.Start();
                    uiScrollingText1.Text = "一切正常";
                    uiScrollingText1.ForeColor = Color.ForestGreen;
                    Init_Chart();
                    timer3.Start();
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                portMar = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                portsBox.Items.Clear();
                portsBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                openStreamBt.Text = "打开串口";
                openStreamBt.BackColor = Color.ForestGreen;
                this.ShowErrorDialog("错误","通道无法连接：\n"+ex.Message,UIStyle.Red,true,5000);
                portsBox.Enabled = true;
                button1.Enabled = false;
                button1.Symbol = 61534;
              
                button2.Enabled = false;
                button2.Symbol = 61534;
                button3.Enabled = false;
                button3.Symbol = 61534;
                uiLedLabel4.Text = "--";
                timer1.Stop();
                uiThermometer1.Value = 0;
                uiScrollingText1.Text = "未连接到设备";
                uiScrollingText1.ForeColor = Color.Black;
                Init_Chart();
                timer3.Stop();
            }
        }

        
    }
}

