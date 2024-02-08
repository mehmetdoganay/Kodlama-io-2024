using Business.Concrate;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Mehmet";
person1.LastName = "Doğanay";
person1.DateOfBrirthYear = 1999;
person1.NationalIdentity = 14556498579;

Person person2 = new Person();
person2.FirstName = "Ahmet";
person2.LastName = "Jr";
person2.DateOfBrirthYear = 1992;
person2.NationalIdentity = 12345679;

Person person3 = new Person();
person3.FirstName = "Samet";
person3.LastName = "Jr";
person3.DateOfBrirthYear = 1999;
person3.NationalIdentity = 4567987;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
pttManager.GiveMask(person2);
pttManager.GiveMask(person3);


// Diziler / Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Ahmet";
string ogrenci3 = "Mehmet";

string[] ogrenciler = new string[3];

ogrenciler[0] = "Engin";
ogrenciler[1] = "ahmet";
ogrenciler[2] = "mehmet";

ogrenciler = new string[4];
ogrenciler[3] = "asdas";

List<string> yeniOgrenciler = new List<string>{"Ahmet","murat","Rick"};
yeniOgrenciler.Add("Morty");

foreach (var ogrenci in yeniOgrenciler)
{
    Console.WriteLine(ogrenci);
}


for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}




Vatandas vatandas = new Vatandas();

static void SelamVer()
{
    Console.WriteLine("Merhaba");
}

public class Vatandas
{
    public String Ad { get; set; }
    public String Soyad { get; set; }
    public int  Dogumyili { get; set; }
    public long TcNo { get; set; }
}





