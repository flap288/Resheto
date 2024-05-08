namespace Resheto
{
    partial class Reg
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
            RegLogin=new TextBox();
            RegPwd=new TextBox();
            MakeReg=new Button();
            SuspendLayout();
            // 
            // RegLogin
            // 
            RegLogin.Location=new Point(12, 12);
            RegLogin.Name="RegLogin";
            RegLogin.Size=new Size(335, 27);
            RegLogin.TabIndex=0;
            RegLogin.TextChanged+=RegLogin_TextChanged;
            // 
            // RegPwd
            // 
            RegPwd.Location=new Point(12, 45);
            RegPwd.Name="RegPwd";
            RegPwd.Size=new Size(335, 27);
            RegPwd.TabIndex=1;
            // 
            // MakeReg
            // 
            MakeReg.Location=new Point(177, 111);
            MakeReg.Name="MakeReg";
            MakeReg.Size=new Size(170, 29);
            MakeReg.TabIndex=3;
            MakeReg.Text="Зарегестрироваться";
            MakeReg.UseVisualStyleBackColor=true;
            MakeReg.Click+=button1_Click;
            // 
            // Reg
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(392, 166);
            Controls.Add(MakeReg);
            Controls.Add(RegPwd);
            Controls.Add(RegLogin);
            Name="Reg";
            Text="Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegLogin;
        private TextBox RegPwd;
        private TextBox textBox3;
        private Button MakeReg;
    }
}