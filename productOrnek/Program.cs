// See https://aka.ms/new-console-template for more information

using System.Text;

Product urun1 = new Product();

    urun1.productName = "Masaüstü Bilgisayar";
    urun1.productCategory = "Elektronik";
    urun1.productPrice = 23000;
    urun1.productProperty = "I5 CPU 8G RAM 120GB 256GB 512GB SSD";

Product urun2 = new Product();
    urun2.productName = "Alet Çantası";
    urun2.productCategory = "Aletler ve Donanım";
    urun2.productPrice = 1300;
    urun2.productProperty = "Electrical Maintenance Tools Kit Cheap Tool Boxes";

Product urun3 = new Product();
    urun3.productName = "Kid'scooter";
    urun3.productCategory = "Spor ve Eğlence";
    urun3.productPrice = 3520;
    urun3.productProperty = "Katlanabilir ve hafif yayan çocuk scooter itme scooter";


Product[] urunler = new Product[] { urun1, urun2, urun3 };
Console.WriteLine("~~~FOREACH DÖNGÜSÜ İLE~~");
    foreach (var urun in urunler)
    {
       Console.WriteLine(urun.productName+ " - "+ urun.productCategory+" - "+urun.productPrice+" - "+urun.productProperty);
    };
Console.WriteLine("~~~FOR DÖNGÜSÜ İLE`~~~");
    for (int i = 0; i < urunler.Length; i++)
    {
        Console.WriteLine(urunler[i].productName + " - " + urunler[i].productCategory + " - " + urunler[i].productPrice + " - " + urunler[i].productProperty);
    }
Console.WriteLine("~~~WHİLE DÖNGÜSÜ İLE~~~");

   int x = 0;
   while (x<urunler.Length)
    {
        Console.WriteLine(urunler[x].productName + " - " + urunler[x].productCategory + " - " + urunler[x].productPrice + " - " + urunler[x].productProperty);

    x++;
    }
class Product
{
    public string productName { get; set; }
    public string productCategory { get; set; }
    public int productPrice { get; set; }
    public string productProperty { get; set; }

}
