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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Close_Window = new System.Windows.Forms.Button();
            this.TOPpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TOPpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "关闭2.png");
            this.imageList1.Images.SetKeyName(1, "关闭1.png");
            // 
            // Close_Window
            // 
            this.Close_Window.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Window.BackColor = System.Drawing.Color.Transparent;
            this.Close_Window.BackgroundImage = global::及时聊天工具.Properties.Resources.关闭2;
            this.Close_Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_Window.FlatAppearance.BorderSize = 0;
            this.Close_Window.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close_Window.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close_Window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Window.Location = new System.Drawing.Point(458, 12);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(30, 30);
            this.Close_Window.TabIndex = 0;
            this.Close_Window.UseVisualStyleBackColor = false;
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            this.Close_Window.MouseLeave += new System.EventHandler(this.Close_Window_MouseLeave);
            this.Close_Window.MouseHover += new System.EventHandler(this.Close_Window_MouseHover);
            // 
            // TOPpictureBox1
            // 
            this.TOPpictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TOPpictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.TOPpictureBox1.Location = new System.Drawing.Point(0, 0);
            this.TOPpictureBox1.Name = "TOPpictureBox1";
            this.TOPpictureBox1.Size = new System.Drawing.Size(500, 150);
            this.TOPpictureBox1.TabIndex = 1;
            this.TOPpictureBox1.TabStop = false;
            this.TOPpictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOPpictureBox1_MouseDown);
            this.TOPpictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TOPpictureBox1_MouseMove);
            this.TOPpictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TOPpictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.Close_Window);
            this.Controls.Add(this.TOPpictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TOPpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_Window;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox TOPpictureBox1;
    }
}

