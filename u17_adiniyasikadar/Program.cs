//Kişinin adını yaşı kadar ekrana getirmek:

Console.WriteLine("Adınızı girin: ");
String ad = Console.ReadLine();


Console.WriteLine("Yaşınızı girin: ");
int yas = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= yas; i++){

    Console.WriteLine($"{i}" + ":" + ad);

}