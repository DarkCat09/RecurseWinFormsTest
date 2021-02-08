using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecurseButtonsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Button b1 = new Button();
            b1.Text = "Button";
            b1.Size = new Size(55, 30);
            b1.Location = new Point(rand.Next(0, Size.Width - 55), rand.Next(0, Size.Height - 30));
            b1.Click += new EventHandler(button1_Click);
            Controls.Add(b1);
        }
    }
}
