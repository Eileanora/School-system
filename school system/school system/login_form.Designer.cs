namespace school_system
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Password_TextBox);
            this.panelControl1.Controls.Add(this.Password_label);
            this.panelControl1.Controls.Add(this.Login_Button);
            this.panelControl1.Controls.Add(this.Username_TextBox);
            this.panelControl1.Controls.Add(this.UserName_label);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(597, 362);
            this.panelControl1.TabIndex = 0;
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserName_label.Location = new System.Drawing.Point(358, 86);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(213, 36);
            this.UserName_label.TabIndex = 0;
            this.UserName_label.Text = "اسم المستخدم";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Username_TextBox.Location = new System.Drawing.Point(136, 86);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(177, 38);
            this.Username_TextBox.TabIndex = 1;
            // 
            // Login_Button
            // 
            this.Login_Button.Appearance.Font = new System.Drawing.Font("GE SS Two Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Login_Button.Appearance.Options.UseFont = true;
            this.Login_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login_Button.ImageOptions.Image")));
            this.Login_Button.Location = new System.Drawing.Point(211, 212);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Login_Button.Size = new System.Drawing.Size(186, 73);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "تسجيل الدخول";
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Password_label.Location = new System.Drawing.Point(429, 142);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(142, 36);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "كلمة السر";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("GE SS Two Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Password_TextBox.Location = new System.Drawing.Point(136, 143);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(177, 30);
            this.Password_TextBox.TabIndex = 4;
            // 
            // login_form
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 362);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "login_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "login_form";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_label;
        private DevExpress.XtraEditors.SimpleButton Login_Button;
        private System.Windows.Forms.TextBox Username_TextBox;
    }
}