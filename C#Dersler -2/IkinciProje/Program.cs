using IkinciProje;

Console.WriteLine("Hello, World!");
Urun urun1=new Urun();
urun1.Adi = "Elma";
urun1.Aciklama = "Amasaya Elması";
urun1.Fiyat=12;

Urun urun2=new Urun();
urun2.Adi = "Armut";
urun2.Aciklama = "kayseri";
urun2.Fiyat= 23;

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (var urun  in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.Fiyat);
}

SeperMenager sepetMenager=new SeperMenager();
sepetMenager.Ekle(urun1);
sepetMenager.Ekle(urun2);


sepetMenager.Ekle2("karpuz","sdfdf",14);
sepetMenager.Ekle2("erik","diyarbakır",12);
sepetMenager.Ekle2("çilek","sc",13);

//Ekle2 metoduna yeni bir alan eklediğimizde public void Ekle2(string uruAdi, string aciklama, int fiyati, int stokAdedi)
//yukarda çağırdımız ekle2 metodları patlar o yüzden string uruAdi, string aciklama, int fiyati, int stokAdedi bunları bir
//clasa koyup birleştiriyoruz buna encapsulation denir

