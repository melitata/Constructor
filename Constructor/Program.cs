using System;
public class Bebek
{
    public static DateTime DogumTarihi;
    public string Ad;
    public string Soyad;
    public Bebek()
    {
        DogumTarihi = DateTime.Now;
        Console.WriteLine("INGAAAA");
    }

    public Bebek(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now;
        Console.WriteLine("INGAAAA");
    }
    public void OzellikleriYazdir()
    {
        Console.WriteLine($"Ad: " + Ad + " Soyad: " + Soyad + "Doğum Trihi: " + DogumTarihi);
    }

} 
class Program
{
    static void Main(string[] args)
    {
        // Default Constructor ile bebek nesnesi oluşturma
        Bebek bebek1 = new Bebek();
        bebek1.OzellikleriYazdir();

        // Ad ve Soyad parametreli Constructor ile bebek nesnesi oluşturma
        Bebek bebek2 = new Bebek("Ali", "Yılmaz");
        bebek2.OzellikleriYazdir();
    }
}