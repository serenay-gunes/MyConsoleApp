

int[] sayilar = { 10, 20, 30, 40, 50 };

Console.WriteLine("Sayı adedi: " + sayilar.Length);
Console.WriteLine("Dizideki sayılar: ");

for (int i = 0; i < sayilar.Length; i++){

    Console.Write($"{sayilar[i]}, ");
}

// FOR EACH döngüsü:

int toplam = 0;

foreach( int i in sayilar ){ //int olan yere dizinin içindeki veri tipi yazılıyor, ama var da yazılabilir

        toplam += i;

}

Console.WriteLine($"\nDizideki sayıların toplamı: {toplam}");
