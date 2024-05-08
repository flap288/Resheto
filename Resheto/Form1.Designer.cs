namespace Resheto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Make=new Button();
            Output=new Label();
            n1=new Label();
            Input1=new TextBox();
            SuspendLayout();
            // 
            // Make
            // 
            Make.Location=new Point(168, 45);
            Make.Name="Make";
            Make.Size=new Size(123, 29);
            Make.TabIndex=0;
            Make.Text="сортировать";
            Make.UseVisualStyleBackColor=true;
            Make.Click+=Make_Click;
            // 
            // Output
            // 
            Output.AutoSize=true;
            Output.Location=new Point(12, 87);
            Output.Name="Output";
            Output.Size=new Size(75, 20);
            Output.TabIndex=2;
            Output.Text="Результат";
            // 
            // n1
            // 
            n1.AutoSize=true;
            n1.Location=new Point(12, 9);
            n1.Name="n1";
            n1.Size=new Size(25, 20);
            n1.TabIndex=4;
            n1.Text="n1";
            // 
            // Input1
            // 
            Input1.Location=new Point(43, 12);
            Input1.Name="Input1";
            Input1.Size=new Size(390, 27);
            Input1.TabIndex=3;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(621, 210);
            Controls.Add(n1);
            Controls.Add(Input1);
            Controls.Add(Output);
            Controls.Add(Make);
            Name="Form1";
            Text="Решето Эратосфена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Make;
        private Label Output;
        private Label n1;
        private TextBox Input1;
    }
}