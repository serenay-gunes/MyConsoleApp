// See https://aka.ms/new-console-template for more information

using System;
 
namespace U2Degiskenler{
class Program {

    static void Main()
    {
        //değişkeni tanımlama ve ilk değer verme
        int plaka = 35;
        String sehir = "İzmir";
        double deger = 125.78;
        
        int a, b= 4, c; // gibi de değişken oluşturulabilir, bu satırda değer atamak zorunda değilsin

        a = 1; //kullanılmayınca tanımlandığı yerde altını sarıyla çiziyor
        c = b; //yapılabilir

        Console.WriteLine(plaka);
        Console.WriteLine(sehir);
        Console.WriteLine(deger);
        Console.WriteLine(a);


       int? ogrenciNot = null;   //NULLABLE olabilmesi için değişken tipinin sonuna soru işareti eklenir

    }


} 

}



//DİKKAT:
// Küçük ı ve büyük İ kullanma, sembol olarak sadece alt tire (_), türkçe karakter kullanma

// C#'ta genelde camelCase kullanılır