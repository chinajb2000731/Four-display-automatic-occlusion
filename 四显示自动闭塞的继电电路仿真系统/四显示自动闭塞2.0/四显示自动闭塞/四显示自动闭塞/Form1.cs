using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四显示自动闭塞
{
  
    public partial class Form1 : Form
    {
        int D1=0,D2=0,D3=0,D4=0,D5=0,D6=0,temp=0;
        int temp1 = 0, temp2 = 0, temp3 = 0, temp4 = 0, temp5 = 0;
        int LH1 = 0, LH2 = 0, LH3 = 0, LH4 = 0, LH5 = 0;
        int time= 0,time1=0,time2=0,time3=0;
        int D7 = 0, D8 = 0, D9 = 0, D10 = 0, D11 = 0, D12 = 0;

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int LH7 = 0, LH8 = 0, LH9 = 0, LH10 = 0, LH11 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (temp == 1)
            {
                timer1.Start();
            }
            if (temp == 2)
            {
                timer2.Start();
            }
            if (temp == 3)
            {
                timer3.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            lieche2.Hide();
            lieche4.Hide();
            lieche2label.Visible = false;
            lieche4label.Visible = false;
            /////绿灯
            x1.change_color_H();
            x2.change_color_H();
            x8.change_color_H();
            x9.change_color_H();
            x10.change_color_H();
            x11.change_color_H();
            x16.change_color_H();
            x34.change_color_H();
            x17.change_color_H();
            x18.change_color_H();
            x7.change_color_H();
            Dj_X.XQ_xiqi();
            GREEN.change_L();
            ////铁路交通灯
            L1.Show();
            L2.Show();
            L3.Show();
            L4.Show();
            L5.Show();
            L6.Show();
            L7.Show();
            L8.Show();
            L9.Show();
            L10.Show();
            L11.Show();
            L12.Show();
            Y1.Hide();
            Y2.Hide();
            Y3.Hide();
            Y4.Hide();
            Y5.Hide();
            Y6.Hide();
            Y7.Hide();
            Y8.Hide();
            Y9.Hide();
            Y10.Hide();
            Y11.Hide();
            Y12.Hide();
            R1.Hide();
            R2.Hide();
            R3.Hide();
            R4.Hide();
            R5.Hide();
            R6.Hide();
            R7.Hide();
            R8.Hide();
            R9.Hide();
            R10.Hide();
            R11.Hide();
            R12.Hide();
            GJ_1.XQ_xiqi();
            GJ_2.XQ_xiqi();
            GJF.XQ_xiqi();
            STOP.Enabled = false;
            START.Enabled = false;
        }
        public static bool Delay(double delayTime)
        {
            DateTime now = DateTime.Now;
            double s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }
        private void Jiaotongdeng_On(int i,int j)
        {
            if (i == 1)
            {
                if (j == 1)
                {
                    L1.Show();
                    D1 = 1;
                }
                else if (j == 2)
                {
                    Y1.Show();
                    D1 = 2;
                }
                else
                {
                    R1.Show();
                    D1 = 3;
                }
            }
            else if (i == 2)
            {
                if (j == 1)
                {
                    L2.Show();
                    D2 = 1;
                }
                else if (j == 2)
                {
                    Y2.Show();
                    D2 = 2;
                }
                else
                {
                    R2.Show();
                    D2 = 3;
                }
            }
            else if (i == 3)
            {
                if (j == 1)
                {
                    L3.Show();
                    D3 = 1;
                }
                else if (j == 2)
                {
                    Y3.Show();
                    D3 = 2;
                }
                else
                {
                    R3.Show();
                    D3 = 3;
                }
            }
            else if (i == 4)
            {
                if (j == 1)
                {
                    L4.Show();
                    D4 = 1;
                }
                else if (j == 2)
                {
                    Y4.Show();
                    D4 = 2;
                }
                else
                {
                    R4.Show();
                    D4 = 3;
                }
            }
            else if (i == 5)
            {
                if (j == 1)
                {
                    L5.Show();
                    D5 = 1;
                }
                else if (j == 2)
                {
                    Y5.Show();
                    D5 = 2;
                }
                else
                {
                    R5.Show();
                    D5 = 3;
                }
            }
            else if (i == 6)
            {
                if (j == 1)
                {
                    L6.Show();
                    D6 = 1;
                }
                else if (j == 2)
                {
                    Y6.Show();
                    D6 = 2;
                }
                else
                {
                    R6.Show();
                    D6 = 3;
                }
            }
            else if (i == 7)
            {
                if (j == 1)
                {
                    L7.Show();
                    D7 = 1;
                }
                else if (j == 2)
                {
                    Y7.Show();
                    D7 = 2;
                }
                else
                {
                    R7.Show();
                    D7 = 3;
                }
            }
            else if (i == 8)
            {
                if (j == 1)
                {
                    L8.Show();
                    D8 = 1;
                }
                else if (j == 2)
                {
                    Y8.Show();
                    D8 = 2;
                }
                else
                {
                    R8.Show();
                    D8 = 3;
                }
            }
            else if (i == 9)
            {
                if (j == 1)
                {
                    L9.Show();
                    D9 = 1;
                }
                else if (j == 2)
                {
                    Y9.Show();
                    D9 = 2;
                }
                else
                {
                    R9.Show();
                    D9 = 3;
                }
            }
            else if (i == 10)
            {
                if (j == 1)
                {
                    L10.Show();
                    D10 = 1;
                }
                else if (j == 2)
                {
                    Y10.Show();
                    D10 = 2;
                }
                else
                {
                    R10.Show();
                    D10 = 3;
                }
            }
            else if (i == 11)
            {
                if (j == 1)
                {
                    L11.Show();
                    D11 = 1;
                }
                else if (j == 2)
                {
                    Y11.Show();
                    D11 = 2;
                }
                else
                {
                    R11.Show();
                    D11 = 3;
                }
            }
            else if (i == 12)
            {
                if (j == 1)
                {
                    L12.Show();
                    D12 = 1;
                }
                else if (j == 2)
                {
                    Y12.Show();
                    D12 = 2;
                }
                else
                {
                    R12.Show();
                    D12 = 3;
                }
            }
        }
        private void Jiaotongdeng_OFF(int i,int j)
        {
            if(i==1)
            {
                if(j==1)
                {
                    L1.Hide();
                }
                else if(j==2)
                {
                    Y1.Hide();
                }
                else
                {
                    R1.Hide();
                }
            }
           else if (i == 2)
            {
                if (j == 1)
                {
                    L2.Hide();
                }
                else if (j == 2)
                {
                    Y2.Hide();
                }
                else
                {
                    R2.Hide();
                }
            }
            else if (i == 3)
            {
                if (j == 1)
                {
                    L3.Hide();
                }
                else if (j == 2)
                {
                    Y3.Hide();
                }
                else
                {
                    R3.Hide();
                }
            }
            else if (i == 4)
            {
                if (j == 1)
                {
                    L4.Hide();
                }
                else if (j == 2)
                {
                    Y4.Hide();
                }
                else
                {
                    R4.Hide();
                }
            }
            else if (i == 5)
            {
                if (j == 1)
                {
                    L5.Hide();
                }
                else if (j == 2)
                {
                    Y5.Hide();
                }
                else
                {
                    R5.Hide();
                }
            }
            else if (i == 6)
            {
                if (j == 1)
                {
                    L6.Hide();
                }
                else if (j == 2)
                {
                    Y6.Hide();
                }
                else
                {
                    R6.Hide();
                }
            }
            else if (i == 7)
            {
                if (j == 1)
                {
                    L7.Hide();
                }
                else if (j == 2)
                {
                    Y7.Hide();
                }
                else
                {
                    R7.Hide();
                }
            }
            else if (i == 8)
            {
                if (j == 1)
                {
                    L8.Hide();
                }
                else if (j == 2)
                {
                    Y8.Hide();
                }
                else
                {
                    R8.Hide();
                }
            }
            else if (i == 9)
            {
                if (j == 1)
                {
                    L9.Hide();
                }
                else if (j == 2)
                {
                    Y9.Hide();
                }
                else
                {
                    R9.Hide();
                }
            }
            else if (i == 10)
            {
                if (j == 1)
                {
                    L10.Hide();
                }
                else if (j == 2)
                {
                    Y10.Hide();
                }
                else
                {
                    R10.Hide();
                }
            }
            else if (i == 11)
            {
                if (j == 1)
                {
                    L11.Hide();
                }
                else if (j == 2)
                {
                    Y11.Hide();
                }
                else
                {
                    R11.Hide();
                }
            }
            else if (i == 12)
            {
                if (j == 1)
                {
                    L12.Hide();
                }
                else if (j == 2)
                {
                    Y12.Hide();
                }
                else
                {
                    R12.Hide();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int M1 = 1485;
            if (lieche1.Location.X != 1485)
            {
                int i = lieche1.Location.X + 5;
                if (i > this.Width)
                {
                    i = 0;
                }
                int starty = lieche1.Location.Y;
                int starty1 = lieche1label.Location.Y;
                lieche1.Location = new Point(i, starty);
                lieche1label.Location = new Point(i, starty1);
                int n = (M1 - lieche1.Location.X) * 10;
                textBox1.Text = "列车1距离目标:" + n.ToString() + "m";
                //textBox1.Text = lieche1.Location.X.ToString();
                lieche1.Refresh();
                lieche1label.Refresh();
            }
            if (lieche3.Location.X != -35)
            {
                int i = lieche3.Location.X - 5;
                if (i < -50)
                {
                    i = 1450;
                }
                int starty3 = lieche3.Location.Y;
                int starty33 = lieche3label.Location.Y;
                lieche3.Location = new Point(i, starty3);
                lieche3label.Location = new Point(i, starty33);
                textBox2.Text = "列车2距离目标:" + ((lieche3.Location.X - (-35)) * 10).ToString() + "m";
                lieche3.Refresh();
                lieche3label.Refresh();
            }
            if (lieche1.Location.X >= 710)
            {
                lieche2.Show();
                lieche2label.Visible = true;
                int j = lieche2.Location.X + 5;
                if (j > this.Width)
                {
                    j = 1450;
                }
                int starty2 = lieche2.Location.Y;
                int starty22 = lieche2label.Location.Y;
                lieche2.Location = new Point(j, starty2);
                //textBox2.Text = lieche2.Location.X.ToString();
                lieche2label.Location = new Point(j, starty22);
                int n2 = (M1 - lieche2.Location.X) * 10;
                textBox3.Text = "列车3距离目标:" + n2.ToString() + "m";
                lieche2.Refresh();
                lieche2label.Refresh();
            }
            if (lieche3.Location.X <= 740)
            {
                lieche4.Show();
                lieche4label.Visible = true;
                int j = lieche4.Location.X - 5;
                if (j < -50)
                {
                    j = 0;
                }
                int starty4 = lieche4.Location.Y;
                int starty44 = lieche4label.Location.Y;
                lieche4.Location = new Point(j, starty4);
                lieche4label.Location = new Point(j, starty44);
                textBox4.Text = "列车4距离目标:" + ((lieche4.Location.X - (-35)) * 10).ToString() + "m";
                lieche4.Refresh();
                lieche4.Refresh();
            }
            if (lieche1.Location.X == 160)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                Huang_OFF();
                LH_OFF();
                Hong_On();
                Jiaotongdeng_On(1, 3);
            }
            else if (lieche1.Location.X == 420)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                LH_OFF();
                Hong_OFF();
                Huang_On();
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 3);
            }
            else if(lieche1.Location.X==645)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);             
                Huang_OFF();
                Lu_OFF();
                Hong_OFF();
                LH_On();                              
                Jiaotongdeng_On(1, 1);
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 3);


            }
            else if(lieche1.Location.X == 870&& lieche2.Location.X == 165)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);            
                Lu_OFF();
                Huang_OFF();
                LH_OFF();
                Hong_On();                           
                Jiaotongdeng_On(1, 3);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);
                Jiaotongdeng_On(2, 1);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 3);

            }
            else if (lieche1.Location.X == 1125&& lieche2.Location.X == 420)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                LH_OFF();
                Hong_OFF();
                Huang_On();                            
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 3);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 1);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 2);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 3);

            }
            else if (lieche1.Location.X == 1340 && lieche2.Location.X == 635)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);              
                Huang_OFF();
                Lu_OFF();
                Hong_OFF();
                LH_On();             
                Jiaotongdeng_On(1, 1);
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 3);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 1);
                Jiaotongdeng_On(4, 2);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 2);

                Jiaotongdeng_OFF(6, 1);
                Jiaotongdeng_OFF(6, 2);
                Jiaotongdeng_OFF(6, 3);
                Jiaotongdeng_On(6, 3);

            }
            else if (lieche2.Location.X == 870)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);               
                Hong_OFF();
                Huang_OFF();
                LH_OFF();
                Lu_On();                              
                Jiaotongdeng_On(1, 1);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);
                Jiaotongdeng_On(2, 1);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 3);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 2);

            }
            else if (lieche2.Location.X == 1110)
            {
                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 1);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 1);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 2);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 3);
            }
            if (lieche3.Location.X == 1290)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 3);
            }
            else if (lieche3.Location.X == 1030)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 3);
            }
            else if (lieche3.Location.X == 805)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 1);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 3);


            }
            else if (lieche3.Location.X == 580 && lieche4.Location.X == 1285)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 3);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);
                Jiaotongdeng_On(8, 1);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 3);

            }
            else if (lieche3.Location.X == 325 && lieche4.Location.X == 1030)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 3);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 1);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 2);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 3);

            }
            else if (lieche3.Location.X == 110 && lieche4.Location.X == 815)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 1);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 3);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 1);
                Jiaotongdeng_On(10, 2);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 2);

                Jiaotongdeng_OFF(12, 1);
                Jiaotongdeng_OFF(12, 2);
                Jiaotongdeng_OFF(12, 3);
                Jiaotongdeng_On(12, 3);

            }
            else if (lieche4.Location.X == 580)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 1);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);
                Jiaotongdeng_On(8, 1);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 3);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 2);

            }
            else if (lieche4.Location.X == 340)
            {
                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 1);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 1);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 2);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 3);
            }
            if (lieche2.Location.X == 1310)
            {
                timer3.Stop();
                go.Enabled = true;
                go2.Enabled = true;
                go2_3.Enabled = true;

                STOP.Enabled = false;
                START.Enabled = false;
                temp = 0;
            }

        }

        private void go2_3_Click(object sender, EventArgs e)
        {
            timer3.Start();
            temp = 3;
            x1.change_color_H();
            x2.change_color_H();
            x8.change_color_H();
            x9.change_color_H();
            x10.change_color_H();
            x11.change_color_H();
            x16.change_color_H();
            x34.change_color_H();
            x17.change_color_H();
            x18.change_color_H();
            x7.change_color_H();
            Dj_X.XQ_xiqi();
            GREEN.change_L();
            L1.Show();
            L2.Show();
            L3.Show();
            L4.Show();
            L5.Show();
            L6.Show();
            L7.Show();
            L8.Show();
            L9.Show();
            L10.Show();
            L11.Show();
            L12.Show();
            Y1.Hide();
            Y2.Hide();
            Y3.Hide();
            Y4.Hide();
            Y5.Hide();
            Y6.Hide();
            Y7.Hide();
            Y8.Hide();
            Y9.Hide();
            Y10.Hide();
            Y11.Hide();
            Y12.Hide();
            R1.Hide();
            R2.Hide();
            R3.Hide();
            R4.Hide();
            R5.Hide();
            R6.Hide();
            R7.Hide();
            R8.Hide();
            R9.Hide();
            R10.Hide();
            R11.Hide();
            R12.Hide();
            lieche2.Hide();
            lieche4.Hide();
            lieche2label.Visible = false;
            lieche4label.Visible = false;
            textBox3.Text = "";
            textBox4.Text = "";
            int i = 0;
            int starty = lieche1.Location.Y;
            lieche1.Location = new Point(i, starty);
            //textBox1.Text = lieche1.Location.X.ToString();
            lieche1.Refresh();

            int j = 0;
            int starty2 = lieche2.Location.Y;
            lieche2.Location = new Point(j, starty2);
            //textBox2.Text = lieche2.Location.X.ToString();
            lieche2.Refresh();

            int k = 1450;
            int starty3 = lieche3.Location.Y;
            lieche3.Location = new Point(k, starty3);
            lieche3.Refresh();

            int m = 1450;
            int starty4 = lieche4.Location.Y;
            lieche4.Location = new Point(m, starty4);
            lieche4.Refresh();

            go.Enabled = false;
            go2.Enabled = false;
            go2_3.Enabled = false;

            STOP.Enabled = true;
            START.Enabled = true;
        }

        private void Hong_On()
        {
   
            //Delay(1);
            GJF_3.JieDian_hou();
            //Delay(2);
            GJF_4.JieDian_hou();
            //Delay(2);
            GJF_5.JieDian_hou();
            x1.change_color_H();
            //Delay(2);
            x2.change_color_H();
            //Delay(2);
            x3.change_color_H();
            //Delay(2);
            x4.change_color_H();
            //Delay(2);
            RED.change_H();
            x5.change_color_H();
            //Delay(2);
            x6.change_color_H();
            //Delay(2);
            x7.change_color_H();
            GJF.XQ_luoxia();
            GJ_1.XQ_xiqi();
            GJ_2.XQ_xiqi();
        }
        private void Hong_OFF()
        {
            GJF_3.JieDian_qian();
            GJF_4.JieDian_qian();
            GJF_5.JieDian_qian();
            x1.change_color_B();
            x2.change_color_B();
            x3.change_color_B();
            x4.change_color_B();
            x5.change_color_B();
            x6.change_color_B();
            x7.change_color_B();
            RED.change_W();
            GJF.XQ_luoxia();
            GJ_1.XQ_luoxia();
            GJ_2.XQ_luoxia();
        }

      

        private void Lu_On()
        {
            ///绿灯
           
            //Delay(1);
            x1.change_color_H();
            //Delay(2);
            x2.change_color_H();
           // Delay(2);
            x8.change_color_H();
           // Delay(2);
            x9.change_color_H();
          //  Delay(2);
            x10.change_color_H();
           // Delay(2);
            x11.change_color_H();
          //  Delay(2);
            GREEN.change_L();
            x16.change_color_H();
          //  Delay(2);
            x34.change_color_H();
          //  Delay(2);
            x17.change_color_H();
          //  Delay(2);
            x18.change_color_H();
         //   Delay(2);
            x7.change_color_H();
            GJ_1.XQ_xiqi();
            GJ_2.XQ_xiqi();
            GJF.XQ_xiqi();
        }
        private void Lu_OFF()
        {
            x1.change_color_B();
            x2.change_color_B();
            x8.change_color_B();
            x9.change_color_B();
            x10.change_color_B();
            x11.change_color_B();
            x16.change_color_B();
            x34.change_color_B();
            x17.change_color_B();
            x18.change_color_B();
            x7.change_color_B();
            GREEN.change_W();
            GJF.XQ_luoxia();
            GJ_1.XQ_luoxia();
            GJ_2.XQ_luoxia();
        }
        private void Huang_On()
        {
            // Delay(1);
            GJ1_3.JieDian_hou();
            //  Delay(2);
            GJ1_5.JieDian_hou();
            //   Delay(2);
            GJ1_4.JieDian_hou();
            ///   Delay(2);
            x1.change_color_H();
            //    Delay(2);
            x2.change_color_H();
            //    Delay(2);
            x8.change_color_H();
            //    Delay(2);
            x19.change_color_H();
            //    Delay(2);
            x21.change_color_H();
            //    Delay(2);
            Yellow.change_U();
            x27.change_color_H();
            //    Delay(2);
            x20.change_color_H();
            //   Delay(2);
            x33.change_color_H();
            //    Delay(2);
            x31.change_color_H();
            //    Delay(2);
            x18.change_color_H();
            //     Delay(2);
            x7.change_color_H();
            GJF.XQ_xiqi();
            GJ_1.XQ_luoxia();
            GJ_2.XQ_xiqi();
        }
        private void Huang_OFF()
        {
            GJ1_3.JieDian_qian();
            GJ1_5.JieDian_qian();
            GJ1_4.JieDian_qian();
            x1.change_color_B();
            x2.change_color_B();
            x8.change_color_B();
            x19.change_color_B();
            x21.change_color_B();
            x27.change_color_B();
            x20.change_color_B();
            x33.change_color_B();
            x31.change_color_B();
            x18.change_color_B();
            x7.change_color_B();
            Yellow.change_W();
            GJF.XQ_luoxia();
            GJ_1.XQ_luoxia();
            GJ_2.XQ_luoxia();
        }
        private void LH_On()
        {
       //     Delay(1);
            DJ2_X.XQ_xiqi();
       //     Delay(1);
            DJ2.DJ_qian();
        //    Delay(2);
            DJ2_3.JieDian_qian();
       //     Delay(2);
            DJ2_4.JieDian_qian();
       //     Delay(2);
            GJ2_3.JieDian_hou();
         //   Delay(2);
            GJ2_4.JieDian_hou();
        //    Delay(2);
            GJ2_5.JieDian_hou();
        //    Delay(2);
            x26.change_color_H();
        //    Delay(2);
            x25.change_color_H();
         //   Delay(2);
            x24.change_color_H();
         //   Delay(2);
            x23.change_color_H();
        //    Delay(2);
            x22.change_color_H();
         //   Delay(2);
            x21.change_color_H();
       //     Delay(2);
            Yellow.change_U();
            x27.change_color_H();
        //    Delay(2);
            x20.change_color_H();
         //   Delay(2);
            x32.change_color_H();
        //    Delay(2);
            x17.change_color_H();
        //    Delay(2);
            x18.change_color_H();
        //    Delay(2);
            x7.change_color_H();
        //    Delay(2);
            x1.change_color_H();
        //    Delay(2);
            x2.change_color_H();
       //     Delay(2);
            x8.change_color_H();
        //    Delay(2);
            x9.change_color_H();
        //    Delay(2);
            x15.change_color_H();
       //     Delay(2);
            x14.change_color_H();
        //    Delay(2);
            x13.change_color_H();
        //    Delay(2);
            x12.change_color_H();
       //     Delay(2);
            x11.change_color_H();
        //    Delay(2);
            GREEN.change_L();
            x16.change_color_H();
       //     Delay(2);
            x28.change_color_H();
       //     Delay(2);
            x29.change_color_H();
        //    Delay(2);
            x30.change_color_H();
            GJF.XQ_xiqi();
            GJ_1.XQ_xiqi();
            GJ_2.XQ_luoxia();
            DJ_2.XQ_xiqi();
        }
        private void LH_OFF()
        {
            DJ2_X.XQ_luoxia();
            DJ2.DJ_hou();
            DJ2_3.JieDian_hou();
            DJ2_4.JieDian_hou();
            GJ2_3.JieDian_qian();
            GJ2_4.JieDian_qian();
            GJ2_5.JieDian_qian();
            x26.change_color_B();
            x25.change_color_B();
            x24.change_color_B();
            x23.change_color_B();
            x22.change_color_B();
            x21.change_color_B();
            x27.change_color_B();
            x20.change_color_B();
            x32.change_color_B();
            x17.change_color_B();
            x18.change_color_B();
            x7.change_color_B();
            x1.change_color_B();
            x2.change_color_B();
            x8.change_color_B();
            x9.change_color_B();
            x15.change_color_B();
            x14.change_color_B();
            x13.change_color_B();
            x12.change_color_B();
            x11.change_color_B();
            x16.change_color_B();
            x28.change_color_B();
            x29.change_color_B();
            x30.change_color_B();
            Yellow.change_W();
            GREEN.change_W();
            GJF.XQ_luoxia();
            GJ_1.XQ_luoxia();
            GJ_2.XQ_luoxia();
            DJ_2.XQ_luoxia();
        }

        //private void button2_Click(object sender, EventArgs e)//红灯
        //{
        //    ludeng.Enabled = false;
        //    danhuang.Enabled = false;
        //    luhuang.Enabled = false;
        //    Hong_OFF();
        //    Lu_OFF();
        //    Huang_OFF();
        //    LH_OFF();
        //    Hong_On();
        //    ludeng.Enabled = true;
        //    danhuang.Enabled = true;
        //    luhuang.Enabled = true;
        //}

        //private void button4_Click(object sender, EventArgs e)//单黄
        //{
        //    ludeng.Enabled = false;
        //    hongdeng.Enabled = false;
        //    luhuang.Enabled = false;
        //    Huang_OFF();
        //    Lu_OFF();
        //    LH_OFF();
        //    Hong_OFF();
        //    Huang_On();
        //    ludeng.Enabled = true;
        //    hongdeng.Enabled = true;
        //    luhuang.Enabled = true;
        //}

        //private void button5_Click(object sender, EventArgs e)//绿黄
        //{
        //    hongdeng.Enabled = false;
        //    ludeng.Enabled = false;
        //    danhuang.Enabled = false;
        //    LH_OFF();
        //    Huang_OFF();
        //    Lu_OFF();
        //    Hong_OFF();
        //    LH_On();
        //    hongdeng.Enabled = true;
        //    ludeng.Enabled = true;
        //    danhuang.Enabled = true;
        //}

    //    private void button1_Click(object sender, EventArgs e)//绿灯
    //    {
            
    //    {
    //            ///绿灯
    //            /// 
    //            danhuang.Enabled = false;
    //            hongdeng.Enabled = false;
    //            luhuang.Enabled = false;
    //            Lu_OFF();
    //            Hong_OFF();
    //            Huang_OFF();
    //            LH_OFF();
    //            Lu_On();
    //            danhuang.Enabled = true;
    //            hongdeng.Enabled = true;
    //            luhuang.Enabled = true;


    //        }
    //}

      


        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
            temp = 1;
            x1.change_color_H();
            x2.change_color_H();
            x8.change_color_H();
            x9.change_color_H();
            x10.change_color_H();
            x11.change_color_H();
            x16.change_color_H();
            x34.change_color_H();
            x17.change_color_H();
            x18.change_color_H();
            x7.change_color_H();
            Dj_X.XQ_xiqi();
            GREEN.change_L();
            L1.Show();
            L2.Show();
            L3.Show();
            L4.Show();
            L5.Show();
            L6.Show();
            L7.Show();
            L8.Show();
            L9.Show();
            L10.Show();
            L11.Show();
            L12.Show();
            Y1.Hide();
            Y2.Hide();
            Y3.Hide();
            Y4.Hide();
            Y5.Hide();
            Y6.Hide();
            Y7.Hide();
            Y8.Hide();
            Y9.Hide();
            Y10.Hide();
            Y11.Hide();
            Y12.Hide();
            R1.Hide();
            R2.Hide();
            R3.Hide();
            R4.Hide();
            R5.Hide();
            R6.Hide();
            R7.Hide();
            R8.Hide();
            R9.Hide();
            R10.Hide();
            R11.Hide();
            R12.Hide();
            lieche2.Hide();
            lieche4.Hide();
            lieche2label.Visible = false;
            lieche4label.Visible = false;
            textBox3.Text = "";
            textBox4.Text = "";
            D1 = 0; D2 = 0; D3 = 0; D4 = 0; D5 = 0; D6 = 0;
            D7 = 0; D8 = 0; D8 = 0; D10 = 0; D11 = 0; D12 = 0;
            temp1 = 0; temp2 = 0; temp3 = 0; temp4 = 0; temp5 = 0;
            LH1 = 0; LH2 = 0; LH3 = 0; LH4 = 0; LH5 = 0;
            LH7 = 0; LH8 = 0; LH9 = 0; LH10 = 0; LH11 = 0;
            time = 0; time1 = 0; time2 = 0; time3 = 0;   
                   
            int i = 0;          
            int starty = lieche1.Location.Y;
            lieche1.Location = new Point(i, starty);
            //textBox1.Text = lieche1.Location.X.ToString();
            lieche1.Refresh();

            int j = 0;
            int starty2 = lieche2.Location.Y;
            lieche2.Location = new Point(j, starty2);
            //textBox2.Text = lieche2.Location.X.ToString();
            lieche2.Refresh();

            int k = 1450;
            int starty3 = lieche3.Location.Y;
            lieche3.Location = new Point(k, starty3);
            lieche3.Refresh();

            int m = 1450;
            int starty4 = lieche4.Location.Y;
            lieche4.Location = new Point(m, starty4);
            lieche4.Refresh();

            go.Enabled = false;
            go2.Enabled = false;
            go2_3.Enabled = false;

            STOP.Enabled = true;
            START.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = lieche1.Location.X + 5;
            int M1 = 1445;
            
            if (i > this.Width)
            {
                i = 0;
            }
            int starty = lieche1.Location.Y;
            int starty2 = lieche1label.Location.Y;
            lieche1.Location = new Point(i, starty);
            lieche1label.Location = new Point(i,starty2 );
            int n =( M1 - lieche1.Location.X)*10;
            textBox1.Text = "列车1距离目标:"+n.ToString()+"m";
            lieche1.Refresh();
            lieche1label.Refresh();




            int j = lieche3.Location.X - 5;
            if (j < -50)
            {
                j = 1450;
            }
            int starty1 = lieche3.Location.Y;
            int starty3 = lieche3label.Location.Y;
            lieche3.Location = new Point(j, starty1);
            lieche3label.Location = new Point(j, starty3);
            textBox2.Text = "列车2距目标:"+((lieche3.Location.X-5)*10).ToString()+"m";
            lieche3.Refresh();
            lieche3label.Refresh();
            if (lieche1.Location.X >= 185)
            {
                                            
                    if (lieche1.Location.X == 185)
                    {
                        temp1 = 1;
                    }
                    else
                    {
                        temp1 = 0;
                    }
                    if (temp1 == 1)
                    {
                        
                        //timer1.Stop();
                        Jiaotongdeng_OFF(1, 1);
                        Jiaotongdeng_OFF(1, 2);
                        Jiaotongdeng_OFF(1, 3);
                      if (time == 0)
                     {
                        Lu_OFF();
                        Huang_OFF();
                        LH_OFF();
                        Hong_On();
                        time= 1;
                        time1 = 0;
                        time2 = 0;
                        time3 = 0;
                     }
                        Jiaotongdeng_On(1, 3);
                       
                    }
                    else
                    {
                        if (D2 == 2)
                        {
                            //timer1.Stop();
                            Jiaotongdeng_OFF(1, 1);
                            Jiaotongdeng_OFF(1, 2);
                            Jiaotongdeng_OFF(1, 3);
                        if (time1 == 0)
                        {
                            Huang_OFF();
                            Lu_OFF();
                            Hong_OFF();
                            LH_On();
                            time = 0;
                            time1 = 1;
                            time2 = 0;
                            time3 = 0;
                        }
                            Jiaotongdeng_On(1, 1);
                            Jiaotongdeng_On(1, 2);
                          

                        }
                        if ((D2 == 1 )|| (LH2 == 1))
                        {
                            //timer1.Stop();
                            Jiaotongdeng_OFF(1, 1);
                            Jiaotongdeng_OFF(1, 2);
                            Jiaotongdeng_OFF(1, 3);
                        if (time2 == 0)
                        {
                            Hong_OFF();
                            Huang_OFF();
                            LH_OFF();
                            Lu_On();
                            time = 0;
                            time1 = 0;
                            time2 = 1;
                            time3 = 0;
                        }
                            Jiaotongdeng_On(1, 1);
                           
                        }
                        if (D2 == 3)
                        {
                            //timer1.Stop();
                            Jiaotongdeng_OFF(1, 1);
                            Jiaotongdeng_OFF(1, 2);
                            Jiaotongdeng_OFF(1, 3);
                        if (time3 == 0)
                        {
                            Lu_OFF();
                            LH_OFF();
                            Hong_OFF();
                            Huang_On();
                            time = 0;
                            time1 = 0;
                            time2 = 0;
                            time3 = 1;
                        }
                            Jiaotongdeng_On(1, 2);
                           
                        }
                    }                                   
            }

            if (lieche3.Location.X <= 1265)
            {

                if (temp1 == 1)
                {

                    //timer1.Stop();
                    Jiaotongdeng_OFF(7, 1);
                    Jiaotongdeng_OFF(7, 2);
                    Jiaotongdeng_OFF(7, 3);
                
                    Jiaotongdeng_On(7, 3);

                }
                else
                {
                    if (D8 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(7, 1);
                        Jiaotongdeng_OFF(7, 2);
                        Jiaotongdeng_OFF(7, 3);
                      
                        Jiaotongdeng_On(7, 1);
                        Jiaotongdeng_On(7, 2);


                    }
                    if ((D8 == 1) || (LH8 == 1))
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(7, 1);
                        Jiaotongdeng_OFF(7, 2);
                        Jiaotongdeng_OFF(7, 3);
                    
                        Jiaotongdeng_On(7, 1);

                    }
                    if (D8 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(7, 1);
                        Jiaotongdeng_OFF(7, 2);
                        Jiaotongdeng_OFF(7, 3);

                        Jiaotongdeng_On(7, 2);

                    }
                }
            }

            if (lieche1.Location.X >= 430)
            {
               
                if (lieche1.Location.X == 430)
                {
                    temp2 = 1;
                   
                }
                else
                {
                    temp2 = 0;
                }
                if (temp2 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(2, 1);
                    Jiaotongdeng_OFF(2, 2);
                    Jiaotongdeng_OFF(2, 3);
                    Jiaotongdeng_On(2, 3);
                }
                else
                {
                    if (D3 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(2, 1);
                        Jiaotongdeng_OFF(2, 2);
                        Jiaotongdeng_OFF(2, 3);                      
                        Jiaotongdeng_On(2, 2);
                        Jiaotongdeng_On(2, 1);
                        LH2 = 1;

                    }
                    if (D3 == 1 || LH3 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(2, 1);
                        Jiaotongdeng_OFF(2, 2);
                        Jiaotongdeng_OFF(2, 3);
                        Jiaotongdeng_On(2, 1);
                        LH2 = 0;
                    }
                    if (D3 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(2, 1);
                        Jiaotongdeng_OFF(2, 2);
                        Jiaotongdeng_OFF(2, 3);
                        Jiaotongdeng_On(2, 2);
                        LH2 = 0;

                    }

                }
            }

            if (lieche3.Location.X <= 1020)
            {

                if (temp2 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(8, 1);
                    Jiaotongdeng_OFF(8, 2);
                    Jiaotongdeng_OFF(8, 3);
                    Jiaotongdeng_On(8, 3);
                }
                else
                {
                    if (D9 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(8, 1);
                        Jiaotongdeng_OFF(8, 2);
                        Jiaotongdeng_OFF(8, 3);
                        Jiaotongdeng_On(8, 2);
                        Jiaotongdeng_On(8, 1);
                        LH8 = 1;

                    }
                    if (D9 == 1 || LH9 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(8, 1);
                        Jiaotongdeng_OFF(8, 2);
                        Jiaotongdeng_OFF(8, 3);
                        Jiaotongdeng_On(8, 1);
                        LH8 = 0;
                    }
                    if (D9 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(8, 1);
                        Jiaotongdeng_OFF(8, 2);
                        Jiaotongdeng_OFF(8, 3);
                        Jiaotongdeng_On(8, 2);
                        LH8 = 0;

                    }

                }
            }

            if (lieche1.Location.X >= 650)
            {
                
                if (lieche1.Location.X ==650)
                {
                    temp3 = 1;
                }
                else
                {
                    temp3 = 0;
                }
                if (temp3 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(3, 1);
                    Jiaotongdeng_OFF(3, 2);
                    Jiaotongdeng_OFF(3, 3);                   
                    Jiaotongdeng_On(3, 3);
                    LH3 = 0;
                 
                }
               
                else
                {
                    if (D4 == 2)
                {
                     //timer1.Stop();
                    Jiaotongdeng_OFF(3, 1);
                    Jiaotongdeng_OFF(3, 2);
                    Jiaotongdeng_OFF(3, 3); 
                    Jiaotongdeng_On(3, 1);
                    Jiaotongdeng_On(3, 2);
                    LH3= 1;
                        
                }
                    if (D4 == 1||LH4==1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(3, 1);
                        Jiaotongdeng_OFF(3, 2);
                        Jiaotongdeng_OFF(3, 3);                 
                        Jiaotongdeng_On(3, 1);
                        LH3 = 0;
                        D4 = 0;
                    }
                    if (D4 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(3, 1);
                        Jiaotongdeng_OFF(3, 2);
                        Jiaotongdeng_OFF(3, 3);                     
                        Jiaotongdeng_On(3, 2);
                        LH3 = 0;
                        
                    }
                    
                }
            }

            if (lieche3.Location.X <= 800)
            {

                if (temp3 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(9, 1);
                    Jiaotongdeng_OFF(9, 2);
                    Jiaotongdeng_OFF(9, 3);
                    Jiaotongdeng_On(9, 3);
                    LH9 = 0;

                }

                else
                {
                    if (D10 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(9, 1);
                        Jiaotongdeng_OFF(9, 2);
                        Jiaotongdeng_OFF(9, 3);
                        Jiaotongdeng_On(9, 1);
                        Jiaotongdeng_On(9, 2);
                        LH9 = 1;

                    }
                    if (D10 == 1 || LH10 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(9, 1);
                        Jiaotongdeng_OFF(9, 2);
                        Jiaotongdeng_OFF(9, 3);
                        Jiaotongdeng_On(9, 1);
                        LH9 = 0;
                        D10 = 0;
                    }
                    if (D10 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(9, 1);
                        Jiaotongdeng_OFF(9, 2);
                        Jiaotongdeng_OFF(9, 3);
                        Jiaotongdeng_On(9, 2);
                        LH9 = 0;

                    }

                }
            }

            if (lieche1.Location.X >= 880)
            {
                
                if (lieche1.Location.X ==880)
                {
                    temp4 = 1;
                }
                else
                {
                    temp4 = 0;
                }
                if (temp4 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(4, 1);
                    Jiaotongdeng_OFF(4, 2);
                    Jiaotongdeng_OFF(4, 3);                   
                    Jiaotongdeng_On(4, 3);
                    LH4 = 0;
                    
                }
                
                else
                {
                    if (D5 == 2)
                {
                     //timer1.Stop();
                    Jiaotongdeng_OFF(4, 1);
                    Jiaotongdeng_OFF(4, 2);
                    Jiaotongdeng_OFF(4, 3);
                    Jiaotongdeng_On(4, 1);
                    Jiaotongdeng_On(4, 2);
                    LH4= 1;
                     
                }
                    if (D5 == 1||LH5==1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(4, 1);
                        Jiaotongdeng_OFF(4, 2);
                        Jiaotongdeng_OFF(4, 3);                   
                        Jiaotongdeng_On(4, 1);
                        LH4 = 0;
                        
                    }
                    if (D5 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(4, 1);
                        Jiaotongdeng_OFF(4, 2);
                        Jiaotongdeng_OFF(4, 3);                      
                        Jiaotongdeng_On(4, 2);
                        LH4 = 0;
                       
                    }
                }

            }

            if (lieche3.Location.X <= 570)
            {

                if (temp4 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(10, 1);
                    Jiaotongdeng_OFF(10, 2);
                    Jiaotongdeng_OFF(10, 3);
                    Jiaotongdeng_On(10, 3);
                    LH10 = 0;

                }

                else
                {
                    if (D11 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(10, 1);
                        Jiaotongdeng_OFF(10, 2);
                        Jiaotongdeng_OFF(10, 3);
                        Jiaotongdeng_On(10, 1);
                        Jiaotongdeng_On(10, 2);
                        LH10 = 1;

                    }
                    if (D11 == 1 || LH11 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(10, 1);
                        Jiaotongdeng_OFF(10, 2);
                        Jiaotongdeng_OFF(10, 3);
                        Jiaotongdeng_On(10, 1);
                        LH10 = 0;

                    }
                    if (D11 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(10, 1);
                        Jiaotongdeng_OFF(10, 2);
                        Jiaotongdeng_OFF(10, 3);
                        Jiaotongdeng_On(10, 2);
                        LH10 = 0;

                    }
                }

            }

            if (lieche1.Location.X >= 1120)
            {
               
                if (lieche1.Location.X == 1120 )
                {
                    temp5 = 1;
                }
                else
                {
                    temp5 = 0;
                }
                if (temp5 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(5, 1);
                    Jiaotongdeng_OFF(5, 2);
                    Jiaotongdeng_OFF(5, 3);
                    Jiaotongdeng_On(5, 3);
                    LH5 = 0;                   
                }
                
                else
                {
                    if (D6 == 2)
                {
                        //timer1.Stop();
                    Jiaotongdeng_OFF(5, 1);
                    Jiaotongdeng_OFF(5, 2);
                    Jiaotongdeng_OFF(5, 3);                    
                    Jiaotongdeng_On(5, 1);
                    Jiaotongdeng_On(5, 2);
                        LH5 = 1;
                       
                }
                    if (D6 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(5, 1);
                        Jiaotongdeng_OFF(5, 2);
                        Jiaotongdeng_OFF(5, 3);
                        Jiaotongdeng_On(5, 1);
                        LH5 = 0;
                        
                    }
                    if (D6 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(5, 1);
                        Jiaotongdeng_OFF(5, 2);
                        Jiaotongdeng_OFF(5, 3);
                        Jiaotongdeng_On(5, 2);
                        LH5 = 0;
                       
                    }
                }

            }

            if (lieche3.Location.X <= 330)
            {
                if (temp5 == 1)
                {
                    //timer1.Stop();
                    Jiaotongdeng_OFF(11, 1);
                    Jiaotongdeng_OFF(11, 2);
                    Jiaotongdeng_OFF(11, 3);
                    Jiaotongdeng_On(11, 3);
                    LH11 = 0;
                }

                else
                {
                    if (D12 == 2)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(11, 1);
                        Jiaotongdeng_OFF(11, 2);
                        Jiaotongdeng_OFF(11, 3);
                        Jiaotongdeng_On(11, 1);
                        Jiaotongdeng_On(11, 2);
                        LH11 = 1;

                    }
                    if (D12 == 1)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(11, 1);
                        Jiaotongdeng_OFF(11, 2);
                        Jiaotongdeng_OFF(11, 3);
                        Jiaotongdeng_On(11, 1);
                        LH11 = 0;

                    }
                    if (D12 == 3)
                    {
                        //timer1.Stop();
                        Jiaotongdeng_OFF(11, 1);
                        Jiaotongdeng_OFF(11, 2);
                        Jiaotongdeng_OFF(11, 3);
                        Jiaotongdeng_On(11, 2);
                        LH11 = 0;

                    }
                }

            }

            if (lieche1.Location.X >= 1345)
            {
                
                //timer1.Stop();
                Jiaotongdeng_OFF(6, 1);
                Jiaotongdeng_OFF(6, 2);
                Jiaotongdeng_OFF(6, 3);              
                Jiaotongdeng_On(6, 3);

            }

            if (lieche3.Location.X <= 105)
            {

                //timer1.Stop();
                Jiaotongdeng_OFF(12, 1);
                Jiaotongdeng_OFF(12, 2);
                Jiaotongdeng_OFF(12, 3);
                Jiaotongdeng_On(12, 3);

            }

            if (lieche1.Location.X == 1445)
            {
                timer1.Stop();
                go.Enabled = true;
                go2.Enabled = true;
                go2_3.Enabled = true;

                STOP.Enabled = false;
                START.Enabled = false;

                temp = 0;
            }
         
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int M1 = 1485;
            if (lieche1.Location.X!=1485)
            {
                int i = lieche1.Location.X + 5;
                if (i > this.Width)
                {
                    i = 0;
                }
                int starty = lieche1.Location.Y;
                int starty1 = lieche1label.Location.Y;
                lieche1.Location = new Point(i, starty);
                lieche1label.Location = new Point(i, starty1);
                int n = (M1 - lieche1.Location.X) * 10;
                textBox1.Text = "列车1距离目标:" + n.ToString() + "m";
                //textBox1.Text = lieche1.Location.X.ToString();
                lieche1.Refresh();
                lieche1label.Refresh();
            }

            if (lieche3.Location.X != -35)
            {
                int i = lieche3.Location.X - 5;
                if (i < -50)
                {
                    i = 1450;
                }
                int starty3 = lieche3.Location.Y;
                int starty33 = lieche3label.Location.Y;
                lieche3.Location = new Point(i, starty3);
                lieche3label.Location = new Point(i, starty33);
                textBox2.Text = "列车2距离目标:" + ((lieche3.Location.X - (-35))*10).ToString() + "m";
                //textBox2.Text = lieche3.Location.X.ToString();
                lieche3.Refresh();
                lieche3label.Refresh();
            }

            if (lieche1.Location.X >= 480)
            {
                lieche2.Show();
                lieche2label.Visible = true;
                int j = lieche2.Location.X + 5;
                if (j > this.Width)
                {
                    j = 0;
                }
                int starty2 = lieche2.Location.Y;
                int starty22 = lieche2label.Location.Y;
                lieche2.Location = new Point(j, starty2);
                lieche2label.Location = new Point(j, starty22);
                int n2 = (M1 - lieche2.Location.X) * 10;
                textBox3.Text = "列车3距离目标:" + n2.ToString() + "m";
                //textBox3.Text = lieche2.Location.X.ToString();
                //textBox2.Text = lieche2.Location.X.ToString();
                lieche2.Refresh();
                lieche2label.Refresh();
            }

            if (lieche3.Location.X <= 970)
            {
                lieche4.Show();
                lieche4label.Visible = true;
                int j = lieche4.Location.X - 5;
                if (j < -50)
                {
                    j = 0;
                }
                int starty4 = lieche4.Location.Y;
                int starty44 = lieche4label.Location.Y;
                lieche4.Location = new Point(j, starty4);
                lieche4label.Location = new Point(j, starty44);
                textBox4.Text = "列车4距离目标:" + ((lieche4.Location.X - (-35)) * 10).ToString() + "m";
                //textBox4.Text = lieche4.Location.X.ToString();
                lieche4.Refresh();
                lieche4label.Refresh();
            }

            if (lieche1.Location.X==160)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                Huang_OFF();
                LH_OFF();
                Hong_On();
                Jiaotongdeng_On(1, 3);
            }
           else if(lieche1.Location.X == 420)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                LH_OFF();
                Hong_OFF();
                Huang_On();                                 
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 3);
            }
            else if(lieche1.Location.X == 635&& lieche2.Location.X == 160)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                Huang_OFF();
                LH_OFF();
                Hong_On();
                Jiaotongdeng_On(1, 3);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 3);

            }
            else if(lieche1.Location.X == 885 && lieche2.Location.X == 410)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Lu_OFF();
                LH_OFF();
                Hong_OFF();
                Huang_On();
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 3);


                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 2);


                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 3);

            }
            else if(lieche1.Location.X == 1120 && lieche2.Location.X == 645)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);
                Huang_OFF();
                Lu_OFF();
                Hong_OFF();
                LH_On();                                   
                Jiaotongdeng_On(1, 1);
                Jiaotongdeng_On(1, 2);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 3);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 2);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 3);


            }
            else if(lieche1.Location.X == 1345&& lieche2.Location.X == 870)
            {
                Jiaotongdeng_OFF(1, 1);
                Jiaotongdeng_OFF(1, 2);
                Jiaotongdeng_OFF(1, 3);           
                 Hong_OFF();
                 Huang_OFF();
                 LH_OFF();
                 Lu_On();                           
                Jiaotongdeng_On(1, 1);

                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 2);
                Jiaotongdeng_On(2, 1);


                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 3);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 2);

                Jiaotongdeng_OFF(6, 1);
                Jiaotongdeng_OFF(6, 2);
                Jiaotongdeng_OFF(6, 3);
                Jiaotongdeng_On(6, 3);

            }
            else if (lieche2.Location.X >1110)
            {
                Jiaotongdeng_OFF(2, 1);
                Jiaotongdeng_OFF(2, 2);
                Jiaotongdeng_OFF(2, 3);
                Jiaotongdeng_On(2, 1);

                Jiaotongdeng_OFF(3, 1);
                Jiaotongdeng_OFF(3, 2);
                Jiaotongdeng_OFF(3, 3);
                Jiaotongdeng_On(3, 1);
                Jiaotongdeng_On(3, 2);

                Jiaotongdeng_OFF(4, 1);
                Jiaotongdeng_OFF(4, 2);
                Jiaotongdeng_OFF(4, 3);
                Jiaotongdeng_On(4, 2);

                Jiaotongdeng_OFF(5, 1);
                Jiaotongdeng_OFF(5, 2);
                Jiaotongdeng_OFF(5, 3);
                Jiaotongdeng_On(5, 3);

            }

            if (lieche3.Location.X == 1290)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 3);
            }
            else if (lieche3.Location.X == 1030)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 3);
            }
            else if (lieche3.Location.X == 815 && lieche4.Location.X == 1290)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 3);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 3);

            }
            else if (lieche3.Location.X == 565 && lieche4.Location.X == 1040)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 3);


                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 2);


                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 3);

            }
            else if (lieche3.Location.X == 330 && lieche4.Location.X == 805)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 1);
                Jiaotongdeng_On(7, 2);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 3);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 2);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 3);


            }
            else if (lieche3.Location.X == 105 && lieche4.Location.X == 580)
            {
                Jiaotongdeng_OFF(7, 1);
                Jiaotongdeng_OFF(7, 2);
                Jiaotongdeng_OFF(7, 3);
                Jiaotongdeng_On(7, 1);

                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 2);
                Jiaotongdeng_On(8, 1);


                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 3);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 2);

                Jiaotongdeng_OFF(12, 1);
                Jiaotongdeng_OFF(12, 2);
                Jiaotongdeng_OFF(12, 3);
                Jiaotongdeng_On(12, 3);

            }
            else if (lieche4.Location.X < 340)
            {
                Jiaotongdeng_OFF(8, 1);
                Jiaotongdeng_OFF(8, 2);
                Jiaotongdeng_OFF(8, 3);
                Jiaotongdeng_On(8, 1);

                Jiaotongdeng_OFF(9, 1);
                Jiaotongdeng_OFF(9, 2);
                Jiaotongdeng_OFF(9, 3);
                Jiaotongdeng_On(9, 1);
                Jiaotongdeng_On(9, 2);

                Jiaotongdeng_OFF(10, 1);
                Jiaotongdeng_OFF(10, 2);
                Jiaotongdeng_OFF(10, 3);
                Jiaotongdeng_On(10, 2);

                Jiaotongdeng_OFF(11, 1);
                Jiaotongdeng_OFF(11, 2);
                Jiaotongdeng_OFF(11, 3);
                Jiaotongdeng_On(11, 3);

            }

            if (lieche2.Location.X == 1310)
            {
                timer2.Stop();
                go.Enabled = true;
                go2.Enabled = true;
                go2_3.Enabled = true;

                STOP.Enabled = false;
                START.Enabled = false;
                temp = 0;
            }
        }

        private void go2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            temp = 2;         
            x1.change_color_H();
            x2.change_color_H();
            x8.change_color_H();
            x9.change_color_H();
            x10.change_color_H();
            x11.change_color_H();
            x16.change_color_H();
            x34.change_color_H();
            x17.change_color_H();
            x18.change_color_H();
            x7.change_color_H();
            Dj_X.XQ_xiqi();
            GREEN.change_L();
            L1.Show();
            L2.Show();
            L3.Show();
            L4.Show();
            L5.Show();
            L6.Show();
            L7.Show();
            L8.Show();
            L9.Show();
            L10.Show();
            L11.Show();
            L12.Show();
            Y1.Hide();
            Y2.Hide();
            Y3.Hide();
            Y4.Hide();
            Y5.Hide();
            Y6.Hide();
            Y7.Hide();
            Y8.Hide();
            Y9.Hide();
            Y10.Hide();
            Y11.Hide();
            Y12.Hide();
            R1.Hide();
            R2.Hide();
            R3.Hide();
            R4.Hide();
            R5.Hide();
            R6.Hide();
            R7.Hide();
            R8.Hide();
            R9.Hide();
            R10.Hide();
            R11.Hide();
            R12.Hide();
            lieche2.Hide();
            lieche4.Hide();
            lieche2label.Visible = false;
            lieche4label.Visible = false;
            textBox3.Text = "";
            textBox4.Text = "";
            int i = 0;
            int starty = lieche1.Location.Y;
            lieche1.Location = new Point(i, starty);
            //textBox1.Text = lieche1.Location.X.ToString();
            lieche1.Refresh();

            int j =0;
            int starty2 = lieche2.Location.Y;
            lieche2.Location = new Point(j, starty2);
            //textBox2.Text = lieche2.Location.X.ToString();
            lieche2.Refresh();


            int k = 1450;
            int starty3 = lieche3.Location.Y;
            lieche3.Location = new Point(k, starty3);
            lieche3.Refresh();

            int m = 1450;
            int starty4 = lieche4.Location.Y;
            lieche4.Location = new Point(m, starty4);
            lieche4.Refresh();


            go.Enabled = false;
            go2.Enabled = false;
            go2_3.Enabled = false;

            STOP.Enabled = true;
            START.Enabled = true;

        }
    }
}
