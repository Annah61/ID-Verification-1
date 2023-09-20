namespace ID_Verification_1
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
            label1=new Label();
            txtIdNumber=new TextBox();
            btnVerify=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(32, 68);
            label1.Name="label1";
            label1.Size=new Size(100, 25);
            label1.TabIndex=0;
            label1.Text="ID Number";
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location=new Point(190, 68);
            txtIdNumber.Name="txtIdNumber";
            txtIdNumber.Size=new Size(150, 31);
            txtIdNumber.TabIndex=1;
            // 
            // btnVerify
            // 
            btnVerify.Location=new Point(190, 203);
            btnVerify.Name="btnVerify";
            btnVerify.Size=new Size(112, 34);
            btnVerify.TabIndex=2;
            btnVerify.Text="Verify";
            btnVerify.UseVisualStyleBackColor=true;
            btnVerify.Click+=btnVerify_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnVerify);
            Controls.Add(txtIdNumber);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdNumber;
        private Button btnVerify;
    }
}