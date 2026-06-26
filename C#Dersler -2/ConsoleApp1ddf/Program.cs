Console.WriteLine("Hello, World!");
//int ogrenciSayisi=12;
//Console.WriteLine("");
//string kategoriEtikei = "Kategoriler";
//if (Equals())
//{
    
//}

//if (kategoriEtikei=1)
//{
//    Console.WriteLine();
//    Console.WriteLine(sdfksdf);

//}

//if (kategoriEtikei=="gel")
//{
    
//}
//else
//{
//    Console.WriteLine("gelme");
//}
//double dolarBugun=7.15;
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

////for (int i = 0; i < 15; i++ i+=2, i=i+2)
////{

////}
//string kurs1 = "Yazılım geliştirici kursu";
//string kurs2 = "java";
//string kurs3 = "C#";
//string kurs4 = "python";


//Console.WriteLine(kurs1);
//Console.WriteLine(kurs2);
//Console.WriteLine(kurs3);
//Console.WriteLine(kurs4);

//string[] kurslar = new string[]
//{ "yazılım geliştiri",
//    "c#",
//    "java", 
//    "python"
//};


//for (int i = 0; i < kurslar.Length; i++)
//{
//    Console.WriteLine(kurslar[i]);
//}

//foreach (var kurs in kurslar)
//{
    
//}

Kurs kurs5 = new Kurs();
kurs5.KursAdi = "c#";
kurs5.Eğitmen = "ahmet";
kurs5.IzlenmeOranı = 23;
kurs5.deneme = new string[] { "sdfsdf", "sdfsdfsdf" };

Kurs kurs6 = new Kurs();
kurs6.KursAdi = "sdcjava";
kurs6.Eğitmen = "sdcscd";
kurs6.IzlenmeOranı = 12;
kurs6.deneme = new string[] { "ccccc", "sssss" };
Kurs[] kurslarclass = new Kurs[] { kurs6, kurs5 };



foreach (var kurs in kurslarclass)

{
    Console.WriteLine(kurs.Eğitmen);
    Console.WriteLine(kurs.deneme[0]);
}
class Kurs
{
    public string Eğitmen { get; set; }
    public string KursAdi { get; set; }
    public int IzlenmeOranı { get; set; }
    public string[] deneme { get; set; }


}





