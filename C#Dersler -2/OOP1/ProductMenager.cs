using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductMenager //class isimleri pascal case, BirşeyMenager,BirşeyService isimli classlar gördüğünde anlaki orada operasyon yapılıyor
    {
        //burda 50 tane parametre geçmek yerine kapsülleme yapıyoruz, Product product
        public void Add(Product product)
        {
            product.ProductName = "Kamera";

        }
        public void BirseyYap(int sayi)
        {
            sayi = 13;
        }
    }
}
