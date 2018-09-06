namespace Yepsan_projesi
{
    partial class Giris
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
            this.bttn_Giris = new System.Windows.Forms.Button();
            this.lbl_uyarı = new System.Windows.Forms.Label();
            this.combobx_Kadi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttn_Giris
            // 
            this.bttn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_Giris.Location = new System.Drawing.Point(92, 124);
            this.bttn_Giris.Name = "bttn_Giris";
            this.bttn_Giris.Size = new System.Drawing.Size(88, 46);
            this.bttn_Giris.TabIndex = 0;
            this.bttn_Giris.Text = "Giriş";
            this.bttn_Giris.UseVisualStyleBackColor = true;
            this.bttn_Giris.Click += new System.EventHandler(this.bttn_Giris_Click);
            // 
            // lbl_uyarı
            // 
            this.lbl_uyarı.AutoSize = true;
            this.lbl_uyarı.Location = new System.Drawing.Point(67, 21);
            this.lbl_uyarı.Name = "lbl_uyarı";
            this.lbl_uyarı.Size = new System.Drawing.Size(145, 13);
            this.lbl_uyarı.TabIndex = 4;
            this.lbl_uyarı.Text = "KULLANICI GİRİŞİ YAPINIZ.";
            // 
            // combobx_Kadi
            // 
            this.combobx_Kadi.FormattingEnabled = true;
            this.combobx_Kadi.Location = new System.Drawing.Point(81, 49);
            this.combobx_Kadi.Name = "combobx_Kadi";
            this.combobx_Kadi.Size = new System.Drawing.Size(121, 21);
            this.combobx_Kadi.TabIndex = 3;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 228);
            this.Controls.Add(this.lbl_uyarı);
            this.Controls.Add(this.combobx_Kadi);
            this.Controls.Add(this.bttn_Giris);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Giris;
        private System.Windows.Forms.Label lbl_uyarı;
        private System.Windows.Forms.ComboBox combobx_Kadi;
    }
}