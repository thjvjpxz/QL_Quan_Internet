namespace QLTK
{
    partial class FTaoTK
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(135, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(136, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(135, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(136, 20);
            this.txtPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(135, 132);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(96, 35);
            this.btnTaoTK.TabIndex = 3;
            this.btnTaoTK.Text = "Tạo";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // FTaoTK
            // 
            this.AcceptButton = this.btnTaoTK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 224);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoTK;
    }
}