



Calisan calisan3 = new Calisan("Lina","Ayman",123412412,"IT");

calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    // Kurucu Fonksiyon oluşturarak class çağırılırken değer alması sağlanabilir
    // daha okunaklı kod yazmaya olanak sağlar.

    public Calisan(string ad, string soyad , int no , string departman)
    {
        Ad = ad;
        Soyad = soyad;
        No = no;
        Departman = departman;
    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}",Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}",No);
        Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
    }
}