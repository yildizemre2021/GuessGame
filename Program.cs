// Random, Rasgele demektir.

Random rasgele = new Random();

int sayi = rasgele.Next(1, 100);
int tahmax = 0;

Console.Clear();
while (true)
{
    Console.Write("Sayi tahmininizi yapin: ");
    int tahmin = int.Parse(Console.ReadLine());

    if (tahmin < sayi)
    {
        // tahmax = tahmax + 1;
        tahmax++; // hepsi ayni islevi yapiyor.
        // tahmax += 1;
        Console.WriteLine("Tahmininiz sayidan kucuk!");
    }
    else if (tahmin > sayi)
    {
        tahmax++;
        Console.WriteLine("Tahmininiz sayidan buyuk!");
    }
    else if (tahmin == sayi)
    {
        tahmax++;
        Console.WriteLine("Tebrikler " + sayi + " sayisini " + tahmax + ". tahmininizde " + "buldunuz!");
        break;
    }
}
Console.WriteLine("Program bitti.");
