// See https://aka.ms/new-console-template for more information


int a = 5, b =3;
int sonuc = a * b;

Console.WriteLine( a + " * " + b + " = " + sonuc); // ilkel yöntem

Console.WriteLine(string.Format("{0} * {1} = {2}",a,b,sonuc)); 

Console.WriteLine("{0} * {1} = {2}",a,b,sonuc); // üstekinin kısası

Console.WriteLine($"{a} * {b} = {sonuc}"); // "string interpolation" -önüne dolar işareti koyuluyor