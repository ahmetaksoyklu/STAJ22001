using OOP1;

Console.WriteLine("Hello, World!");

Product product1=new Product();
product1.Id=1;
product1.CategoryId= 2;
product1.ProductName = "Masa";
product1.UnitPrice=12;
product1.UnitsInStock= 14;

Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Kalem", UnitPrice = 10, UnitsInStock = 11 };


//PascalCase  //camelCase
//case sensitive
//stack                         //heap
ProductMenager productMenager=new ProductMenager();
productMenager.Add(product1); //burda product1 in adresini gönderiyoruz yani başka yerde yapılan product1 deki değişiklikler her yerde güncellenir
Console.WriteLine(product1.ProductName);//?????


int sayi = 100;
productMenager.BirseyYap(sayi); //burda 100 değerini gönderiyoruz olay bitiyor
Console.WriteLine(sayi);//?????
//100 