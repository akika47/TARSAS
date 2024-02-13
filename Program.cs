//1.feladat

List<string> dobasok = new List<string>();
List<string> osvenyek = new List<string>();
dobasok = File.ReadAllLines("dobasok.txt").ToList();
osvenyek = File.ReadAllLines("osvenyek.txt").ToList();
dobasok = dobasok[0].Split(" ").ToList();

//2.feladat

Console.WriteLine("2. feladat:");
Console.WriteLine($"A dobások száma: {dobasok.Count} \n Az ösvények száma: {osvenyek.Count}");

//3.feladat
Console.WriteLine();
int leghoszabbOsvenyIndex = 0;
int osvenyHossz = osvenyek[0].Length;
for (int i = 1; i < osvenyek.Count; i++)
{
    if (osvenyek[leghoszabbOsvenyIndex].Length < osvenyek[i].Length)
    {
        leghoszabbOsvenyIndex = i;
    }
}
osvenyHossz = osvenyek[leghoszabbOsvenyIndex].Length;
Console.WriteLine("3. feladat");
Console.WriteLine($"Az egyik leghosszabb a(z) {leghoszabbOsvenyIndex+1}. ösvény, hossza:{osvenyHossz}");

//4.feladat
Console.WriteLine();
Console.Write("Adja meg egy ösvény sorszámát! ");
int sorszam = int.Parse(Console.ReadLine())-1;
Console.Write("Adja meg a játékosok számát! ");
int jatekosokSzama = int.Parse(Console.ReadLine());

while (true)
{

    if (sorszam > osvenyek.Count || sorszam < 0)
    {
        Console.WriteLine("Nem megfelelő szám!");
        Console.Write("Adja meg egy ösvény sorszámát! ");
        sorszam = int.Parse(Console.ReadLine())-1;
    }
    if (sorszam <= osvenyek.Count && sorszam >= 0)
    {
        break;
    }

}



while (true)
{
    if (jatekosokSzama < 2 || jatekosokSzama > 5)
    {
        Console.Write("Adja meg a játékosok számát! ");
        Console.WriteLine("Nem megfelelő szám!");
        jatekosokSzama = int.Parse(Console.ReadLine());
    }
    if (jatekosokSzama >= 2 && jatekosokSzama <= 5)
    {
        break;
    }
}
