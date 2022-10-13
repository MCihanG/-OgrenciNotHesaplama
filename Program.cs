/*
const double kdv = 0.18;
double urunfiyatı, kdvdahilfiyat;
Console.WriteLine("urun fiyatı giriniz");

urunfiyatı = Convert.ToDouble(Console.ReadLine());
kdvdahilfiyat = urunfiyatı * kdv;
double toplamfiyat;
toplamfiyat = urunfiyatı + kdvdahilfiyat;
Console.WriteLine("ürünün kdv dahil fiyatı:" +toplamfiyat);
Console.ReadKey();

/*
Console.WriteLine("*******ÖĞRENCİ NOT HESAPLAMA *******");


Console.WriteLine("*******ÖĞRENCİ KİMLİK BİLGİLERİ ********");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Öğrencinin adını  giriniz");
String  ad = Console.ReadLine();
Console.WriteLine("Öğrencinin soyadını giriniz");
String soyad = Console.ReadLine();
Console.WriteLine("Öğrencinin numarasını giriniz");
int numara =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*******ÖĞRENCİ SINAV BİLGİLERİ ********");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1.sınav");
double sınav1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("2.sınav");
double sınav2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("3.sınav");
double sınav3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("proje notu");
double projenotu = Convert.ToDouble(Console.ReadLine());
double ortalama = (sınav1 + sınav2 + sınav3 + projenotu) / 4;
Console.WriteLine("*******ÖĞRENCİ NOT ORTALAMASI ********");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(ad +" "+ soyad);
Console.WriteLine();
Console.WriteLine("Numaranız:" + numara);
Console.WriteLine();
Console.WriteLine("Ortalamanız:" + ortalama);
string durum = Console.ReadLine();

if (75 <= ortalama && ortalama > 100)
{
   durum = "Çok İyi";
   Console.WriteLine("Çok İyi.");
}
else if (74<= ortalama && ortalama >50)
{
   durum = " İyi";
   Console.WriteLine("İyi.");
}
else if (49<= ortalama && ortalama >25)
{
   durum = "Kötü";
   Console.WriteLine("Kötü");

}
else if (24 <= ortalama && ortalama > 0)
{
   durum = "Zayıf";
   Console.WriteLine("Zayıf");

}
else

    Console.WriteLine("Geçme Durumunuz:" + durum);
Console.ReadKey();

string ad = "Bayram";
string gAd;

Console.Write("Adınızı giriniz:");
gAd =Console.ReadLine();

if (ad == gAd)
{

    Console.WriteLine("Giriş Başarılı.");
    
}
else
{ 
    Console.WriteLine("Hatalı giriş.");

Console.ReadKey();
}

Console.WriteLine("Masanızın hesabını girin");
double hesap = Convert.ToDouble(Console.ReadLine());
double yenihesap;
double indirim;

if (100 > hesap)
{
    Console.WriteLine(hesap);

}
else if (100 < hesap && hesap < 300) 
{
    indirim = hesap * 0.2;
    yenihesap = (hesap - indirim);
    Console.WriteLine(yenihesap); 
}
else
{
    indirim = hesap * 0.3;
    yenihesap = (hesap - indirim);
    Console.WriteLine(yenihesap);

    Console.ReadKey();
/*
 

            



