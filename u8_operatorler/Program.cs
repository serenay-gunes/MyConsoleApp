// See https://aka.ms/new-console-template for more information

int a = 2, b = 3, c = 6;
Console.WriteLine($"a = {a}, b = {b}, c = {c}");

a += 3; //a'nın üzerine 3 ekle
b--; //b'nin değerini 1 azalt
c =  a++ + b; // a'nın değeri ile b'yi topla, sonucu c'ye aktar, daha sonra a'nın değerini bir arttır (?)

Console.WriteLine($"a = {a}, b = {b}, c = {c}");
