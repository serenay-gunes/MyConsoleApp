//klavyeden 0 girilinceye kadar girilen sayıları toplamak:

 int toplam = 0;
 int sayi;

        do
        {
            Console.WriteLine("Bir sayı girin (çıkış için 0): ");
            sayi = Convert.ToInt32(Console.ReadLine());

            toplam += sayi; // girilen sayıyı toplama ekle

        } while (sayi != 0); // kullanıcı 0 girene kadar devam et

        Console.WriteLine($"Girilen sayıların toplamı: {toplam}");