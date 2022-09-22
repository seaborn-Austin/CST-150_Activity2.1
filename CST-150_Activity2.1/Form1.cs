using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wtBtn_Click(object sender, EventArgs e)
        {
            double wtPounds = double.Parse(wtLbTxt.Text);
            double wtKg = wtPounds * 0.45359237;
            wtKgTxt.Text = wtKg.ToString();
        }
    }
}
