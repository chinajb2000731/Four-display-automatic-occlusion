using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDQxq
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
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
            lineShape14.Hide();
            lineShape15.Show();
            lineShape1.BorderColor = Color.Red;
            lineShape2.BorderColor = Color.Red;
            lineShape3.BorderColor = Color.Red;
            lineShape4.BorderColor = Color.Red;
            lineShape11.BorderColor = Color.Red;
            lineShape12.BorderColor = Color.Red;
            lineShape13.BorderColor = Color.Red;
            lineShape15.BorderColor = Color.Red;
            lineShape16.BorderColor = Color.Red;
            rectangleShape1.BackColor = Color.Yellow;
           

            lineShape6.BorderColor = Color.Black;
            lineShape9.BorderColor = Color.Black;
            lineShape10.BorderColor = Color.Black;
           
        }
        public void XQ_xiqi()
        {
            lineShape14.Show();
            lineShape15.Hide();
            lineShape1.BorderColor = Color.Lime;
            lineShape2.BorderColor = Color.Lime;
            lineShape3.BorderColor = Color.Lime;
            lineShape4.BorderColor = Color.Lime;
            lineShape16.BorderColor = Color.Lime;
            lineShape6.BorderColor = Color.Lime;
            lineShape9.BorderColor = Color.Lime;
            lineShape10.BorderColor = Color.Lime;
            lineShape14.BorderColor = Color.Lime;
            rectangleShape1.BackColor = Color.Yellow;

            lineShape11.BorderColor = Color.Black;
            lineShape12.BorderColor = Color.Black;
            lineShape13.BorderColor = Color.Black;
            
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
    }
}
