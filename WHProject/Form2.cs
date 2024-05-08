using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            string[] lines = File.ReadAllLines("head.ini");
            foreach (string line in lines)
            {
                textBox1.AppendText(line + Environment.NewLine);
            }
        }
    }
}
