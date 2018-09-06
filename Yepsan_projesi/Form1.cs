using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Yepsan_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            //VERİTABANI BAĞLANTIMIZI TANIMLADIK
            con = new SqlConnection("Data Source=LPAPDINAMO;Initial Catalog=LPAP_2017;Persist Security Info=True;User ID=DINAMO;Password=DINAMO");
            //COMCOBOX_KKODU İÇİNİ KULLANICI KODLARI İLE DOLDURUYORUZ.
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT KOD FROM UDEF";
            komut1.Connection = con;
            komut1.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                combobox_Kkodu.Items.Add(dr["KOD"]);
            }
            con.Close();
           
        }


        string Kullanici = Giris.Kullanici;


        private void combobox_Kkodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_getir1();
        }

        private void dgw_onay_liste_SelectionChanged(object sender, EventArgs e)
        {
            veri_getir2();
        }

        private void bttn_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void veri_getir1()
        {
            SqlCommand komut3 = new SqlCommand();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                //txtbx_Kadi kısmını dolduruyor.
                komut3.Connection = con;
            komut3.CommandText = "select AD_SOYAD from UDEF where KOD = '" + combobox_Kkodu.Text + "' ";
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                txtbx_Kadi.Text = dr[0].ToString();
            }
            dr.Close();
            //
            string S = "SELECT K.GK_2 AS 'ONAY SONUCU',ltrim(K.EVRAKNO) AS 'IS NO',K.YARATILMA_TARIHI AS 'TARİH', ltrim(K.IS_PR_KENO) AS 'TALEP NO', S.TARIH as 'TALEP TARİHİ', K.KONU AS 'KONU', S.CODEDKISI as 'TALEP EDEN KOD', P.AD as 'TALEP EDEN ADI', S.CODEDBOLUM as 'TALEP EDEN BÖLÜM', K.GK_3 AS 'ONAY SIRASI', K.IS_KIMINICIN AS 'SONRAKİ ONAY', U.AD_SOYAD AS 'ONAY KİŞİ',DATEDIFF(DAY,CONVERT(VARCHAR, S.TARIH, 101), GETDATE()) AS 'TOPLAM GEÇEN GÜN', S.SIPLEILGILINOTLAR_1 AS 'AÇIKLAMA', K.ACIK_KAPALI AS 'DURUM' FROM K00700E AS K INNER JOIN STOK47E AS S ON K.EVRAKNO=S.EVRAKNO INNER JOIN PERS00 AS P ON S.CODEDKISI=P.KOD INNER JOIN UDEF AS U ON K.IS_KIMINICIN=U.KOD WHERE K.ACIK_KAPALI='A' AND K.IS_KIMINICIN='" + combobox_Kkodu.Text+"' ";
            SqlCommand komut = new SqlCommand(S, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_onay_liste.DataSource = dt;
            con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("HATA!------------------" + E);
            }
        }

        private void veri_getir2()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string deger = dgw_onay_liste.CurrentRow.Cells["TALEP NO"].Value.ToString();       
                //dgw_talep_detay GRİDVİEV'İNİ DOLDURUYOR.
                string S = "SELECT ltrim(ST.TRNUM) AS 'ART NO', ltrim(ST.KOD) AS 'STOK KODU', S0.AD AS 'STOK ADI', ST.NOTE0 AS 'AÇIKLAMA', ST.SF_MIKTAR AS 'MİKTAR', ST.RTALEPEDILENTESTARIH AS 'TESLİM TARİHİ',  ST.OR_FIYAT AS 'BİRİM FİYAT', ST.OR_TUTAR AS 'TUTAR', ST.PRICEUNIT AS 'PARA BİRİMİ', S0.IUNIT AS 'BİRİM', ST.KUR AS 'KUR', (ST.OR_TUTAR*ST.KUR) AS 'TUTAR' FROM STOK47T AS ST INNER JOIN STOK00 AS S0 ON ST.KOD=S0.KOD WHERE ltrim(ST.EVRAKNO)='" + deger + "' ";
                SqlCommand komut = new SqlCommand(S, con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgw_talep_detay.DataSource = dt;
                con.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show("HATA!------------------" + E);
            }

         }

        private void bttn_onayla_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz? Bu işlem geri alınamaz.", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                //mail_gonder();
                //KAYITLARI VERİTABANINA EKLİYOR.
                /* con.Open();
                 cmdb = new SqlCommandBuilder(da);
                 da.Update(ds, "musteriler");
                 MessageBox.Show("Kayıt güncellendi");

                 MessageBox.Show("Kayıtlar güncellendi!");
                 dgw_onay_liste.Refresh();*/

            }
        }

        private void dgw_onay_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            //DATAGRİDVİEW'İN İLK SÜTUNUNDAKİ CHECKBOX'I KONTROL EDİYOR.
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgw_onay_liste.Rows[dgw_onay_liste.CurrentRow.Index].Cells[0];

            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "True":
                    ch1.Value = false;
                    break;
                case "False":
                    ch1.Value = true;
                    break;
            }
            //CHECKBOX DURUMUNA GÖRE ONAY SÜTUNUNUN DEĞERİNİ DEĞİŞTİRİYOR.
            if(ch1.Value.ToString()=="True")
            {
                dgw_onay_liste.CurrentRow.Cells["ONAY SONUCU"].Value = "01";
                dgw_onay_liste.CurrentRow.Cells["DURUM"].Value = "K";
            }
            else
            {
                dgw_onay_liste.CurrentRow.Cells["ONAY SONUCU"].Value = "";
                dgw_onay_liste.CurrentRow.Cells["DURUM"].Value = "A";
            }
            }
            catch(Exception E)
            {
                MessageBox.Show("HATA----------" + E);
            }
        }

        private void dgw_onay_liste_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //DATAGRİDVİEW SUTÜN SIRALAMASINI ENGELLİYOR.
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void bttn_hesapla_Click(object sender, EventArgs e)
        {
            dgw_onay_liste.Refresh();
            dgw_talep_detay.Refresh();
        }

        /* private void mail_gonder()
         {
         //MAİL GÖNDERMEYİ SAĞLIYOR.
             SmtpClient sc = new SmtpClient();
             sc.Port = 587;
             sc.Host = "smtp.ayref.com";
             sc.EnableSsl = true;
             //?yep2016?
             sc.Credentials = new NetworkCredential("info@ayref.com", "Ayref2017");
             MailMessage mail = new MailMessage();
             mail.From = new MailAddress("info@ayref.com", "Yepsan");
             mail.To.Add("ebru_cakar_11@hotmail.com");

             mail.Subject = "selamlar";
             mail.IsBodyHtml = true;
             mail.Body = "asdfdfhfgyjnt";
              try
            {
                sc.Send(mail);
                MessageBox.Show("Mail Gönderildi !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Gönderilemedi, Sebebi: " + ex.Message);
            }
             
         }*/

    }
}
