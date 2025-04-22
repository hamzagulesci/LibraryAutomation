namespace Proje
{
    partial class LoginEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEkrani));
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblHesapOlustur = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picboxPassword = new System.Windows.Forms.PictureBox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.Color.Black;
            this.pnlOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOperation.Controls.Add(this.btnLogin);
            this.pnlOperation.Controls.Add(this.lblHesapOlustur);
            this.pnlOperation.Controls.Add(this.txtPassword);
            this.pnlOperation.Controls.Add(this.picboxPassword);
            this.pnlOperation.Controls.Add(this.txtUserName);
            this.pnlOperation.Controls.Add(this.picboxUser);
            this.pnlOperation.Controls.Add(this.lblLine);
            this.pnlOperation.Controls.Add(this.lblLogin);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(406, 398);
            this.pnlOperation.TabIndex = 56;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Giriş Yap";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Silver;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Black;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(123, 272);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 41);
            this.btnLogin.TabIndex = 59;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHesapOlustur
            // 
            this.lblHesapOlustur.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblHesapOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHesapOlustur.AutoSize = true;
            this.lblHesapOlustur.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapOlustur.LinkColor = System.Drawing.Color.Silver;
            this.lblHesapOlustur.Location = new System.Drawing.Point(12, 373);
            this.lblHesapOlustur.Name = "lblHesapOlustur";
            this.lblHesapOlustur.Size = new System.Drawing.Size(90, 16);
            this.lblHesapOlustur.TabIndex = 7;
            this.lblHesapOlustur.TabStop = true;
            this.lblHesapOlustur.Text = "Hesap oluştur";
            this.lblHesapOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHesapOlustur_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(94, 201);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 33);
            this.txtPassword.TabIndex = 58;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // picboxPassword
            // 
            this.picboxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.picboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxPassword.BackgroundImage")));
            this.picboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxPassword.Location = new System.Drawing.Point(36, 201);
            this.picboxPassword.Name = "picboxPassword";
            this.picboxPassword.Size = new System.Drawing.Size(32, 33);
            this.picboxPassword.TabIndex = 5;
            this.picboxPassword.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUserName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(94, 131);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(287, 33);
            this.txtUserName.TabIndex = 57;
            this.txtUserName.Text = "Kullanıcı adı";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // picboxUser
            // 
            this.picboxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxUser.BackColor = System.Drawing.Color.Transparent;
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxUser.Location = new System.Drawing.Point(36, 138);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(32, 33);
            this.picboxUser.TabIndex = 4;
            this.picboxUser.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLine.Location = new System.Drawing.Point(31, 102);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(350, 1);
            this.lblLine.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.lblLogin.Location = new System.Drawing.Point(31, 62);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(130, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "OTURUM AÇ";
            // 
            // LoginEkrani
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(405, 398);
            this.Controls.Add(this.pnlOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.LinkLabel lblHesapOlustur;
        private System.Windows.Forms.PictureBox picboxPassword;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
    }
}

