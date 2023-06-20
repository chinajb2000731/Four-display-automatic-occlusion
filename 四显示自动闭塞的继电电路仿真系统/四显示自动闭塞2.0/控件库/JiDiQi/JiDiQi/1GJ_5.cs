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
    public partial class _1GJ_5 : UserControl
    {
        public _1GJ_5()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        [Description("修改继电器的名字"), Category("自定义属性"), DefaultValue("")]
        public string NameChange { get; set; }
        [Browsable(true)]
        [Description("表示継电器状态，0为后接点接通，1为前接点接通"), Category("自定义属性"), DefaultValue("")]
        public int Flag { get; set; }
        [Browsable(true)]
        [Description("修改接点的序号"), Category("自定义属性"), DefaultValue("")]
        public string Id { get; set; }
        public void JieDian_qian()
        {
            line1.Show();
            line2.Hide();
            line3.Hide();
            line4.Hide();
            line5.Show();
            line6.Show();
            label1.Hide();
            label4.Show();
        }
        public void JieDian_hou()
        {
            line1.Hide();
            line2.Show();
            line3.Show();
            line4.Show();
            line5.Hide();
            line6.Hide();
            label1.Show();
            label4.Hide();
        }
        private void _1GJ_5_Load(object sender, EventArgs e)
        {
            label2.Text = Id;
            label3.Text = NameChange;
            if (Flag == 1)
            {
                JieDian_qian();
            }
            else
            {
                JieDian_hou();
            }
        }
    }
}
