//kullanıcının belirli sayıda hakkı ile sistemin tahmin ettiği sayıyı bulabilmesi, 
//bulmaya çalışırken tutulan sayı tahminden büyük mü küçük mü yönlendirilmesi
//bilemezse sistemde tutulan sayının yazdırılması

int sayi = new Random().Next(100);
int hak = 5; //5 hak var
//Console.WriteLine("Tutulan Sayi:" + sayi);
Console.WriteLine("0-100 aralığında bir rasgele sayı tuttum.");
do
{
    Console.WriteLine("Tahminin:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    hak--; //hak bir azaldı

    if(hak == 0 && tahmin !=sayi) //hakları bitti ve bilemedi
    {
        Console.WriteLine("Üzgünüm:) Bilemediniz.");
        Console.WriteLine($"Tuttuğum sayı {sayi}");
        break;
    }

    if(tahmin > sayi)
    {
        Console.WriteLine("Daha Küçük");
    }
    else if(tahmin < sayi)
    {
        Console.WriteLine("Daha Büyük");
    }
    else
    {
        Console.WriteLine("TEBRİKLER! BİLDİNİZ...");
        break;//döngüden çıkar
    }

} while(true);

//oyun bittikten sonra tekrar oynamak ister misin diye sorup devam etsin kullanıcıdan onay alıp E derse Evet devam etsin