using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xianquan2
{
    public partial class xianquan: UserControl
    {
        public xianquan()
        {
            InitializeComponent();
        }
        //自定义控件的属性
        [Browsable(true)]
        [Description("修改线圈的名字"), Category("自定义属性"), DefaultValue("")]
        public string NameChange { get; set; }
        [Browsable(true)]
        [Description("修改接点状态，0表示落下，1表示吸起"), Category("自定义属性"), DefaultValue("")]
        public int Flag { get; set; }
        public void XQ_luoxia()
        {
            lineShape19.Hide();
            lineShape20.Show();
            lineShape1.BorderColor = Color.Red;
            lineShape3.BorderColor = Color.Red;
            lineShape5.BorderColor = Color.Red;
            lineShape13.BorderColor = Color.Red;
            lineShape15.BorderColor = Color.Red;
            lineShape20.BorderColor = Color.Red;
            lineShape16.BorderColor = Color.Red;
            ovalShape2.BackColor= Color.Red;
            ovalShape1.BackColor = Color.White;

            lineShape2.BorderColor = Color.Black;
            lineShape4.BorderColor = Color.Black;
            lineShape12.BorderColor = Color.Black;
            lineShape14.BorderColor = Color.Black;
            lineShape19.BorderColor = Color.Black;
            lineShape27.BorderColor = Color.Black;
            lineShape30.BorderColor = Color.Black;
            lineShape33.BorderColor = Color.Black;
            lineShape34.BorderColor = Color.Black;
            lineShape35.BorderColor = Color.Black;

        }
        public void XQ_xiqi()
        {
            lineShape19.Show();
            lineShape20.Hide();
            lineShape1.BorderColor = Color.Red;
            lineShape2.BorderColor = Color.Red;
            lineShape4.BorderColor = Color.Red;
            lineShape12.BorderColor = Color.Red;
            lineShape14.BorderColor = Color.Red;
            lineShape19.BorderColor = Color.Red;
            lineShape16.BorderColor = Color.Red;
            lineShape27.BorderColor = Color.Red;
            lineShape30.BorderColor = Color.Red;
            lineShape33.BorderColor = Color.Red;
            lineShape34.BorderColor = Color.Red;
            lineShape35.BorderColor = Color.Red;
            ovalShape1.BackColor = Color.Lime;
            ovalShape2.BackColor = Color.White;

            lineShape3.BorderColor = Color.Black;
            lineShape5.BorderColor = Color.Black;
            lineShape13.BorderColor = Color.Black;
            lineShape15.BorderColor = Color.Black;
            lineShape20.BorderColor = Color.Black;
        }
       

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Text = NameChange;
            if (Flag == 0)
            {
                XQ_luoxia();
            }
            else
            {
                XQ_xiqi();
            }
        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }
    }
}
