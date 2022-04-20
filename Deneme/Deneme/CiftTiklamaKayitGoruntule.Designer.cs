namespace Deneme
{
    partial class CiftTiklamaKayitGoruntule
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtTelefonn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmaill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisimm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsimm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(396, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(25, 25);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtTelefonn
            // 
            this.txtTelefonn.Location = new System.Drawing.Point(172, 205);
            this.txtTelefonn.Name = "txtTelefonn";
            this.txtTelefonn.Size = new System.Drawing.Size(212, 26);
            this.txtTelefonn.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon";
            // 
            // txtEmaill
            // 
            this.txtEmaill.Location = new System.Drawing.Point(172, 149);
            this.txtEmaill.Name = "txtEmaill";
            this.txtEmaill.Size = new System.Drawing.Size(212, 26);
            this.txtEmaill.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email Adres";
            // 
            // txtSoyisimm
            // 
            this.txtSoyisimm.Location = new System.Drawing.Point(172, 98);
            this.txtSoyisimm.Name = "txtSoyisimm";
            this.txtSoyisimm.Size = new System.Drawing.Size(212, 26);
            this.txtSoyisimm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyisim";
            // 
            // txtIsimm
            // 
            this.txtIsimm.Location = new System.Drawing.Point(172, 48);
            this.txtIsimm.Name = "txtIsimm";
            this.txtIsimm.Size = new System.Drawing.Size(212, 26);
            this.txtIsimm.TabIndex = 8;
            this.txtIsimm.TextChanged += new System.EventHandler(this.txtIsimm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "İsim";
            // 
            // CiftTiklamaKayitGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 272);
            this.Controls.Add(this.txtTelefonn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmaill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyisimm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsimm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CiftTiklamaKayitGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CiftTiklamaKayitGoruntule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtTelefonn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmaill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyisimm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsimm;
        private System.Windows.Forms.Label label1;
    }
}