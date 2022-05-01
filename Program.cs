// Random, Rasgele demektir.

Random rasgele = new Random();

int sayi = rasgele.Next(1, 100);
Console.Clear();
while (true)
{
    Console.Write("Sayi tahmininizi yapin: ");
    int tahmin = int.Parse(Console.ReadLine());

    if (tahmin < sayi)
    {
        Console.WriteLine("Tahmininiz sayidan kucuk!");
    }
    else if (tahmin > sayi)
    {
        Console.WriteLine("Tahmininiz sayidan buyuk!");
    }
    else if (tahmin == sayi)
    {
        Console.WriteLine("Tebrikler " + sayi + " sayisini buldunuz!");
        break;
    }
}
Console.WriteLine("Program bitti.");
