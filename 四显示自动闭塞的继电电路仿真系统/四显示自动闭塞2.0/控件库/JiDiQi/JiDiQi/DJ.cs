using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiDiQi
{
    public partial class DJ : UserControl
    {
        public DJ()
        {
            InitializeComponent();
        }

        //自定义控件的属性
        [Browsable(true)]
        [Description("修改继电器的名字"), Category("自定义属性"), DefaultValue("")]
        public string NameChange { get; set; }
        [Browsable(true)]
        [Description("修改接点状态，0表示后接点接通，1表示前接点接通"), Category("自定义属性"), DefaultValue("")]
        public int Flag { get; set; }
        public void DJ_hou()
        {
            label2.Hide();
            label3.Show();
        }
        public void DJ_qian()
        {
            label2.Show();
            label3.Hide();
        }
        private void DJ_Load(object sender, EventArgs e)
        {
            label1.Text = NameChange;
            if(Flag == 1)
            {
                DJ_qian();
            }
            else
            {
                DJ_hou();
            }
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
