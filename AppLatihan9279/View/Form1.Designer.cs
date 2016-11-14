namespace AppLatihan9279.View
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNilai1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNilai2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnKurangi = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KALKULATOR SEDERHANA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(17, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 179);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNilai1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNilai2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHasil, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53933F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.06742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53933F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNilai1
            // 
            this.txtNilai1.Location = new System.Drawing.Point(89, 3);
            this.txtNilai1.Multiline = true;
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(108, 26);
            this.txtNilai1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNilai2
            // 
            this.txtNilai2.Location = new System.Drawing.Point(89, 35);
            this.txtNilai2.Multiline = true;
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(108, 25);
            this.txtNilai2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hasil";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(89, 147);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(108, 28);
            this.txtHasil.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(224, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 179);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnTambah, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnKali, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnKurangi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBagi, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.GreenYellow;
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTambah.FlatAppearance.BorderSize = 2;
            this.btnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(3, 3);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(71, 44);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKali
            // 
            this.btnKali.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKali.FlatAppearance.BorderSize = 2;
            this.btnKali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnKali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnKali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKali.Location = new System.Drawing.Point(80, 3);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(71, 44);
            this.btnKali.TabIndex = 1;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = false;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnKurangi
            // 
            this.btnKurangi.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKurangi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKurangi.FlatAppearance.BorderSize = 2;
            this.btnKurangi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnKurangi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnKurangi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKurangi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurangi.Location = new System.Drawing.Point(3, 53);
            this.btnKurangi.Name = "btnKurangi";
            this.btnKurangi.Size = new System.Drawing.Size(71, 44);
            this.btnKurangi.TabIndex = 2;
            this.btnKurangi.Text = "-";
            this.btnKurangi.UseVisualStyleBackColor = false;
            this.btnKurangi.Click += new System.EventHandler(this.btnKurangi_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBagi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBagi.FlatAppearance.BorderSize = 2;
            this.btnBagi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnBagi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnBagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagi.Location = new System.Drawing.Point(80, 53);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(71, 44);
            this.btnBagi.TabIndex = 3;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = false;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.GreenYellow;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 58);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(390, 286);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNilai1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNilai2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnKurangi;
        private System.Windows.Forms.Button btnBagi;
    }
}