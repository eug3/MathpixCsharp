using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MathpixCsharpU
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           }

        private void login_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id=textBox1.Text;
            Properties.Settings.Default.key=textBox2.Text;
            if (this.officialChoose.Checked)
            {
                Properties.Settings.Default.isOfficial = true;
            }
            else
            {
                Properties.Settings.Default.isOfficial = false;
            }
            this.Dispose();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/eug3/MathpixCsharpU/blob/master/OfficialApi.md#%E4%BD%BF%E7%94%A8%E5%AE%98%E6%96%B9api%E6%95%99%E7%A8%8B");
        }
    }
}
