using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        // Entity => Varlık demek
        // Sadece Category tablosuna ait değerleri tutacak.

        // Class --> Table
        // Property --> Column (sütun)

        // Access Modifiers
        // Public => Her yerden erişim sağlanır.
        // Private => Sadece bulunduğu alandan erişim sağlar.
        // Internal => Sadece bulunduğu katmandan erişim sağlar.
        // Protected => Bir sınıf ve o sınıfı miras alan yerlerden erişim sağlar.

        // Code First Yaklaşımı
        // Veritabanının model ve yapılandırmasının doğrudan C# kodu ile tanımlanmasını sağlar

        // Field    => Classın/sınıfın içinde tanımlanan değişkenler
        // Variable => Metod içinde tanımlanırsa değişken..
        // Property => Değişken yapısını sonuna get ve set diye değer alıyorsa property

        // prop tab yaparak yazıyoruz.

        public int CategoryId { get; set; }
        // Code Firs yaklaşımı içinde bunun birinci anahtar olduğunu göstermek için sonuna Id yazılmalı
        public string CategoryName { get; set; }
        // get => almak
        // set => ayarlamak
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
