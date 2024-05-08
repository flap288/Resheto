namespace Resheto
{
    partial class Auth
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
            AuthLogin=new TextBox();
            AuthPwd=new TextBox();
            MakeAuth=new Button();
            GoReg=new Button();
            SuspendLayout();
            // 
            // AuthLogin
            // 
            AuthLogin.Location=new Point(12, 12);
            AuthLogin.Name="AuthLogin";
            AuthLogin.Size=new Size(362, 27);
            AuthLogin.TabIndex=0;
            // 
            // AuthPwd
            // 
            AuthPwd.Location=new Point(12, 45);
            AuthPwd.Name="AuthPwd";
            AuthPwd.PasswordChar='*';
            AuthPwd.Size=new Size(362, 27);
            AuthPwd.TabIndex=1;
            // 
            // MakeAuth
            // 
            MakeAuth.Location=new Point(113, 78);
            MakeAuth.Name="MakeAuth";
            MakeAuth.Size=new Size(94, 29);
            MakeAuth.TabIndex=2;
            MakeAuth.Text="Войти";
            MakeAuth.UseVisualStyleBackColor=true;
            MakeAuth.Click+=MakeAuth_Click;
            // 
            // GoReg
            // 
            GoReg.Location=new Point(213, 78);
            GoReg.Name="GoReg";
            GoReg.Size=new Size(161, 29);
            GoReg.TabIndex=3;
            GoReg.Text="Зарегистрироваться";
            GoReg.UseVisualStyleBackColor=true;
            GoReg.Click+=GoReg_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(410, 126);
            Controls.Add(GoReg);
            Controls.Add(MakeAuth);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLogin);
            Name="Auth";
            Text="Авторизация";
            FormClosed+=Auth_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLogin;
        private TextBox AuthPwd;
        private Button MakeAuth;
        private Button GoReg;
    }
}