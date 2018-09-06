namespace Yepsan_projesi
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
            this.bttn_onayla = new System.Windows.Forms.Button();
            this.bttn_hesapla = new System.Windows.Forms.Button();
            this.bttn_cıkıs = new System.Windows.Forms.Button();
            this.txtbx_Kadi = new System.Windows.Forms.TextBox();
            this.lbl_Kkodu = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.dtp_Tarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Tarih2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_aciklama = new System.Windows.Forms.TextBox();
            this.dgw_talep_detay = new System.Windows.Forms.DataGridView();
            this.SECIM2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgw_onay_liste = new System.Windows.Forms.DataGridView();
            this.SECIM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combobox_Kkodu = new System.Windows.Forms.ComboBox();
            this.lbl_isaret = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_talep_detay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_onay_liste)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_onayla
            // 
            this.bttn_onayla.Location = new System.Drawing.Point(12, 12);
            this.bttn_onayla.Name = "bttn_onayla";
            this.bttn_onayla.Size = new System.Drawing.Size(110, 40);
            this.bttn_onayla.TabIndex = 0;
            this.bttn_onayla.Text = "ONAYLA";
            this.bttn_onayla.UseVisualStyleBackColor = true;
            this.bttn_onayla.Click += new System.EventHandler(this.bttn_onayla_Click);
            // 
            // bttn_hesapla
            // 
            this.bttn_hesapla.Location = new System.Drawing.Point(155, 13);
            this.bttn_hesapla.Name = "bttn_hesapla";
            this.bttn_hesapla.Size = new System.Drawing.Size(110, 40);
            this.bttn_hesapla.TabIndex = 1;
            this.bttn_hesapla.Text = "LİSTE HESAPLA";
            this.bttn_hesapla.UseVisualStyleBackColor = true;
            this.bttn_hesapla.Click += new System.EventHandler(this.bttn_hesapla_Click);
            // 
            // bttn_cıkıs
            // 
            this.bttn_cıkıs.Location = new System.Drawing.Point(300, 12);
            this.bttn_cıkıs.Name = "bttn_cıkıs";
            this.bttn_cıkıs.Size = new System.Drawing.Size(110, 40);
            this.bttn_cıkıs.TabIndex = 2;
            this.bttn_cıkıs.Text = "ÇIKIŞ";
            this.bttn_cıkıs.UseVisualStyleBackColor = true;
            this.bttn_cıkıs.Click += new System.EventHandler(this.bttn_cıkıs_Click);
            // 
            // txtbx_Kadi
            // 
            this.txtbx_Kadi.Enabled = false;
            this.txtbx_Kadi.Location = new System.Drawing.Point(300, 71);
            this.txtbx_Kadi.Multiline = true;
            this.txtbx_Kadi.Name = "txtbx_Kadi";
            this.txtbx_Kadi.Size = new System.Drawing.Size(159, 21);
            this.txtbx_Kadi.TabIndex = 5;
            // 
            // lbl_Kkodu
            // 
            this.lbl_Kkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kkodu.Location = new System.Drawing.Point(13, 63);
            this.lbl_Kkodu.Name = "lbl_Kkodu";
            this.lbl_Kkodu.Size = new System.Drawing.Size(109, 35);
            this.lbl_Kkodu.TabIndex = 6;
            this.lbl_Kkodu.Text = "Kullanıcı Kodu : ";
            this.lbl_Kkodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(478, 63);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(62, 34);
            this.lbl_tarih.TabIndex = 7;
            this.lbl_tarih.Text = "Tarih : ";
            this.lbl_tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_Tarih1
            // 
            this.dtp_Tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Tarih1.Location = new System.Drawing.Point(543, 72);
            this.dtp_Tarih1.Name = "dtp_Tarih1";
            this.dtp_Tarih1.Size = new System.Drawing.Size(104, 20);
            this.dtp_Tarih1.TabIndex = 8;
            // 
            // dtp_Tarih2
            // 
            this.dtp_Tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Tarih2.Location = new System.Drawing.Point(689, 71);
            this.dtp_Tarih2.Name = "dtp_Tarih2";
            this.dtp_Tarih2.Size = new System.Drawing.Size(108, 20);
            this.dtp_Tarih2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 482);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbx_aciklama);
            this.tabPage1.Controls.Add(this.dgw_talep_detay);
            this.tabPage1.Controls.Add(this.dgw_onay_liste);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ONAY LİSTESİ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TALEP DETAYI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ONAY AÇIKLAMASI";
            // 
            // txtbx_aciklama
            // 
            this.txtbx_aciklama.Location = new System.Drawing.Point(7, 237);
            this.txtbx_aciklama.Multiline = true;
            this.txtbx_aciklama.Name = "txtbx_aciklama";
            this.txtbx_aciklama.Size = new System.Drawing.Size(212, 93);
            this.txtbx_aciklama.TabIndex = 2;
            // 
            // dgw_talep_detay
            // 
            this.dgw_talep_detay.AllowUserToAddRows = false;
            this.dgw_talep_detay.AllowUserToDeleteRows = false;
            this.dgw_talep_detay.AllowUserToOrderColumns = true;
            this.dgw_talep_detay.AllowUserToResizeColumns = false;
            this.dgw_talep_detay.AllowUserToResizeRows = false;
            this.dgw_talep_detay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgw_talep_detay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_talep_detay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SECIM2});
            this.dgw_talep_detay.Location = new System.Drawing.Point(225, 237);
            this.dgw_talep_detay.Name = "dgw_talep_detay";
            this.dgw_talep_detay.Size = new System.Drawing.Size(714, 213);
            this.dgw_talep_detay.TabIndex = 1;
            // 
            // SECIM2
            // 
            this.SECIM2.HeaderText = "Seçim";
            this.SECIM2.Name = "SECIM2";
            this.SECIM2.Width = 42;
            // 
            // dgw_onay_liste
            // 
            this.dgw_onay_liste.AllowUserToAddRows = false;
            this.dgw_onay_liste.AllowUserToDeleteRows = false;
            this.dgw_onay_liste.AllowUserToResizeColumns = false;
            this.dgw_onay_liste.AllowUserToResizeRows = false;
            this.dgw_onay_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw_onay_liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw_onay_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_onay_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SECIM});
            this.dgw_onay_liste.Location = new System.Drawing.Point(7, 7);
            this.dgw_onay_liste.MultiSelect = false;
            this.dgw_onay_liste.Name = "dgw_onay_liste";
            this.dgw_onay_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_onay_liste.Size = new System.Drawing.Size(932, 206);
            this.dgw_onay_liste.TabIndex = 0;
            this.dgw_onay_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_onay_liste_CellContentClick);
            this.dgw_onay_liste.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgw_onay_liste_ColumnAdded);
            this.dgw_onay_liste.SelectionChanged += new System.EventHandler(this.dgw_onay_liste_SelectionChanged);
            // 
            // SECIM
            // 
            this.SECIM.HeaderText = "SECIM";
            this.SECIM.Name = "SECIM";
            this.SECIM.Width = 46;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ONAYLANAN SİPARİŞLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // combobox_Kkodu
            // 
            this.combobox_Kkodu.FormattingEnabled = true;
            this.combobox_Kkodu.Location = new System.Drawing.Point(144, 71);
            this.combobox_Kkodu.Name = "combobox_Kkodu";
            this.combobox_Kkodu.Size = new System.Drawing.Size(130, 21);
            this.combobox_Kkodu.TabIndex = 11;
            this.combobox_Kkodu.SelectedIndexChanged += new System.EventHandler(this.combobox_Kkodu_SelectedIndexChanged);
            // 
            // lbl_isaret
            // 
            this.lbl_isaret.AutoSize = true;
            this.lbl_isaret.Location = new System.Drawing.Point(653, 74);
            this.lbl_isaret.Name = "lbl_isaret";
            this.lbl_isaret.Size = new System.Drawing.Size(19, 13);
            this.lbl_isaret.TabIndex = 12;
            this.lbl_isaret.Text = ">>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1007, 583);
            this.Controls.Add(this.lbl_isaret);
            this.Controls.Add(this.combobox_Kkodu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtp_Tarih2);
            this.Controls.Add(this.dtp_Tarih1);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_Kkodu);
            this.Controls.Add(this.txtbx_Kadi);
            this.Controls.Add(this.bttn_cıkıs);
            this.Controls.Add(this.bttn_hesapla);
            this.Controls.Add(this.bttn_onayla);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALEP ONAY UYGULAMASI(TALEP01)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_talep_detay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_onay_liste)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_onayla;
        private System.Windows.Forms.Button bttn_hesapla;
        private System.Windows.Forms.Button bttn_cıkıs;
        private System.Windows.Forms.TextBox txtbx_Kadi;
        private System.Windows.Forms.Label lbl_Kkodu;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.DateTimePicker dtp_Tarih1;
        private System.Windows.Forms.DateTimePicker dtp_Tarih2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_aciklama;
        private System.Windows.Forms.DataGridView dgw_talep_detay;
        private System.Windows.Forms.DataGridView dgw_onay_liste;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox combobox_Kkodu;
        private System.Windows.Forms.Label lbl_isaret;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SECIM2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SECIM;
    }
}

