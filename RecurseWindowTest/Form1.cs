using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecurseWindowTest
{
    public partial class Form1 : Form
    {
        private int iter_num;
        private int mode;
        public Form1(int iteration, int _mode = 0)
        {
            InitializeComponent();
            iter_num = iteration;
            mode = _mode;
            Size = GetSizeByIterNum();
            Text = $"{Size.Width}x{Size.Height}";
            if (mode == 2)
                new Form1(iter_num+1, mode).ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1(iter_num+1, mode).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (mode)
            {
                case 1:
                case 2:
                    e.Cancel = true;
                    break;
                default:
                    if (Size.Width < 300)
                        Application.Exit();
                    /*else
                        new Form1(iter_num + 1, mode).ShowDialog();*/
                    break;
            }
        }

        private Size GetSizeByIterNum()
        {
            int width = 800;
            for (int i = 0; i < iter_num; ++i)
            {
                try
                {
                    width -= (width / 100 * 20);
                }
                catch (Exception) {
                    MessageBox.Show("w!!!", "Отладка");
                }
            }

            int height = 500;
            for (int j = 0; j < iter_num; ++j)
            {
                try
                {
                    height -= (height / 100 * 20);
                }
                catch (Exception) {
                    MessageBox.Show("h!!!", "Отладка");
                }
            }

            return new Size(width, height);
        }
    }
}
