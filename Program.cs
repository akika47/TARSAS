//1.feladat

List<string> dobasok = new List<string>();
List<string> osvenyek = new List<string>();
List<int> jatekosok = new List<int>();
dobasok = File.ReadAllLines("dobasok.txt").ToList();
osvenyek = File.ReadAllLines("osvenyek.txt").ToList();
dobasok = dobasok[0].Split(" ").ToList();

//2.feladat

Console.WriteLine("2. feladat:");
Console.WriteLine($"A dobások száma: {dobasok.Count} \n Az ösvények száma: {osvenyek.Count}");

//3.feladat
Console.WriteLine();
int leghoszabbOsvenyIndex = osvenyek.IndexOf(osvenyek.OrderByDescending(s => s.Length).First()) + 1;
int osvenyHossz = osvenyek.Max(s => s.Length);
Console.WriteLine("3. feladat");
Console.WriteLine($"Az egyik leghosszabb a(z) {leghoszabbOsvenyIndex}. ösvény, hossza: {osvenyHossz}");

//4.feladat
Console.Write("\nAdja meg egy ösvény sorszámát! ");
int sorszam = int.Parse(Console.ReadLine()) - 1;
Console.Write("Adja meg a játékosok számát! ");
int jatekosokSzama = int.Parse(Console.ReadLine());

while (true)
{

    if (sorszam > osvenyek.Count || sorszam < 0)
    {
        Console.WriteLine("Nem megfelelő szám!");
        Console.Write("Adja meg egy ösvény sorszámát! ");
        sorszam = int.Parse(Console.ReadLine()) - 1;
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

//5.feladat
Console.WriteLine("\n5. feladat");
string osvenyVizsgalat = osvenyek[sorszam];
int M = osvenyVizsgalat.Count(x => x == 'M');
int V = osvenyVizsgalat.Count(x => x == 'V');
int E = osvenyVizsgalat.Count(x => x == 'E');

if (M > 0)
{
    Console.WriteLine($"M: {M} darab");
}
if (V > 0)
{
    Console.WriteLine($"V: {V} darab");
}
if (E > 0)
{
    Console.WriteLine($"E: {E} darab");
}

//6.feladat

List<string> kulonlegesKarakterek = new List<string>();
for (int i = 0; i < osvenyVizsgalat.Length; i++)
{
    if (osvenyVizsgalat[i] == 'V' || osvenyVizsgalat[i] == 'E')
    {
        kulonlegesKarakterek.Add($"{i}\t{osvenyVizsgalat[i]}");
    }
}
File.WriteAllLines("kulonleges.txt", kulonlegesKarakterek);

//7.feladat
