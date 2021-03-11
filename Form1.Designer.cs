
namespace AMS
{
    partial class InitialField
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialField));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UsernamePanel = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.heldpanel = new System.Windows.Forms.Panel();
            this.AvanteLogoPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.heldpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginPanel.AutoScroll = true;
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.passwordlabel);
            this.LoginPanel.Controls.Add(this.usernamelabel);
            this.LoginPanel.Controls.Add(this.password);
            this.LoginPanel.Controls.Add(this.UsernamePanel);
            this.LoginPanel.Location = new System.Drawing.Point(324, 356);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(187, 165);
            this.LoginPanel.TabIndex = 1;
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.AcceptsReturn = true;
            this.UsernamePanel.AcceptsTab = true;
            this.UsernamePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernamePanel.Location = new System.Drawing.Point(0, 25);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(187, 20);
            this.UsernamePanel.TabIndex = 0;
            this.UsernamePanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.Location = new System.Drawing.Point(0, 81);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(187, 20);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(-3, 9);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(106, 13);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Type your username:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(-3, 65);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(105, 13);
            this.passwordlabel.TabIndex = 3;
            this.passwordlabel.Text = "Type your password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginButton.Location = new System.Drawing.Point(59, 123);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.WelcomeLabel.Location = new System.Drawing.Point(255, 298);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(320, 20);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome to your Management System!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // heldpanel
            // 
            this.heldpanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.heldpanel.AutoScroll = true;
            this.heldpanel.AutoSize = true;
            this.heldpanel.Controls.Add(this.AvanteLogoPanel);
            this.heldpanel.Location = new System.Drawing.Point(259, 83);
            this.heldpanel.Name = "heldpanel";
            this.heldpanel.Size = new System.Drawing.Size(340, 234);
            this.heldpanel.TabIndex = 4;
            // 
            // AvanteLogoPanel
            // 
            this.AvanteLogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvanteLogoPanel.AutoSize = true;
            this.AvanteLogoPanel.BackgroundImage = global::AMS.Properties.Resources.Logo_AVANTE_Colour;
            this.AvanteLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvanteLogoPanel.Location = new System.Drawing.Point(0, 39);
            this.AvanteLogoPanel.Name = "AvanteLogoPanel";
            this.AvanteLogoPanel.Size = new System.Drawing.Size(316, 161);
            this.AvanteLogoPanel.TabIndex = 0;
            this.AvanteLogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AvanteLogoPanel_Paint);
            // 
            // InitialField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.heldpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitialField";
            this.Text = "AMS - Avante Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InitialField_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.heldpanel.ResumeLayout(false);
            this.heldpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AvanteLogoPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox UsernamePanel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel heldpanel;
    }
}

