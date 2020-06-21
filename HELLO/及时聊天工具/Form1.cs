using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 及时聊天工具
{
    public partial class Form1 : Form
    {
        bool isclose=false;//判断窗体是否已经关闭，1为已经关闭，0为未关闭
        public Form1()
        {
            InitializeComponent();
        }
        //点击按钮关闭应用程序
        private void Close_Window_Click(object sender, EventArgs e)
        {
            isclose = true;
            Application.Exit();
        }
        //鼠标移动到上面更改图标颜色
        private void Close_Window_MouseHover(object sender, EventArgs e)
        {
            if (!isclose)
            {
                Close_Window.BackgroundImage = imageList1.Images[1];
            }

        }

        private void Close_Window_MouseLeave(object sender, EventArgs e)
        {
            if (!isclose)
            {
                Close_Window.BackgroundImage = imageList1.Images[0];
            }

        }
        bool beginMove = false;//判断是否开始移动
        int currentXPosition;//x坐标
        int currentYPosition;//y坐标
        private void TOPpictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void TOPpictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void TOPpictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }
    }
}
