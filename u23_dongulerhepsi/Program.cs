// 1den 20ye kadar olan sayıları yazdırmak 2şer


//FOR ile

Console.WriteLine("For döngüsü ile yapıldı.");

for(int i = 0; i < 20; i+=2){

    Console.WriteLine($"{i}");

}

//WHILE ile
Console.WriteLine("While döngüsü ile yapıldı.");

int j =  0;

while(j<20){

        Console.WriteLine(j);  
        j += 2; 

}


//DO WHILE ile
Console.WriteLine("Do While döngüsü ile yapıldı.");
 
 int k = 0;  
  do{       
     Console.WriteLine(k);  
       k += 2;  
} 
while (k < 20);