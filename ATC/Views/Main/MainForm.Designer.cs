namespace ATC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HiComBut = new Bunifu.Framework.UI.BunifuTileButton();
            this.T_76But = new Bunifu.Framework.UI.BunifuTileButton();
            this.DX_500But = new Bunifu.Framework.UI.BunifuTileButton();
            this.HipassBut = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.N_group = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.AllTestsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.AboutProgram = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 57);
            this.panel2.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel1.Location = new System.Drawing.Point(267, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(238, 21);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Программа для тестирования ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ImageKey = "(отсутствует)";
            this.button2.Location = new System.Drawing.Point(708, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ImageKey = "(отсутствует)";
            this.button1.Location = new System.Drawing.Point(730, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // HiComBut
            // 
            this.HiComBut.BackColor = System.Drawing.Color.SeaGreen;
            this.HiComBut.color = System.Drawing.Color.SeaGreen;
            this.HiComBut.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.HiComBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HiComBut.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.HiComBut.ForeColor = System.Drawing.Color.White;
            this.HiComBut.Image = ((System.Drawing.Image)(resources.GetObject("HiComBut.Image")));
            this.HiComBut.ImagePosition = 20;
            this.HiComBut.ImageZoom = 50;
            this.HiComBut.LabelPosition = 41;
            this.HiComBut.LabelText = "HiCom";
            this.HiComBut.Location = new System.Drawing.Point(42, 30);
            this.HiComBut.Margin = new System.Windows.Forms.Padding(6);
            this.HiComBut.Name = "HiComBut";
            this.HiComBut.Size = new System.Drawing.Size(190, 158);
            this.HiComBut.TabIndex = 5;
            this.HiComBut.Click += new System.EventHandler(this.HiComBut_Click);
            // 
            // T_76But
            // 
            this.T_76But.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T_76But.color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T_76But.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.T_76But.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T_76But.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.T_76But.ForeColor = System.Drawing.Color.White;
            this.T_76But.Image = ((System.Drawing.Image)(resources.GetObject("T_76But.Image")));
            this.T_76But.ImagePosition = 20;
            this.T_76But.ImageZoom = 50;
            this.T_76But.LabelPosition = 41;
            this.T_76But.LabelText = "T-76";
            this.T_76But.Location = new System.Drawing.Point(300, 30);
            this.T_76But.Margin = new System.Windows.Forms.Padding(6);
            this.T_76But.Name = "T_76But";
            this.T_76But.Size = new System.Drawing.Size(190, 158);
            this.T_76But.TabIndex = 6;
            this.T_76But.Click += new System.EventHandler(this.T_76But_Click);
            // 
            // DX_500But
            // 
            this.DX_500But.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DX_500But.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DX_500But.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DX_500But.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DX_500But.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.DX_500But.ForeColor = System.Drawing.Color.White;
            this.DX_500But.Image = ((System.Drawing.Image)(resources.GetObject("DX_500But.Image")));
            this.DX_500But.ImagePosition = 20;
            this.DX_500But.ImageZoom = 50;
            this.DX_500But.LabelPosition = 41;
            this.DX_500But.LabelText = "DX-500";
            this.DX_500But.Location = new System.Drawing.Point(42, 217);
            this.DX_500But.Margin = new System.Windows.Forms.Padding(6);
            this.DX_500But.Name = "DX_500But";
            this.DX_500But.Size = new System.Drawing.Size(190, 158);
            this.DX_500But.TabIndex = 7;
            this.DX_500But.Click += new System.EventHandler(this.DX_500But_Click);
            // 
            // HipassBut
            // 
            this.HipassBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HipassBut.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HipassBut.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HipassBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HipassBut.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.HipassBut.ForeColor = System.Drawing.Color.White;
            this.HipassBut.Image = ((System.Drawing.Image)(resources.GetObject("HipassBut.Image")));
            this.HipassBut.ImagePosition = 20;
            this.HipassBut.ImageZoom = 50;
            this.HipassBut.LabelPosition = 41;
            this.HipassBut.LabelText = "Hipath";
            this.HipassBut.Location = new System.Drawing.Point(300, 217);
            this.HipassBut.Margin = new System.Windows.Forms.Padding(6);
            this.HipassBut.Name = "HipassBut";
            this.HipassBut.Size = new System.Drawing.Size(190, 158);
            this.HipassBut.TabIndex = 8;
            this.HipassBut.Click += new System.EventHandler(this.HipassBut_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.AutoScroll = true;
            this.bunifuPanel1.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.N_group);
            this.bunifuPanel1.Controls.Add(this.FIO);
            this.bunifuPanel1.Controls.Add(this.AllTestsButton);
            this.bunifuPanel1.Controls.Add(this.AboutProgram);
            this.bunifuPanel1.Controls.Add(this.HipassBut);
            this.bunifuPanel1.Controls.Add(this.DX_500But);
            this.bunifuPanel1.Controls.Add(this.HiComBut);
            this.bunifuPanel1.Controls.Add(this.T_76But);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 57);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(757, 432);
            this.bunifuPanel1.TabIndex = 12;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel3.Location = new System.Drawing.Point(349, 400);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(87, 21);
            this.bunifuLabel3.TabIndex = 21;
            this.bunifuLabel3.Text = "№ группы:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel2.Location = new System.Drawing.Point(3, 400);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(176, 21);
            this.bunifuLabel2.TabIndex = 20;
            this.bunifuLabel2.Text = "Фамилия и инициалы:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // N_group
            // 
            this.N_group.Location = new System.Drawing.Point(442, 401);
            this.N_group.Name = "N_group";
            this.N_group.Size = new System.Drawing.Size(110, 20);
            this.N_group.TabIndex = 19;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(190, 401);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(110, 20);
            this.FIO.TabIndex = 18;
            // 
            // AllTestsButton
            // 
            this.AllTestsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllTestsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllTestsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AllTestsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllTestsButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AllTestsButton.ForeColor = System.Drawing.Color.White;
            this.AllTestsButton.Image = ((System.Drawing.Image)(resources.GetObject("AllTestsButton.Image")));
            this.AllTestsButton.ImagePosition = 20;
            this.AllTestsButton.ImageZoom = 50;
            this.AllTestsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AllTestsButton.LabelPosition = 41;
            this.AllTestsButton.LabelText = "Общий тест";
            this.AllTestsButton.Location = new System.Drawing.Point(518, 130);
            this.AllTestsButton.Margin = new System.Windows.Forms.Padding(6);
            this.AllTestsButton.Name = "AllTestsButton";
            this.AllTestsButton.Size = new System.Drawing.Size(190, 158);
            this.AllTestsButton.TabIndex = 9;
            this.AllTestsButton.Click += new System.EventHandler(this.AllTestsButton_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.ActiveImage = null;
            this.AboutProgram.AllowAnimations = true;
            this.AboutProgram.AllowBuffering = false;
            this.AboutProgram.AllowToggling = false;
            this.AboutProgram.AllowZooming = true;
            this.AboutProgram.AllowZoomingOnFocus = false;
            this.AboutProgram.BackColor = System.Drawing.Color.Transparent;
            this.AboutProgram.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AboutProgram.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AboutProgram.ErrorImage")));
            this.AboutProgram.FadeWhenInactive = false;
            this.AboutProgram.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.AboutProgram.Image = ((System.Drawing.Image)(resources.GetObject("AboutProgram.Image")));
            this.AboutProgram.ImageActive = null;
            this.AboutProgram.ImageLocation = null;
            this.AboutProgram.ImageMargin = 0;
            this.AboutProgram.ImageSize = new System.Drawing.Size(35, 37);
            this.AboutProgram.ImageZoomSize = new System.Drawing.Size(36, 38);
            this.AboutProgram.InitialImage = ((System.Drawing.Image)(resources.GetObject("AboutProgram.InitialImage")));
            this.AboutProgram.Location = new System.Drawing.Point(719, 392);
            this.AboutProgram.Margin = new System.Windows.Forms.Padding(2);
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Rotation = 0;
            this.AboutProgram.ShowActiveImage = true;
            this.AboutProgram.ShowCursorChanges = true;
            this.AboutProgram.ShowImageBorders = true;
            this.AboutProgram.ShowSizeMarkers = false;
            this.AboutProgram.Size = new System.Drawing.Size(36, 38);
            this.AboutProgram.TabIndex = 17;
            this.AboutProgram.ToolTipText = "";
            this.AboutProgram.WaitOnLoad = false;
            this.AboutProgram.Zoom = 0;
            this.AboutProgram.ZoomSpeed = 10;
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(757, 490);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATC";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuTileButton HipassBut;
        public Bunifu.Framework.UI.BunifuTileButton DX_500But;
        public Bunifu.Framework.UI.BunifuTileButton T_76But;
        public Bunifu.Framework.UI.BunifuTileButton HiComBut;
        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.Framework.UI.BunifuTileButton AllTestsButton;
        public Bunifu.UI.WinForms.BunifuImageButton AboutProgram;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox N_group;
        private System.Windows.Forms.TextBox FIO;
    }
}

