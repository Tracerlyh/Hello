namespace 及时聊天工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Registrationbutton = new System.Windows.Forms.Button();
            this.Id_Input = new System.Windows.Forms.TextBox();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Close_Window = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Loginbutton, "Loginbutton");
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbutton.FlatAppearance.BorderSize = 0;
            this.Loginbutton.ForeColor = System.Drawing.Color.Black;
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Registrationbutton
            // 
            this.Registrationbutton.BackColor = System.Drawing.Color.Silver;
            this.Registrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrationbutton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Registrationbutton, "Registrationbutton");
            this.Registrationbutton.ForeColor = System.Drawing.Color.Black;
            this.Registrationbutton.Name = "Registrationbutton";
            this.Registrationbutton.UseVisualStyleBackColor = false;
            // 
            // Id_Input
            // 
            resources.ApplyResources(this.Id_Input, "Id_Input");
            this.Id_Input.ForeColor = System.Drawing.Color.Black;
            this.Id_Input.Name = "Id_Input";
            // 
            // Password_Input
            // 
            resources.ApplyResources(this.Password_Input, "Password_Input");
            this.Password_Input.ForeColor = System.Drawing.Color.Black;
            this.Password_Input.Name = "Password_Input";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Name = "username";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Name = "password";
            // 
            // Close_Window
            // 
            this.Close_Window.BackColor = System.Drawing.Color.Transparent;
            this.Close_Window.BackgroundImage = global::及时聊天工具.Properties.Resources.关闭2;
            resources.ApplyResources(this.Close_Window, "Close_Window");
            this.Close_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Window.FlatAppearance.BorderSize = 0;
            this.Close_Window.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close_Window.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.UseVisualStyleBackColor = false;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            this.Close_Window.MouseEnter += new System.EventHandler(this.Close_Window_MouseEnter);
            this.Close_Window.MouseLeave += new System.EventHandler(this.Close_Window_MouseLeave);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::及时聊天工具.Properties.Resources.背景2;
            this.Controls.Add(this.Close_Window);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Id_Input);
            this.Controls.Add(this.Registrationbutton);
            this.Controls.Add(this.Loginbutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Registrationbutton;
        private System.Windows.Forms.TextBox Id_Input;
        private System.Windows.Forms.TextBox Password_Input;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Close_Window;
    }
}

