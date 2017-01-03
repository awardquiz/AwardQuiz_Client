using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Diagnostics;
using System.Data.SqlClient;
using WindowsFormsApplication3.BLL;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public DataTable ds;
        int carpan;
        string[] cevap;
        string sifre,soru_sayisi;
        int sure = 0;
        int sayac, sayac2 = 0;
        int dogru_sayisi, toplam_soru, dogru_sayisi2;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool SetForegroundWindow(IntPtr hWnd);

        esqlbaglantisi baglan = new esqlbaglantisi();
        public void KillCtrlAltDelete()
        {
            RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Policies", true);
            rkey1.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
            rkey1.Close();
            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            rkey2.SetValue("DisableTaskMgr", 1);
            rkey2.Close();
        }
        public void kilitle()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            KillCtrlAltDelete();
            timer1.Enabled = true;
        }

        public void kilit_ac()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            ActiveCtrlAltDelete();
            timer1.Enabled = false;
        }
        public void ActiveCtrlAltDelete()
        {
            RegistryKey rkey1 = Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Policies", true);
            rkey1.CreateSubKey("System", RegistryKeyPermissionCheck.Default);
            rkey1.Close();
            RegistryKey rkey2 = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            rkey2.SetValue("DisableTaskMgr", 0);
            rkey2.Close();
        }

        public Form1()
        {
            InitializeComponent();
            setOptionNull();
            
            ds = new DataTable();
            dogru_sayisi = 0;
            sayac2 = 0;
        }

        private void setOptionNull()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from ayarlar", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            dogru_sayisi2 = Convert.ToInt32(row["dogru_sayisi"]);
            carpan = Convert.ToInt32(row["dakika"]);
            sifre = row["sifre"].ToString();
            soru_sayisi = row["soru_sayisi"].ToString();
            cevap = new string[Convert.ToInt32(soru_sayisi + 1)];


            timer2.Enabled = false;
            testPanel.Visible = false;
            panel1.Visible = false;
            kilitle();
            button5.Visible = false;

            SqlCommand ders_getir = new SqlCommand("Select * from Dersler", baglan.baglan());
            SqlDataReader dr_ders = ders_getir.ExecuteReader();
            DataTable dtders = new DataTable();
            dtders.Load(dr_ders);
            comboBox2.DataSource = dtders;
            comboBox2.ValueMember = "DersId";
            comboBox2.DisplayMember = "DersAdi";

            SqlCommand sinif_getir = new SqlCommand("Select * from Sinif", baglan.baglan());
            SqlDataReader dr_sinif = sinif_getir.ExecuteReader();
            DataTable dtsinif = new DataTable();
            dtsinif.Load(dr_sinif);
            comboBox1.DataSource = dtsinif;
            comboBox1.ValueMember = "SinifId";
            comboBox1.DisplayMember = "SinifAdi";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.Rows.Clear();
            sayac = 0;
            sayac2 = 1;
            dogru_sayisi = 0;
            label2.Text = sayac2.ToString();
            girisPanel.Visible = false;
            testPanel.Visible = true;
            button9.Enabled = false;

            try
            {
                getir();
                setOptionNull();
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Bilgilerde Soru yok");
            }
        }

        public void cevapkontrol()
        {
            try
            {
                if (radioButton1.Checked)
                {
                    cevap[sayac + 1] = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    cevap[sayac + 1] = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    cevap[sayac + 1] = radioButton3.Text;
                }
                else if (radioButton4.Checked)
                {
                    cevap[sayac + 1] = radioButton4.Text;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            cevapkontrol();
            sayac++;
            getir();
            setOptionNull();
            sayac2 += 1;
            label2.Text = sayac2.ToString();
        }

        public void getir()
        {
            dogru_sayisi = 0;
            try
            {
                if (ds.Rows.Count == 0)
                {
                    ds = new Connection().GetDb("select top ("+soru_sayisi+") * from Sorular where SinifId='" + comboBox1.SelectedValue + "'and DersId='" + comboBox2.SelectedValue + "' ORDER BY NEWID()");
                    sorubilgi.Text = ds.Rows[sayac]["SoruBilgi"].ToString().Replace("<p>","''");
                    radioButton1.Text = ds.Rows[sayac]["Secenek1"].ToString();
                    radioButton2.Text = ds.Rows[sayac]["Secenek2"].ToString();
                    radioButton3.Text = ds.Rows[sayac]["Secenek3"].ToString();
                    radioButton4.Text = ds.Rows[sayac]["Secenek4"].ToString();
                    
                }
                else
                {
                    sorubilgi.Text = ds.Rows[sayac]["SoruBilgi"].ToString();
                    radioButton1.Text = ds.Rows[sayac]["Secenek1"].ToString();
                    radioButton2.Text = ds.Rows[sayac]["Secenek2"].ToString();
                    radioButton3.Text = ds.Rows[sayac]["Secenek3"].ToString();
                    radioButton4.Text = ds.Rows[sayac]["Secenek4"].ToString();
                    
                }

                if ((sayac + 1) <= 1)
                {
                    button1.Enabled = false;
                    button3.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = true;
                }

                if ((sayac + 1) >= ds.Rows.Count)
                {
                    this.button1.Enabled = true;
                    this.button3.Visible = true;
                    button5.Visible = true;
                    
                }
                else
                {
                    this.button3.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Burda Soru Yok");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac2 -= 1;
            label2.Text = sayac2.ToString();
            sayac--;
            getir();
            setOptionNull();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
        }

        private void testbitir()
        {
            try
            {
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    if (ds.Rows[i]["Cevap"].ToString() == cevap[i + 1])
                    {
                        dogru_sayisi++;
                    }
                }

                if (dogru_sayisi >= dogru_sayisi2)
                {
                    sure = dogru_sayisi * carpan * 60;
                    timer2.Enabled = true;
                    timer2.Start();
                    kilit_ac();
                    this.Hide();
                }
                else
                {
                    toplam_soru = ds.Rows.Count;
                    lblToplamSoru.Text = toplam_soru.ToString();
                    lblDogruCevap.Text = dogru_sayisi.ToString();
                    button1.Enabled = false;
                    button3.Enabled = false;
                    button9.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cevapkontrol();
            panel1.Visible = true;
            girisPanel.Visible = false;
            testPanel.Visible = false;
            testbitir();
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kilitle();
            KillCtrlAltDelete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            kilit_ac();
            ActiveCtrlAltDelete();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = e.CloseReason == CloseReason.UserClosing;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dogru_sayisi = 0;
            toplam_soru = 0;
            ds.Rows.Clear();
            panel1.Visible = false;
            girisPanel.Visible = true;
            cevap = new string[10];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                timer2.Enabled = false;
                timer2.Stop();
                this.Show();
                dogru_sayisi = 0;
                girisPanel.Visible = true;
                panel1.Visible = false;
                kilitle();
            }
            sure--;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == sifre.ToString())
            {
                kilit_ac();
                Application.Exit();
            }
        }
    }
}
