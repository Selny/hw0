using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw0_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                btn.Dispose();
                Random random = new Random();
                int x = random.Next(Width - 120);
                int y = random.Next(Height - 60);

                Button button = new Button
                {
                    Size = new Size(120, 60),
                    Location = new Point(x, y),
                    Text = "Don't touch this",
                };

                button.Click += button1_MouseHover;

                Controls.Add(button);

            }
        }
    }
}
