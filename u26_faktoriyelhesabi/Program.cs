// klavyeden girilen sayının faktöriyelini hesaplamak:

// 5.4.3.2.1 = 5! (ornek)
// özel durum: 0! = 1
// negatif sayıların faktöriyeli yok

//Console.WriteLine("");


Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if(sayi>= 0){

      int sonuc = 1;

      //faktöriyel hesaplanabilir
      for (int i = sayi; i >= 1; i--){

        //sonuc = sonuc * (ulong)i; //sonucun üzerine çarparak ekleyelim (?)
        sonuc *= i;

      }

      Console.WriteLine($"{sayi}! = {sonuc}"); 


}
else{
       //faktöriyel hesaplanamaz
       Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");

}