Console.WriteLine("Hello, World!");
string[] isimler = new string[] { "ahmet", "mehmet", "ali" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
//isimler[3] = "fatma";    hata verir böyle bir tanımlama yok dizilerde, dizilerde oluşturduğumuz sınırlar geçerli
//Console.WriteLine(isimler[3]);

isimler = new string[5];
isimler[4] = "ilker";
Console.WriteLine(isimler[4]);
Console.WriteLine(isimler[0]);//bu boş gelir,4 e ilkeri atadık ama diğerleri boşta kaldı yukarda yaptıklarımız geçerli olmuyor new lediğimiz anda yeni referans noktasına oluşur

List<string> isimler2 = new List<string>();
isimler2.Add("engin");
isimler2.Add("mehmet");

List<string> isimler3 = new List<string> { "mehmet", "ayşe", "fatma" };
Console.WriteLine(isimler3[0]);
Console.WriteLine(isimler3[1]);
Console.WriteLine(isimler3[2]);
isimler3.Add("hayriye");
Console.WriteLine(isimler3[3]);
