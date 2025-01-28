
Console.WriteLine("Dönem ortalamasını girin: ");
int ort = Convert.ToInt32(Console.ReadLine());

string durum = ort switch 
{
    >=85 => "Takdir",
    >=70 => "Teşekkür",
    >=50 => "Teşekkür",
    _ => "Sınıfta kaldı."
    
};

Console.WriteLine(durum);