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
    public partial class _2GJ : UserControl
    {
        public _2GJ()
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
        public void JieDian_hou()
        {
            line1.Show();
            line2.Hide();
            line3.Hide();
            line4.Hide();
            line5.Show();
            line6.Show();
            label2.Show();
            label4.Hide();
        }
        public void JieDian_qian()
        {
            line1.Hide();
            line2.Show();
            line3.Show();
            line4.Show();
            line5.Hide();
            line6.Hide();
            label2.Hide();
            label4.Show();
        }
        private void _2GJ_Load(object sender, EventArgs e)
        {
           
            if (Flag == 0)
            {
                JieDian_qian();
            }
            else
            {
                JieDian_hou();
            }

        }

        private void line1_Click(object sender, EventArgs e)
        {

        }
    }
}
