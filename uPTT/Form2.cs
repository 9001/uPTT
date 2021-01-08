using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uPTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Font = new Font(this.Font.FontFamily, this.Font.SizeInPoints * 1.3f);
            this.Show();
            Application.DoEvents();
            this.Left -= (this.Width - w) / 2;
            this.Top -= (this.Height - h) / 2;
            Application.DoEvents();
        }
    }
}
