// Klavyeden girilen 5 sayının ortalamasını almak:

using System.Runtime.InteropServices;

int toplam = 0;

for(int i=1; i <= 5; i++)
{
    Console.WriteLine($"{i}. sayıyı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;

}

double ortalama = toplam/5;
Console.WriteLine("Girilen Sayıların Ortalaması: " + ortalama );