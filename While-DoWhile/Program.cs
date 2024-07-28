//While Döngüsü:

using System.Collections.Generic;

int Sayac = 0;
int Limit;
Console.WriteLine("Lütfen bir sayı girin: ");
Limit = Convert.ToInt32(Console.ReadLine());

 while (Sayac < Limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            Sayac++;
        } 

 // Dongu kosulu saglamıyorsa calışmaz.

Console.WriteLine("----------------------------------------------------------------------------");

//Do-While Döngüsü:

int SayacDo = 0;
int LimitDo;
Console.WriteLine("Lütfen bir sayı girin: ");
LimitDo = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    SayacDo++;
}
while (SayacDo < LimitDo);

//Aynı kodu Do-While yöntemi ile yapınca koşul sağlanmasa bile döngü bir defalığına da olsa 
// konsol ekranına yazdırılır.



