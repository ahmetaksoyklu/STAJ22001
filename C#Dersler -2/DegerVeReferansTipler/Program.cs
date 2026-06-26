Console.WriteLine("Hello, World!");


int sayi1= 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? 30


int[] sayilar1 = new int[] { 10, 20, 30, 40 };
int[] sayilar2 = new int[] { 100, 200, 300, 400 };

sayilar1=sayilar2;
sayilar2[0]=900;
//sayilar1?? 900


//int, decimal,float,double,bool(0,1) bunlar değer tip
//array,class,interface bunlar referans tip
//değer tiplerde değeri atıyoruz referans tiplerde adresi atıyorusun
//new dediğimiz anda heapte bir alan, adres oluştur demektir oluşuyor