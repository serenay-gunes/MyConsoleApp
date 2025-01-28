//Klavyeden girilen 5 sayının en küçüğü ve en büyüğünü ekrana yazdır


int enbuyuk = int.MinValue;
int enkucuk = int.MaxValue;


for(int i = 0; i < 5; i++){

    Console.WriteLine($"{i+1}. sayıyı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if( sayi > enbuyuk ){  //bunun gibi tek satırlık iflerde süslü parantez açılmayabilirmiş
        enbuyuk = sayi;

    }

    if (sayi < enkucuk){

        enkucuk = sayi;
    }

}

     Console.WriteLine($"En büyük sayı: {enbuyuk}");
     Console.WriteLine($"En küçük sayı: {enkucuk}");