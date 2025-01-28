//Mantıksal Operatörlerin Kullanımını Örneklemek İçin


Console.WriteLine("Yaşınızı giriniz:");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Cinsiyetinizi giriniz:");
char cinsiyet = Convert.ToChar(Console.ReadLine());


if(cinsiyet == 'E' || yas >= 30){

    Console.WriteLine("Askere gidebilir.");
}
else{

    Console.WriteLine("Askere gidemez.");

}
