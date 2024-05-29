/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA DERSİ
**	
**				ÖDEV NUMARASI…...:2. ÖDEV
**				ÖĞRENCİ ADI...............:EREN KARTAL
**				ÖĞRENCİ NUMARASI.:B231210065
**				DERS GRUBU…………:1. ÖĞRETİM B GRUBU
****************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayali_Programlama_Odev2
{
    public partial class Form1menu : Form
    {
        public Form1menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Çizimi Yapılacam Şekillerin ComboBox'a eklenmesi

            comboBox1Cizim.Items.Add("Nokta");
            comboBox1Cizim.Items.Add("Kare");
            comboBox1Cizim.Items.Add("Dikdörtgen");
            comboBox1Cizim.Items.Add("Dikdörtgen Prizma");
            comboBox1Cizim.Items.Add("Küre");
            comboBox1Cizim.Items.Add("Çember");
            comboBox1Cizim.Items.Add("Silindir");
            comboBox1Cizim.Items.Add("Yüzey");

            //Çarpıştırılacak Şekillerin ComboBox'a eklenmesi

            comboBox2Carpisma.Items.Add("Nokta, Dörtgen çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Nokta, Çember çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Dikdörtgen, Dikdörtgen çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Dikdörtgen, Çember çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Çember, Çember çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Nokta, Küre çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Nokta, Dikdörtgen Prizma çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Nokta, Silindir çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Silindir, Silindir çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Küre, Küre çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Küre, Silindir çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Yüzey, Küre çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Yüzey, Dikdörtgen Prizma çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Yüzey, Silindir çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Küre, Dikdörtgen Prizma çarpışma denetimi");
            comboBox2Carpisma.Items.Add("Dikdörtgen Prizma, Dikdörtgen Prizma çarpışma denetimi");
        }

        private void comboBox1Cizim_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void comboBox2Carpisma_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //Çizme Butonu
        private void button1Ciz_Click(object sender, EventArgs e)
        {
           

            switch (comboBox1Cizim.SelectedIndex)
            {
                //Nokta Çiz
                case 0:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Nokta noktaciz=new Nokta();
                    noktaciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Noktanın Koordinatları (x,y)   :(" + noktaciz.koordinatX + "," + noktaciz.koordinatY + ")");
                    break;

                //Kare Çiz

                case 1:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Dikdortgen dikdortgenciz = new Dikdortgen();
                    dikdortgenciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                       ":(" + dikdortgenciz.nokta.koordinatX + "," + dikdortgenciz.nokta.koordinatY + "," + dikdortgenciz.en + "," + dikdortgenciz.boy + ")");

                    break;

                //Dikdörtgen Çiz

                case 2:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Dikdortgen dikdortgenciz2 = new Dikdortgen();
                    dikdortgenciz2.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                       ":(" + dikdortgenciz2.nokta.koordinatX + "," + dikdortgenciz2.nokta.koordinatY + "," + dikdortgenciz2.en + "," + dikdortgenciz2.boy + ")");

                    break;

                //Dikdörtgen Prizma Çiz

                case 3:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    DikdortgenPrizma prizmaciz = new DikdortgenPrizma();
                    prizmaciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                      " :(" + prizmaciz.nokta.koordinatX + "," + prizmaciz.nokta.koordinatY + "," + prizmaciz.nokta.koordinatZ + "," + prizmaciz.en + "," + prizmaciz.boy + "," + prizmaciz.yukseklik + ")");
                    break;

                //Küre Çiz

                case 4:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Kure kureciz = new Kure();
                    kureciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kureciz.nokta.koordinatX + "," + kureciz.nokta.koordinatY + "," + kureciz.nokta.koordinatZ + "," + kureciz.kenar + ")");
                    break;

                //Çember Çiz

                case 5:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Cember cemberciz= new Cember();
                    cemberciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Çemberin Koordinatları ve Özeliikleri (x,y,yarıçap)   " +
                      ":(" + cemberciz.nokta.koordinatX + "," + cemberciz.nokta.koordinatY + "," + cemberciz.yaricap + "," + ")");
                    break;

                //Silindir Çiz

                case 6:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Silindir silindirciz = new Silindir();
                    silindirciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
                      " :(" + silindirciz.nokta.koordinatX + "," + silindirciz.nokta.koordinatY + silindirciz.nokta.koordinatZ + "," + "," + silindirciz.yaricap + "," + silindirciz.yukseklik + "," + ")");
                    break;

                //Yüzey Çiz

                case 7:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Yuzey yuzeyciz = new Yuzey();
                    yuzeyciz.Ciz(pictureBox1);
                    richTextBox1cisim1.Text = ("Yüzeyin Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                     " :(" + yuzeyciz.nokta.koordinatX + "," + yuzeyciz.nokta.koordinatY + yuzeyciz.nokta.koordinatZ + "," + "," + yuzeyciz.en + "," + yuzeyciz.boy + "," + yuzeyciz.yukseklik + ")");
                    break;

                default:

                    break;
            }
        }

        //Çarpıştırma Butonu
        private void button2Carpistir_Click(object sender, EventArgs e)
        {
          

            switch (comboBox2Carpisma.SelectedIndex)
            {
                //Nokta && Dikdörtgen Çarpışması

                case 0:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Nokta nokta1 = new Nokta();
                    Dikdortgen dikdortgen1 = new Dikdortgen();

                    richTextBox1cisim1.Text=("Noktanın Koordinatları (x,y)   :("+nokta1.koordinatX+ "," +nokta1.koordinatY+")");
                    richTextBox2cisim2.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                        ":(" + dikdortgen1.nokta.koordinatX + "," + dikdortgen1.nokta.koordinatY +","+dikdortgen1.en+","+dikdortgen1.boy+ ")");
                    
                    nokta1.Ciz(pictureBox1);
                    dikdortgen1.Ciz(pictureBox1);

                    if (Carpisma.NoktaDikdortgen(nokta1,dikdortgen1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor=Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Nokta && Cember Çarpışması

                case 1:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Nokta nokta2 = new Nokta();
                    Cember cember1 = new Cember();

                    richTextBox1cisim1.Text = ("Noktanın Koordinatları (x,y)   :(" + nokta2.koordinatX + "," + nokta2.koordinatY + ")");
                    richTextBox2cisim2.Text = ("Çemberin Koordinatları ve Özeliikleri (x,y,yarıçap)   " +
                        ":(" + cember1.nokta.koordinatX + "," + cember1.nokta.koordinatY + "," + cember1.yaricap + "," +  ")");

                    nokta2.Ciz(pictureBox1);
                    cember1.Ciz(pictureBox1);

                    if (Carpisma.NoktaCember(nokta2, cember1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Dikdörtgen && Dikdörtgen Çarpışması

                case 2:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Dikdortgen dikdortgen2= new Dikdortgen();
                    Dikdortgen dikdortgen3= new Dikdortgen();

                    richTextBox1cisim1.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                       ":(" + dikdortgen2.nokta.koordinatX + "," + dikdortgen2.nokta.koordinatY + "," + dikdortgen2.en + "," + dikdortgen2.boy + ")");
                    richTextBox2cisim2.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                       ":(" + dikdortgen3.nokta.koordinatX + "," + dikdortgen3.nokta.koordinatY + "," + dikdortgen3.en + "," + dikdortgen3.boy + ")");

                    dikdortgen2.Ciz(pictureBox1);
                    dikdortgen3.Ciz(pictureBox1);

                    if (Carpisma.DikdortgenCarpisma(dikdortgen2, dikdortgen3))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Çember && Dikdörgen Çarpışması

                case 3:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Dikdortgen dikdortgen4 = new Dikdortgen();
                    Cember cember2 = new Cember();

                    richTextBox1cisim1.Text = ("Dikdörgenin Koordinatları ve Özeliikleri (x,y,en,boy)   " +
                       ":(" + dikdortgen4.nokta.koordinatX + "," + dikdortgen4.nokta.koordinatY + "," + dikdortgen4.en + "," + dikdortgen4.boy + ")");
                    richTextBox2cisim2.Text = ("Çemberin Koordinatları ve Özeliikleri (x,y,yarıçap)   " +
                        ":(" + cember2.nokta.koordinatX + "," + cember2.nokta.koordinatY + "," + cember2.yaricap + "," + ")");

                    dikdortgen4.Ciz(pictureBox1);
                    cember2.Ciz(pictureBox1);

                    if (Carpisma.CemberDikdortgenCarpisma(cember2, dikdortgen4))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Çember && Çember Çarpışması

                case 4:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Cember cember3 = new Cember();
                    Cember cember4 = new Cember();

                    richTextBox1cisim1.Text = ("Çemberin Koordinatları ve Özeliikleri (x,y,yarıçap)   " +
                        ":(" + cember3.nokta.koordinatX + "," + cember3.nokta.koordinatY + "," + cember3.yaricap + "," + ")");
                    richTextBox2cisim2.Text = ("Çemberin Koordinatları ve Özeliikleri (x,y,yarıçap)   " +
                        ":(" + cember4.nokta.koordinatX + "," + cember4.nokta.koordinatY + "," + cember4.yaricap + "," + ")");

                    cember3.Ciz(pictureBox1);
                    cember4.Ciz(pictureBox1);

                    if (Carpisma.CemberCarpisma(cember3, cember4))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                  
                    break;

                //Nokta && Küre Çarpışması

                case 5:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Nokta3D nokta3 = new Nokta3D();
                    Kure kure1 = new Kure();

                    richTextBox1cisim1.Text = ("Noktanın Koordinatları (x,y)   :(" + nokta3.koordinatX + "," + nokta3.koordinatY + ")");
                    richTextBox2cisim2.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kure1.nokta.koordinatX + "," + kure1.nokta.koordinatY +","+ kure1.nokta.koordinatZ + "," + kure1.kenar+ ")");
                    
                    nokta3.Ciz(pictureBox1);
                    kure1.Ciz(pictureBox1);

                    if (Carpisma.NoktaKureCarpisma(nokta3, kure1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Nokta && Dikdörtgenler Prizması Çarpışma

                case 6:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Nokta3D nokta4 = new Nokta3D();
                    DikdortgenPrizma prizma1 = new DikdortgenPrizma();

                    richTextBox1cisim1.Text = ("Noktanın Koordinatları (x,y)   :(" + nokta4.koordinatX + "," + nokta4.koordinatY + ")");
                    richTextBox2cisim2.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                        " :(" + prizma1.nokta.koordinatX + "," + prizma1.nokta.koordinatY + "," + prizma1.nokta.koordinatZ + "," + prizma1.en +","+prizma1.boy+","+prizma1.yukseklik+ ")");

                    nokta4.Ciz(pictureBox1);
                    prizma1.Ciz(pictureBox1);

                    if (Carpisma.NoktaPrizmaCarpisma(nokta4, prizma1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Nokta && Silindir Çarpışma

                case 7:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Nokta3D nokta5 = new Nokta3D();
                    Silindir silindir1 = new Silindir();

                    richTextBox1cisim1.Text = ("Noktanın Koordinatları (x,y)   :(" + nokta5.koordinatX + "," + nokta5.koordinatY + ")");
                    richTextBox2cisim2.Text= ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
                        " :(" + silindir1.nokta.koordinatX + "," + silindir1.nokta.koordinatY + silindir1.nokta.koordinatZ + "," + "," + silindir1.yaricap + "," + silindir1.yukseklik + ","  + ")");

                    nokta5.Ciz(pictureBox1);
                    silindir1.Ciz(pictureBox1);

                    if (Carpisma.NoktaSilindirCarpisma(nokta5, silindir1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Silindir && Silindir Çarpışması

                case 8:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Silindir silindir2 = new Silindir();
                    Silindir silindir3 = new Silindir();

                    richTextBox1cisim1.Text = ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
                      " :(" + silindir2.nokta.koordinatX + "," + silindir2.nokta.koordinatY + silindir2.nokta.koordinatZ + "," + "," + silindir2.yaricap + "," + silindir2.yukseklik + "," + ")");
                    richTextBox2cisim2.Text = ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
                   " :(" + silindir3.nokta.koordinatX + "," + silindir3.nokta.koordinatY + silindir2.nokta.koordinatZ + "," + "," + silindir3.yaricap + "," + silindir3.yukseklik + "," + ")");

                    silindir2.Ciz(pictureBox1);
                    silindir3.Ciz(pictureBox1);

                    if (Carpisma.SilindirCarpisma(silindir2, silindir3))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }

                    break;

                //Küre && Küre Çarpışması

                case 9:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Kure kure2 = new Kure();
                    Kure kure3 = new Kure();

                    richTextBox1cisim1.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kure2.nokta.koordinatX + "," + kure2.nokta.koordinatY + kure2.nokta.koordinatZ + "," + "," + kure2.kenar + ")");
                    richTextBox2cisim2.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kure3.nokta.koordinatX + "," + kure3.nokta.koordinatY + kure3.nokta.koordinatZ + "," + "," + kure3.kenar + ")");

                    kure2.Ciz(pictureBox1);
                    kure3.Ciz(pictureBox1);

                    if (Carpisma.KureCarpisma(kure2, kure3))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Küre && Silindir Çarpışması

                case 10:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Kure kure4 = new Kure();
                    Silindir silindir4 = new Silindir();

                    richTextBox1cisim1.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kure4.nokta.koordinatX + "," + kure4.nokta.koordinatY + "," +kure4.nokta.koordinatZ+","+ kure4.kenar + ")");
                    richTextBox2cisim2.Text = ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
                " :(" + silindir4.nokta.koordinatX + "," + silindir4.nokta.koordinatY + silindir4.nokta.koordinatZ + "," + "," + silindir4.yaricap + "," + silindir4.yukseklik + "," + ")");

                    kure4.Ciz(pictureBox1);
                    silindir4.Ciz(pictureBox1);

                    if (Carpisma.KureSilindirCarpisma(kure4, silindir4))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Küre && Yüzey Çarpışması

                case 11:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Kure kure5 = new Kure();
                    Yuzey yuzey1 = new Yuzey();

                    richTextBox1cisim1.Text = ("Kürenin Koordinatları ve Özellikleri (x,y,z,kenar)   :(" + kure5.nokta.koordinatX + "," + kure5.nokta.koordinatY + "," + kure5.kenar + ")");
                    richTextBox2cisim2.Text = ("Yüzeyin Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                       " :(" + yuzey1.nokta.koordinatX + "," + yuzey1.nokta.koordinatY + yuzey1.nokta.koordinatZ + "," + "," + yuzey1.en + "," + yuzey1.boy + "," + yuzey1.yukseklik + ")");

                    kure5.Ciz(pictureBox1);
                    yuzey1.Ciz(pictureBox1);

                    if (Carpisma.KureYuzeyCarpisma(kure5, yuzey1))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Prizma && Yüzey Çarpışması

                case 12:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    DikdortgenPrizma prizma2 = new DikdortgenPrizma();
                    Yuzey yuzey2 = new Yuzey();

                    richTextBox1cisim1.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
    " :(" + prizma2.nokta.koordinatX + "," + prizma2.nokta.koordinatY + "," + prizma2.nokta.koordinatZ + "," + prizma2.en + "," + prizma2.boy + "," + prizma2.yukseklik + ")");
                    richTextBox2cisim2.Text = ("Yüzeyin Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                      " :(" + yuzey2.nokta.koordinatX + "," + yuzey2.nokta.koordinatY + yuzey2.nokta.koordinatZ + "," + "," + yuzey2.en + "," + yuzey2.boy + "," + yuzey2.yukseklik + ")");

                    prizma2.Ciz(pictureBox1);
                    yuzey2.Ciz(pictureBox1);

                    if (Carpisma.PrizmaYuzeyCarpisma(prizma2, yuzey2))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Silindir && Yüzey Çarpışması

                case 13:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    Silindir silindir5=new Silindir();
                    Yuzey yuzey3=new Yuzey();

                    richTextBox1cisim1.Text = ("Silindirin Koordinatları ve Özellikleri (x,y,z,yarıçap,yükseklik)  " +
               " :(" + silindir5.nokta.koordinatX + "," + silindir5.nokta.koordinatY + silindir5.nokta.koordinatZ + "," + "," + silindir5.yaricap + "," + silindir5.yukseklik + "," + ")");
                    richTextBox2cisim2.Text = ("Yüzeyin Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                      " :(" + yuzey3.nokta.koordinatX + "," + yuzey3.nokta.koordinatY + yuzey3.nokta.koordinatZ + "," + "," + yuzey3.en + "," + yuzey3.boy + "," + yuzey3.yukseklik + ")");
                    
                    silindir5.Ciz( pictureBox1);
                    yuzey3.Ciz(pictureBox1);

                    if (Carpisma.SilindirYuzeyCarpisma(silindir5, yuzey3))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Prizma && Küre Çarpışması

                case 14:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    DikdortgenPrizma prizma3 = new DikdortgenPrizma();
                    Yuzey yuzey4= new Yuzey();

                    richTextBox1cisim1.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                    " :(" + prizma3.nokta.koordinatX + "," + prizma3.nokta.koordinatY + "," + prizma3.nokta.koordinatZ + "," + prizma3.en + "," + prizma3.boy + "," + prizma3.yukseklik + ")");
                    richTextBox2cisim2.Text = ("Yüzeyin Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                   " :(" + yuzey4.nokta.koordinatX + "," + yuzey4.nokta.koordinatY + yuzey4.nokta.koordinatZ + "," + "," + yuzey4.en + "," + yuzey4.boy + "," + yuzey4.yukseklik + ")");

                    prizma3.Ciz(pictureBox1);
                    yuzey4.Ciz(pictureBox1);

                    if (Carpisma.PrizmaYuzeyCarpisma(prizma3, yuzey4))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                //Prizma && Prizma Çarpışması

                case 15:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();

                    DikdortgenPrizma prizma4 = new DikdortgenPrizma();
                    DikdortgenPrizma prizma5 = new DikdortgenPrizma();

                    richTextBox1cisim1.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                   " :(" + prizma4.nokta.koordinatX + "," + prizma4.nokta.koordinatY + "," + prizma4.nokta.koordinatZ + "," + prizma4.en + "," + prizma4.boy + "," + prizma4.yukseklik + ")");
                    richTextBox1cisim1.Text = ("Prizmanın Koordinatları ve Özellikleri (x,y,z,en,boy,yükseklik)  " +
                   " :(" + prizma5.nokta.koordinatX + "," + prizma5.nokta.koordinatY + "," + prizma5.nokta.koordinatZ + "," + prizma5.en + "," + prizma5.boy + "," + prizma5.yukseklik + ")");

                    prizma4.Ciz(pictureBox1);
                    prizma5.Ciz(pictureBox1);

                    if (Carpisma.PrizmaCarpisma(prizma4, prizma5))
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarılı";
                        richTextBox3sonuc.BackColor = Color.Green;
                    }
                    else
                    {
                        richTextBox3sonuc.Text = "Çarpışma Başarısız";
                        richTextBox3sonuc.BackColor = Color.Red;
                    }
                    break;

                default:
                    
                    break;

            }
        }
        private void label1Cizim_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

