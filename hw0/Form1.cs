using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Time = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
            DateTime strTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Time);
            Text = Convert.ToString(strTime);
            BackgroundImage = Properties.Resources.baku;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Time = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime strTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Time);
            Text = Convert.ToString(strTime);
            BackgroundImage = Properties.Resources.london;
        }
    }
}
