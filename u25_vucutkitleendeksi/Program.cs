

Console.WriteLine("Kilonuzu girin: ");
double kilo = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Kilonuzu girin: ");
double boy = Convert.ToInt32(Console.ReadLine());


double boyMetre = boy / 100;
double vki = kilo / (boyMetre * boyMetre );

Console.WriteLine($"Vücut kitle endeksiniz: {vki}");


if (vki< 18.5){

         Console.WriteLine("Zayıf");
}
else if(vki >= 18.5 && vki < 25){

         Console.WriteLine("Normal");
}
else if(vki >= 25 && vki < 30){

         Console.WriteLine("Kilolu");
}
else{

         Console.WriteLine("Aşırı kilolu");

}

