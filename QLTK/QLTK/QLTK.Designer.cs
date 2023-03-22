namespace QLTK
{
    partial class QLTK
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(668, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(722, 95);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(105, 69);
            this.btnTao.TabIndex = 1;
            this.btnTao.Text = "Tạo tài khoản";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(722, 214);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(105, 69);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(722, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 69);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(794, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(676, 42);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(112, 20);
            this.txtTuKhoa.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button button1;
    }
}

