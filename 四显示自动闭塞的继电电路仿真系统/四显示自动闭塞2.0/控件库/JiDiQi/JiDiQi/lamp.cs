using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ff
{
    public partial class lamp : UserControl
    {
        public lamp()
        {
            InitializeComponent();
        }


        //自定义控件的属性
        [Browsable(true)]
        [Description("修改灯的名字"), Category("自定义属性"), DefaultValue("")]
        public string NameChange { get; set; }

        private void lamp_Load(object sender, EventArgs e)
        {
            label1.Text = NameChange;
        }
        public void change_L()
        {
            rectangleShape1.BackColor = Color.Lime;
            rectangleShape1.BorderColor = Color.Lime;
        }
        public void change_H()
        {
            rectangleShape1.BackColor = Color.Red;
            rectangleShape1.BorderColor = Color.Red;
        }
        public void change_U()
        {
            rectangleShape1.BackColor = Color.Yellow;
            rectangleShape1.BorderColor = Color.Yellow;
        }
        public void change_W()
        {
            rectangleShape1.BackColor = Color.White;
            rectangleShape1.BorderColor = Color.Black;
        }
        private void lineShape10_Click(object sender, EventArgs e)
        {

        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
