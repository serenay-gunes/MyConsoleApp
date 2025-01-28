// See https://aka.ms/new-console-template for more information


Console.Write("Dörtgenin a kenarını gir: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Dörtgenin b kenarını gir: ");
int b = Convert.ToInt32(Console.ReadLine());

// değişken tipi yazmak yerine "var" kelimesi kullanılabiliyor -sağdaki ifadenin değişken tipini alıyor

var alan = a * b;
var cevre = (a+b) * 2; //işlem önceliği için parantez gerekli

Console.WriteLine($"Kenarları {a} ve {b} olan \n bir dörtgenin alanı {alan}' eder.");    // ters slash + n ile alt satıra geçilir
Console.WriteLine($"Kenarları {a} ve {a} olan bir dörtgenin çevresi {cevre}' eder.");



// dotnet new console --output u7_smt
// dotnet sln MyConsoleApp.sln add u7_smt/u7_smt.csproj
// dotnet run --project u6_dortgenolusturma

//burada diğer escape (kaçış) karakterlerinden bahsedildi


