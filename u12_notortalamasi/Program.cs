
//Girilen 3 notun ortalamasını hesaplayıp öğrencinin başarılı veya başarısız oluşuna göre ekrana çıktı yazdırmak


Console.WriteLine("Birinci notu giriniz: ");
double not1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci notu giriniz: ");
double not2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Üçüncü notu giriniz: ");
double not3 = Convert.ToInt32(Console.ReadLine());

double ort = (not1+not2+not3)/3;
Console.WriteLine(ort);

if(ort>=50){
    Console.WriteLine("Başarılı.");
}
else {
    Console.WriteLine("Başarısız.");
}
