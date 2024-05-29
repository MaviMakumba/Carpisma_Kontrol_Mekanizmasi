using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayali_Programlama_Odev2
{
    public class Carpisma
    {
        //Nokta && Dikdörtgen Çarpışması
        public static bool NoktaDikdortgen(Nokta nokta,Dikdortgen dikdortgen)
        {
            if (
                nokta.koordinatX>=dikdortgen.nokta.koordinatX+dikdortgen.en &&
                nokta.koordinatX<=dikdortgen.nokta.koordinatX+dikdortgen.en &&
                nokta.koordinatY>=dikdortgen.nokta.koordinatY+dikdortgen.boy &&
                nokta.koordinatY<=dikdortgen.nokta.koordinatY+dikdortgen.boy
                )
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Nokta && Cember Çarpışması
        public static bool NoktaCember(Nokta nokta, Cember cember)
        {
            int merkezX = cember.nokta.koordinatX + cember.yaricap;
            int merkezY=cember.nokta.koordinatY+ cember.yaricap;

            if (Math.Sqrt(nokta.koordinatX-merkezX)*(nokta.koordinatX-merkezX)+(nokta.koordinatX-merkezY)*(nokta.koordinatY-merkezY)==cember.yaricap  )
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Dikdörtgen && Dikdörtgen Çarpışması

        public static bool DikdortgenCarpisma(Dikdortgen d1, Dikdortgen d2)
        {
           
            if (Math.Abs(d1.nokta.koordinatX+d1.en/2)-(d2.nokta.koordinatX+d2.en/2)<d1.en/2+d2.en/2&&
                Math.Abs(d1.nokta.koordinatY+d1.boy)-(d2.nokta.koordinatY+d2.boy/2)<d1.boy+d2.boy)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Çember && Dikdörgen Çarpışması

        public static bool CemberDikdortgenCarpisma(Cember c1, Dikdortgen d1)
        {
            double dx = c1.nokta.koordinatX - Math.Max(d1.nokta.koordinatX, Math.Min(d1.nokta.koordinatX, d1.en));
            double dy = c1.nokta.koordinatY - Math.Max(d1.nokta.koordinatY, Math.Min(d1.nokta.koordinatY, d1.boy));

            if ((dx * dx + dy * dy) <= (c1.yaricap * c1.yaricap))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Çember && Çember Çarpışması

        public static bool CemberCarpisma(Cember c1, Cember c2)
        {
            float d = (float)Math.Sqrt(Math.Pow((c1.nokta.koordinatX - c2.nokta.koordinatX), 2) +
                Math.Pow((c1.nokta.koordinatY - c2.nokta.koordinatY), 2));
            if ((c1.yaricap + c2.yaricap) > d)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        //Nokta && Küre Çarpışması
        public static bool NoktaKureCarpisma(Nokta3D n1, Kure k1)
        {

            if (
                (n1.koordinatX <= k1.nokta.koordinatX + k1.kenar) &&
                (n1.koordinatX <= k1.nokta.koordinatX - k1.kenar) &&
                (n1.koordinatY <= k1.nokta.koordinatY + k1.kenar) &&
                (n1.koordinatY <= k1.nokta.koordinatY - k1.kenar) &&
                (n1.koordinatZ <= k1.nokta.koordinatZ + k1.kenar) &&
                (n1.koordinatZ <= k1.nokta.koordinatZ - k1.kenar)
                )
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        //Nokta && Dikdörtgenler Prizması Çarpışma
        public static bool NoktaPrizmaCarpisma(Nokta3D n1, DikdortgenPrizma p1)
        {
            if (
                (n1.koordinatX <= p1.nokta.koordinatX + p1.en) &&
                (n1.koordinatX <= p1.nokta.koordinatX - p1.en) &&
                (n1.koordinatY <= p1.nokta.koordinatY + p1.boy) &&
                (n1.koordinatY <= p1.nokta.koordinatY - p1.boy) &&
                (n1.koordinatZ <= p1.nokta.koordinatZ + p1.yukseklik) &&
                (n1.koordinatZ <= p1.nokta.koordinatZ - p1.yukseklik)
                )
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Nokta && Silindir Çarpışma
        public static bool NoktaSilindirCarpisma(Nokta3D n1, Silindir s1)
        {
            if (
                (n1.koordinatX <= s1.nokta.koordinatX + s1.yaricap) &&
                (n1.koordinatX <= s1.nokta.koordinatX - s1.yaricap) &&
                (n1.koordinatY <= s1.nokta.koordinatY + s1.yukseklik / 2) &&
                (n1.koordinatY <= s1.nokta.koordinatY - s1.yukseklik / 2) &&
                (n1.koordinatZ <= s1.nokta.koordinatZ + s1.yaricap) &&
                (n1.koordinatZ <= s1.nokta.koordinatZ - s1.yaricap)
                )
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Silindir && Silindir Çarpışması

        public static bool SilindirCarpisma(Silindir s1,Silindir s2) 
        {
        Nokta3D noktaA= new Nokta3D(s1.nokta.koordinatX,s1.nokta.koordinatY+s1.yukseklik/2,s1.nokta.koordinatZ);
        Nokta3D noktaB = new Nokta3D(s2.nokta.koordinatX, s2.nokta.koordinatY + s2.yukseklik / 2, s2.nokta.koordinatZ);
            float d=(float)Math.Sqrt(Math.Pow((noktaA.koordinatX-noktaB.koordinatX),2)+Math.Pow((noktaA.koordinatY-noktaB.koordinatY),2)+
                Math.Pow((noktaA.koordinatZ-noktaB.koordinatZ),2));
            if ((s1.yaricap+s2.yaricap)>(int)d&&Math.Abs(noktaA.koordinatY-noktaB.koordinatY)<((s1.yukseklik+s2.yukseklik)/2))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Küre && Küre Çarpışması

        public static bool KureCarpisma(Kure k1, Kure k2)
        {
            float d = (float)Math.Sqrt(Math.Pow((k1.nokta.koordinatX - k2.nokta.koordinatX), 2) +
                Math.Pow((k1.nokta.koordinatY - k2.nokta.koordinatY), 2) + Math.Pow((k1.nokta.koordinatZ - k2.nokta.koordinatZ), 2));
            if ((k1.kenar + k2.kenar) > (int)d)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Küre && Silindir Çarpışması
        public static bool KureSilindirCarpisma(Kure k1, Silindir s1)
        {
            double uzaklik = (double)Math.Sqrt(Math.Pow(k1.nokta.koordinatX - s1.nokta.koordinatX, 2) + Math.Pow(k1.nokta.koordinatY - s1.nokta.koordinatY, 2));

            if (uzaklik <= s1.yaricap + k1.kenar && k1.nokta.koordinatZ >= s1.nokta.koordinatZ && k1.nokta.koordinatZ <= s1.nokta.koordinatZ + s1.yukseklik)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Küre && Yüzey Çarpışması
        public static bool KureYuzeyCarpisma(Kure k1,Yuzey y1)
        {
            double enyakinX = Math.Max(y1.nokta.koordinatX, Math.Min(y1.nokta.koordinatX, y1.nokta.koordinatX + y1.en));
            double enyakinY=Math.Max(y1.nokta.koordinatY,Math.Min(y1.nokta.koordinatY,y1.nokta.koordinatY+y1.boy));
            double enyakinZ=Math.Max(y1.nokta.koordinatZ,Math.Min(y1.nokta.koordinatZ,y1.nokta.koordinatZ+y1.yukseklik));

            double uzaklik=(double)Math.Sqrt(Math.Pow(k1.nokta.koordinatX-enyakinX,2)+Math.Pow(k1.nokta.koordinatY-enyakinY,2)+Math.Pow(k1.nokta.koordinatZ-enyakinZ,2));

            if (uzaklik<=k1.kenar)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

       

        //Prizma && Yüzey Çarpışması
        public static bool PrizmaYuzeyCarpisma(DikdortgenPrizma p1,Yuzey y1)
        {

            double enyakinX = Math.Max(y1.nokta.koordinatX, Math.Min(p1.nokta.koordinatX, y1.nokta.koordinatX + y1.en));
            double enyakinY = Math.Max(y1.nokta.koordinatY, Math.Min(p1.nokta.koordinatY, y1.nokta.koordinatY + y1.boy));
            double enyakinZ = Math.Max(y1.nokta.koordinatZ, Math.Min(p1.nokta.koordinatZ, y1.nokta.koordinatZ + y1.yukseklik));

            double mesafeX=enyakinX-p1.nokta.koordinatX;
            double mesafeY = enyakinY - p1.nokta.koordinatY;
            double mesafeZ=enyakinZ-p1.nokta.koordinatZ;

            double mesafe = (double)Math.Sqrt(Math.Pow(mesafeX, 2) + Math.Pow(mesafeY, 2) + Math.Pow(mesafeZ, 2));

            if (mesafe<=p1.boy||mesafe<=p1.en||mesafe<p1.yukseklik)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Silindir && Yüzey Çarpışması
        public static bool SilindirYuzeyCarpisma(Silindir s1,Yuzey y1)
        {
            double enyakinX = Math.Max(y1.nokta.koordinatX, Math.Min(s1.nokta.koordinatX, y1.nokta.koordinatX + y1.en));
            double enyakinY = Math.Max(y1.nokta.koordinatY, Math.Min(s1.nokta.koordinatY, y1.nokta.koordinatY + y1.boy));
            double enyakinZ = Math.Max(y1.nokta.koordinatZ, Math.Min(s1.nokta.koordinatZ, y1.nokta.koordinatZ + y1.yukseklik));

            double uzaklik = (double)Math.Sqrt(Math.Pow(s1.nokta.koordinatX - enyakinX, 2) + Math.Pow(s1.nokta.koordinatY - enyakinY, 2));

            if (uzaklik<=s1.yaricap&&enyakinZ<=s1.nokta.koordinatZ+s1.yukseklik&&enyakinZ>=s1.nokta.koordinatZ)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Prizma && Küre Çarpışması
        public static bool PrizmaKureCarpisma(DikdortgenPrizma p1,Kure k1)
        {
            double enyakinX = Math.Max(p1.nokta.koordinatX, Math.Min(k1.nokta.koordinatX, p1.nokta.koordinatX + p1.boy));
            double enyakinY = Math.Max(p1.nokta.koordinatY, Math.Min(k1.nokta.koordinatY, p1.nokta.koordinatY + p1.en));
            double enyakinZ = Math.Max(p1.nokta.koordinatZ, Math.Min(k1.nokta.koordinatZ, p1.nokta.koordinatZ + p1.yukseklik));

            double dx = k1.nokta.koordinatX - enyakinX;
            double dy = k1.nokta.koordinatY - enyakinY;
            double dz = k1.nokta.koordinatZ - enyakinZ;
            double mesafelerinkaresi = dx * dx + dy * dy + dz * dz;

            if (mesafelerinkaresi < (k1.kenar * k1.kenar))
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        //Prizma && Prizma Çarpışması
        public static bool PrizmaCarpisma(DikdortgenPrizma p1,DikdortgenPrizma p2)
        {
            if (
                p1.nokta.koordinatX<=p2.nokta.koordinatX+p2.boy&&
                p1.nokta.koordinatX+p1.boy>=p2.nokta.koordinatX&&
                p1.nokta.koordinatY<=p2.nokta.koordinatY+p2.en&&
                p1.nokta.koordinatY+p1.en>=p2.nokta.koordinatY&&
                p1.nokta.koordinatZ<=p2.nokta.koordinatZ+p2.yukseklik&&
                p1.nokta.koordinatZ+p1.yukseklik>=p2.nokta.koordinatZ
                )
            {
                return true;
            }
            else
            {
                return false;

            }
        }

    }
}
