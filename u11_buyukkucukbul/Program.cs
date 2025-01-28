

Console.WriteLine("Birinci sayıyı girin:");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı girin:");
int s2 = Convert.ToInt32(Console.ReadLine());

if(s1>s2){

    Console.WriteLine($"{s1} büyük olan sayı, {s2} küçük olan sayı. ");

}
else if(s1==s2){

    Console.WriteLine("Sayılar eşit.");
}
else{

    Console.WriteLine($"{s2} büyük olan sayı, {s1} küçük olan sayı. ");

}


