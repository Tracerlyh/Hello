using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 及时聊天工具
{
    public partial class Form1 : Form
    {
        bool isclose=false;//判断窗体是否已经关闭，1为已经关闭，0为未关闭
        public struct Message
        {
            private readonly string userName;
            private readonly string content;
            private readonly DateTime postDate;

            public Message(string userName, string content)
            {
                this.userName = userName;
                this.content = content;
                this.postDate = DateTime.Now;
            }

            public Message(string content) : this("System", content) { }

            public string UserName
            {
                get { return userName; }
            }

            public string Content
            {
                get { return content; }
            }

            public DateTime PostDate
            {
                get { return postDate; }
            }

            public override string ToString()
            {
                return String.Format("{0}[{1}]：\r\n{2}\r\n", userName, postDate, content);
            }
        }
        public interface IMessageSender
        {
            bool Connect(IPAddress ip, int port);       // 连接到服务端
            bool SendMessage(Message msg);              // 发送用户
            void SignOut();                                 // 注销系统
        }

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
        /*----------------------------关闭按钮鼠标移入移出效果实现-------------------------------------*/
        private void Close_Window_MouseEnter(object sender, EventArgs e)
        {
            if (!isclose)
            {
                //Close_Window.BackgroundImage = imageList1.Images[1];
                Close_Window.BackColor = Color.Transparent;
                Close_Window.BackgroundImage = Properties.Resources.关闭1;
            }
        }

        private void Close_Window_MouseLeave(object sender, EventArgs e)
        {
            if (!isclose)
            {
                //Close_Window.BackgroundImage = imageList1.Images[1];
                Close_Window.BackgroundImage = Properties.Resources.关闭2;
            }
        }
        bool beginMove = false;//判断是否开始移动
        int currentXPosition;//x坐标
        int currentYPosition;//y坐标

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

        }
        /*----------------------------窗口移动操作实现-------------------------------------*/
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
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
