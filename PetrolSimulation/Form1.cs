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
using System.Diagnostics;

namespace PetrolSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-48R5JDT\SQLEXPRESS01;Initial Catalog=DBPetrol;Integrated Security=True");

        void listele()
        {
            //Kursunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZİN where PETROLTUR='Kursunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                LblKursunsuz95Alis.Text = dr[2].ToString();
                progressBar1.Value = Convert.ToInt32(Convert.ToInt32(dr[4]));
                LblKursunsuz95Kalan.Text = dr[4].ToString();
            }
            baglanti.Close();

            //dieselmax
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZİN where PETROLTUR='dieselmax'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDieselMax.Text = dr2[3].ToString();
                LblDieselMaxAlis.Text = dr2[2].ToString();
                progressBar2.Value = Convert.ToInt32(Convert.ToInt32(dr2[4]));
                LblDieselMaxKalan.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //dieselpro
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZİN where PETROLTUR='dieselpro'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblDieselPro.Text = dr3[3].ToString();
                LblDieselProAlis.Text = dr3[2].ToString();
                progressBar3.Value = Convert.ToInt32(Convert.ToInt32(dr3[4]));
                LblDieselProKalan.Text = dr3[4].ToString();
            }
            baglanti.Close();

            //gaz
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZİN where PETROLTUR='gaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblGaz.Text = dr4[3].ToString();
                LblGazAlis.Text = dr4[2].ToString();
                progressBar4.Value = Convert.ToInt32(Convert.ToInt32(dr4[4]));
                LblGazKalan.Text = dr4[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from tblkasa",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double DieselMax, litre, tutar;
            DieselMax = Convert.ToDouble(LblDieselMax.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = DieselMax * litre;
            TxtDieselMaxFiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double DieselPro, litre, tutar;
            DieselPro = Convert.ToDouble(LblDieselPro.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = DieselPro * litre;
            TxtDieselProFiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double Gaz, litre, tutar;
            Gaz = Convert.ToDouble(LblGaz.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = Gaz * litre;
            TxtGazFiyat.Text = tutar.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != 0)
            {
                if (TxtPlaka.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert tblhareket (plaka,benzınturu,lıtre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                    komut.Parameters.AddWithValue("@p2", "Kursunsuz95");
                    komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                    komut.Parameters.AddWithValue("@p4", Decimal.Parse(TxtKursunsuz95Fiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar=mıktar+@p1",baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtKursunsuz95Fiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update tblbenzin set stok=stok-@p1 where petroltur='kursunsuz95'",baglanti);
                    komut3.Parameters.AddWithValue("@p1",numericUpDown1.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İsleminiz Tamamlanmıştır");
                    listele();
                    numericUpDown1.Value = 0;
                    TxtPlaka.Text = "";
                }
                else
                {
                    MessageBox.Show("Lutfen Plakanizi giriniz");
                }
            }
            else if(numericUpDown2.Value !=0)
            {
                if (TxtPlaka.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert tblhareket (plaka,benzınturu,lıtre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                    komut.Parameters.AddWithValue("@p2", "DieselMax");
                    komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                    komut.Parameters.AddWithValue("@p4", Decimal.Parse(TxtDieselMaxFiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar=mıktar+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtDieselMaxFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update tblbenzin set stok=stok-@p1 where petroltur='DieselMax'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İsleminiz Tamamlanmıştır");
                    listele();
                    numericUpDown2.Value = 0;
                    TxtPlaka.Text = "";
                }
                else
                {
                    MessageBox.Show("Lutfen Plakanizi giriniz");
                }

            }
            else if (numericUpDown3.Value != 0)
            {
                if (TxtPlaka.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert tblhareket (plaka,benzınturu,lıtre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                    komut.Parameters.AddWithValue("@p2", "DieselPro");
                    komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                    komut.Parameters.AddWithValue("@p4", Decimal.Parse(TxtDieselProFiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar=mıktar+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtDieselProFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update tblbenzin set stok=stok-@p1 where petroltur='DieselPro'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İsleminiz Tamamlanmıştır");
                    listele();
                    numericUpDown3.Value = 0;
                    TxtPlaka.Text = "";
                }
                else
                {
                    MessageBox.Show("Lutfen Plakanizi giriniz");
                }
            }
            else if (numericUpDown4.Value != 0)
            {
                if (TxtPlaka.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert tblhareket (plaka,benzınturu,lıtre,fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                    komut.Parameters.AddWithValue("@p2", "Gaz");
                    komut.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                    komut.Parameters.AddWithValue("@p4", Decimal.Parse(TxtGazFiyat.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar=mıktar+@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", decimal.Parse(TxtGazFiyat.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update tblbenzin set stok=stok-@p1 where petroltur='Gaz'", baglanti);
                    komut3.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İsleminiz Tamamlanmıştır");
                    listele();
                    numericUpDown4.Value = 0;
                    TxtPlaka.Text = "";
                }
                else
                {
                    MessageBox.Show("Lutfen Plakanizi giriniz");
                }
            }
        }

        private void BtnKursunsuz95Doldur_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(LblKasa.Text) <0)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                if(TxtKursunsuz95Doldur.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Bir Değer Girin");
                }
                else
                {
                    if (progressBar1.Value + Convert.ToInt32(TxtKursunsuz95Doldur.Text) <= 10000)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update tblbenzin set stok=stok+@p1 where petroltur='kursunsuz95'", baglanti);
                        komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtKursunsuz95Doldur.Text));
                        progressBar1.Value += Convert.ToInt32(TxtKursunsuz95Doldur.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar - @p1", baglanti);
                        decimal miktar = Convert.ToDecimal(TxtKursunsuz95Doldur.Text) * Convert.ToDecimal(LblKursunsuz95Alis.Text);
                        komut2.Parameters.AddWithValue("@p1", miktar);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        TxtKursunsuz95Doldur.Text = "";
                        listele();
                        MessageBox.Show("Satın Alım İşlemi Gerçekleşti");
                    }
                    else
                    {
                        MessageBox.Show("Depoyu Fazladan Doldurmaya Çalıştınız");
                    }
                }
            }
        }

        private void BtnDieselMaxDoldur_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(LblKasa.Text) < 0)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                if (TxtDieselMaxDoldur.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Bir Değer Girin");
                }
                else
                {
                    if (progressBar2.Value + Convert.ToInt32(TxtDieselMaxDoldur.Text) <= 10000)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update tblbenzin set stok=stok+@p1 where petroltur='DieselMax'", baglanti);
                        komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtDieselMaxDoldur.Text));
                        progressBar2.Value += Convert.ToInt32(TxtDieselMaxDoldur.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar - @p1", baglanti);
                        decimal miktar = Convert.ToDecimal(TxtDieselMaxDoldur.Text) * Convert.ToDecimal(LblDieselMaxAlis.Text);
                        komut2.Parameters.AddWithValue("@p1", miktar);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        TxtDieselMaxDoldur.Text = "";
                        listele();
                        MessageBox.Show("Satın Alım İşlemi Gerçekleşti");

                    }
                    else
                    {
                        MessageBox.Show("Depoyu Fazladan Doldurmaya Çalıştınız");
                    }
                }
            }
        }

        private void BtnDieselProDoldur_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(LblKasa.Text) < 0)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                if (TxtDieselProDoldur.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Bir Değer Girin");
                }
                else
                {
                    if (progressBar3.Value + Convert.ToInt32(TxtDieselProDoldur.Text) <= 10000)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update tblbenzin set stok=stok+@p1 where petroltur='DieselPro'", baglanti);
                        komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtDieselProDoldur.Text));
                        progressBar3.Value += Convert.ToInt32(TxtDieselProDoldur.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar - @p1", baglanti);
                        decimal miktar = Convert.ToDecimal(TxtDieselProDoldur.Text) * Convert.ToDecimal(LblDieselProAlis.Text);
                        komut2.Parameters.AddWithValue("@p1", miktar);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        TxtDieselProDoldur.Text = "";
                        listele();
                        MessageBox.Show("Satın Alım İşlemi Gerçekleşti");

                    }
                    else
                    {
                        MessageBox.Show("Depoyu Fazladan Doldurmaya Çalıştınız");
                    }
                }
            }
        }

        private void BtnGazDoldur_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(LblKasa.Text) < 0)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                if (TxtGazDoldur.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Bir Değer Girin");
                }
                else
                {
                    if (progressBar4.Value + Convert.ToInt32(TxtGazDoldur.Text) <= 10000)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update tblbenzin set stok=stok+@p1 where petroltur='Gaz'", baglanti);
                        komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtGazDoldur.Text));
                        progressBar4.Value += Convert.ToInt32(TxtGazDoldur.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("update tblkasa set mıktar = mıktar - @p1", baglanti);
                        decimal miktar = Convert.ToDecimal(TxtGazDoldur.Text) * Convert.ToDecimal(LblGazAlis.Text);
                        komut2.Parameters.AddWithValue("@p1", miktar);
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        TxtGazDoldur.Text = "";
                        listele();
                        MessageBox.Show("Satın Alım İşlemi Gerçekleşti");

                    }
                    else
                    {
                        MessageBox.Show("Depoyu Fazladan Doldurmaya Çalıştınız");
                    }
                }
            }
        }
    }
}
