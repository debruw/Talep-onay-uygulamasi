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

namespace Yepsan_projesi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;     
        private void Giris_Load(object sender, EventArgs e)
        {
            //VERİTABANI BAĞLANTIMIZI TANIMLADIK
            con = new SqlConnection("Data Source=YPSSQL;Initial Catalog=YEPSAN_2017;User ID=DINAMO;Password=12341234");
            //COMCOBOX_KKODU İÇİNİ KULLANICI KODLARI İLE DOLDURUYORUZ.
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT KOD FROM UDEF";
            komut1.Connection = con;
            komut1.CommandType = CommandType.Text;

            
            con.Open();
            dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                combobx_Kadi.Items.Add(dr["KOD"]);
            }
            con.Close();
        }
        public static string Kullanici;
        private void bttn_Giris_Click(object sender, EventArgs e)
        {
            string kontrol = "select * from UDEF where KOD='" + combobx_Kadi.Text + "'";//sorgumuzu oluşturuyoruz
            SqlCommand cmd = new SqlCommand(kontrol, con);//komutumuzu tanımladık
            con.Open();//bağlantıyı açtık
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Kullanici = combobx_Kadi.Text;
                this.Close();
                Form1 frm = new Form1();
                frm.Show();
            }//Kullanıcı adı kontrolü ile giriş yaptık.
            else
            {
                lbl_uyarı.Text = "Kullanıcı adı yanlış!";
                lbl_uyarı.ForeColor = Color.Red;
            }

            con.Close();//bağlantımızı kapattık

        }

        
    }
}
