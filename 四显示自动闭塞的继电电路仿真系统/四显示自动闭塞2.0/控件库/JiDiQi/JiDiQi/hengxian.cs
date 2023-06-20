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
    
    public partial class hengxian : UserControl
    {
        public hengxian()
        {
            InitializeComponent();
        }
        public void change_color_H()
    {
            lineShape1.BorderColor = Color.Red;
    }
        public void change_color_B()
        {
            lineShape1.BorderColor = Color.Black;
        }
    }
    }
   
