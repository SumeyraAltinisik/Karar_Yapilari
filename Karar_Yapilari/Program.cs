namespace Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sehir;
            //Console.Write("Şehir Adı: ");
            //sehir = Console.ReadLine();
            //if (sehir == "adana")
            //{
            //    Console.Write("doğru şehir");
            //}
            //else
            //{
            //    Console.Write("yanlış şehir");
            //}

            //int sayi;
            //Console.Write("Sayıyı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //if(sayi == 23)
            //{
            //    Console.Write("sayı doğru girildi.");
            //}
            //else
            //{
            //    Console.Write("sayı yanlış girildi.");
            //}

            //ÖĞRENCİ NOT UYGULAMASI
            //int s1, s2, ort;
            //Console.Write("sınav 1: ");
            //s1 =Convert.ToInt16(Console.ReadLine());
            //Console.Write("sınav 2: ");
            //s2 =Convert.ToInt16(Console.ReadLine());
            //ort = (s1 + s2) / 2;
            //Console.Write("Ortalamanız: " + ort);

            //if (ort >= 50)
            //{
            //    Console.Write("-Geçtiniz");
            //}
            //else
            //{
            //    Console.Write("-Kaldınız");
            //}

            //KULLANICI ADI ŞİFRE UYGULAMASI
            //string kullanici, sifre;
            //Console.Write("Kullanıcı Adınız: ");
            //kullanici = Console.ReadLine();
            //Console.Write("Şifreniz: ");
            //sifre = Console.ReadLine();

            //if(kullanici == "admin" & sifre == "123456")
            //{
            //    Console.Write("Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.Write("hata");
            //}

            //İÇ İÇE IF BLOKLARI
            //int s1, s2, s3, ort;
            //Console.Write("Sınav1: ");
            //s1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //s3 = Convert.ToInt16(Console.ReadLine());
            //ort = (s1 + s2 + s3) / 3;
            //Console.Write("Ortalamanız: " + ort);

            //if (ort <= 49)
            //{
            //    Console.Write(" Durum: Vasat");
            //}
            //if(ort >= 50 & ort <= 65)
            //{
            //    Console.Write(" Durum: Orta");
            //}
            //if(ort>=66 & ort <= 79)
            //{
            //    Console.Write(" Durum: İyi");
            //}
            //if(ort >= 80)
            //{
            //    Console.Write(" Durum: Çok İyi");
            //}

            //EŞİT DEĞİLSE OPERATÖRÜ
            //char karakter;
            //Console.Write("Karakteri giriniz: ");
            //karakter=Convert.ToChar(Console.ReadLine());
            //if (karakter != 'a')
            //{
            //    Console.Write("a harfi girmediniz tebrikler");
            //}
            //else
            //{
            //    Console.Write("a harfi girdiniz maalesef hata");
            //}

            //BİLGİ YARIŞMASI PROJESİ
            //Console.WriteLine("Turkcell Bilgi Yarışmasına Hoşgeldiniz");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine();

            //int soru = 1;
            //string cevap;
            //if(soru == 1)
            //{
            //    Console.WriteLine("Türkiye'nin başkenti neresidir?");
            //    Console.WriteLine();
            //    Console.WriteLine("A) İstanbul");
            //    Console.WriteLine("B) Ankara");
            //    Console.WriteLine("C) İzmir");
            //    Console.WriteLine("D) Bursa");
            //    Console.WriteLine();
            //    Console.Write("Cevabınız: ");
            //    cevap = Console.ReadLine();

            //    if(cevap == "b" || cevap == "B")
            //    {
            //        soru = soru + 1;
            //    }
            //    else
            //    {
            //        Console.Write("Cevap yanlış toplam puanınız: 0");
            //    }
            //}
            //if(soru == 2)
            //{
            //    Console.WriteLine("Cumhuriyet kaç yılında ilan edilmiştir?");
            //    Console.WriteLine();
            //    Console.WriteLine("A) 1920");
            //    Console.WriteLine("B) 1921");
            //    Console.WriteLine("C) 1922");
            //    Console.WriteLine("D) 1923");
            //    Console.WriteLine();
            //    Console.Write("Cevabınız: ");
            //    cevap= Console.ReadLine();
            //    if( cevap == "d" || cevap == "D")
            //    {
            //        soru= soru + 1;
            //    }
            //    else
            //    {
            //        Console.Write("Cevabınız yanlış yarışma bitti toplam puanınız: 1");
            //    }
            //}
            //if (soru == 3)
            //{
            //    Console.WriteLine("Adana hangi coğrafi bölgemizdedir?");
            //    Console.WriteLine();
            //    Console.WriteLine("A) Akdeniz");
            //    Console.WriteLine("B) Marmara");
            //    Console.WriteLine("C) Karadeniz");
            //    Console.WriteLine("D) İç Anadolu");
            //    Console.WriteLine();
            //    Console.Write("Cevabınız: ");
            //    cevap = Console.ReadLine();
            //    if (cevap == "a" || cevap == "A")
            //    {
            //        Console.Write("Tebrikler yarışma biti, bütün soruları doğru bildiniz.");
            //    }
            //    else
            //    {
            //        Console.Write("Cevabınız yanlış yarışma bitti toplam puanınız: 2");
            //    }
            //}


            //SWITCH CASE UYGULAMALARI
            //byte plaka;
            //Console.Write("Lütfen plakayı giriniz:");
            //plaka = byte.Parse(Console.ReadLine());

            //switch (plaka)
            //{
            //    case 1: Console.Write("Merhaba Adana");
            //        break;
            //    case 2: Console.Write("Merhaba Adıyaman");
            //        break;
            //    case 3: Console.Write("Merhaba Afyon");
            //        break;
            //    default:Console.Write("Henüz bu şehir bilgisi girilmedi");
            //        break;
            //}

            //STRING TURUNDE SWITCH CASE UYGULAMALARI
            //Console.WriteLine("String değişkenler ile Switch Case mevsim uygulaması");
            //Console.WriteLine();
            //string mevsim;
            //Console.Write("Lütfen mevsimi giriniz. ");
            //mevsim = Console.ReadLine();
            //switch (mevsim)
            //{
            //    case "yaz":
            //        Console.WriteLine("Haziran - Temmuz - Ağustos");
            //        break;
            //    case "ilkbahar":
            //        Console.WriteLine("Mart - Nisan - Mayıs");
            //        break;
            //    case "sonbahar":
            //        Console.WriteLine("Eylül - Ekim - Kasım");
            //        break;
            //    case "kış":
            //        Console.WriteLine("Aralık - Ocak - Şubat");
            //        break;
            //    default:
            //        Console.WriteLine("hatalı mevsim girişi");
            //        break;
            //}


            Console.Read();

        }
    }
}