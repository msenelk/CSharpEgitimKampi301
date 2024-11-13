using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders{ get; set; }

        // SOLID

        // Single Responsibility => Tek sorumluluk ilkesi
        // Bir method sadece bir işi yapar.

        // Open/Closed Principle (OCP) => Genişlemeye açık ancak değişikliğe kapalı olmak

        // Liskov Substitution Principle (LSP) => Türetilmiş sınıflar, temel sınıflarının yerine kullanılabilir olmalıdır. Yani, bir alt sınıf, üst sınıfın yerine geçtiğinde davranışı bozmamalıdır.

        // Interface Segregation Principle (ISP) => Bir sınıf, kullanmadığı yöntemleri içeren bir arayüze bağlı olmamalıdır. Arayüzler olabildiğince spesifik olmalı ve gereksiz metotlar içermemelidir.

        // Dependency Inversion Principle (DIP) => Yüksek seviyeli modüller (iş mantığı) düşük seviyeli modüllere (veri erişim katmanı gibi) bağımlı olmamalıdır. Her ikisi de soyutlamalara (arayüzler veya soyut sınıflar) bağımlı olmalıdır.

        //SOLID Prensiplerinin Faydaları
        //Bakım Kolaylığı: Kod daha modüler olduğu için daha kolay anlaşılır ve değiştirilebilir.
        //Genişletilebilirlik: Yeni özellikler eklemek, mevcut kodu değiştirmeden mümkün hale gelir.
        //Test Edilebilirlik: Kodun test edilmesi daha kolaydır, çünkü her modül belirli bir sorumluluğa sahiptir.
        //Esneklik: Kod, değişikliklere ve büyümeye karşı daha dayanıklı hale gelir.

    }
}
