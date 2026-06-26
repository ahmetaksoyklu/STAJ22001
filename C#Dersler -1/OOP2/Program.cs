using OOP2;

Console.WriteLine("Hello, World!");


//Musteri musteri1=new Musteri();

//musteri1.Adi = "ahmet";
//musteri1.Soyadi = "aksoy";
//musteri1.Id = 1;
//musteri1.TcNo = "22222222";
//musteri1.MusteriNo = "sdfsf";
//musteri1.SirketAdi = "??????";// Sırf birbirine benziyor diye birbirinin yerine kullanma SOLİD' in l si
//müşteritipi=1 ise şunu yap 2 ise şunu yap yine yanlış , bu alanlara ilerde yanlış değerler girilebilir yanki tüzel müşteri gibi gözüken gerçek  müşteri

GercekMusteri gercekMusteri=new GercekMusteri();
gercekMusteri.Id = 1;
gercekMusteri.Adi = "ahmet";
gercekMusteri.Soyadi = "aksoy";
gercekMusteri.TcNo = "23232323";
gercekMusteri.MusteriNo = "2332323";

TuzelMusteri tuzelMusteri = new TuzelMusteri();
tuzelMusteri.Id = 2;
tuzelMusteri.MusteriNo = "3232323";
tuzelMusteri.SirketAdi = "klu";

//görüldüğü gibi gereksiz alan yok, hata yapma olasılığını düşürüyoruz

//Musteri sınıfı base sınıfı özelliğinin yanında yani onda ne varsa çocuklarındada o olur mantığının yyanında miras verdiği sınıfın referans değerini tutabilir.
Musteri musteri1 = new GercekMusteri();
Musteri musteri2 = new TuzelMusteri();

MusteriMenager musteriMenager=new MusteriMenager();
musteriMenager.Ekle(musteri1);
musteriMenager.Ekle(musteri2);
musteriMenager.Ekle(gercekMusteri);
musteriMenager.Ekle(tuzelMusteri);

//kısacası bir base sınıfımız varsa o referans tutucudur.