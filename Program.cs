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
string osvenyMezo = osvenyek[sorszam];
int M = osvenyMezo.Count(x => x == 'M');
int V = osvenyMezo.Count(x => x == 'V');
int E = osvenyMezo.Count(x => x == 'E');

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
for (int i = 0; i < osvenyMezo.Length; i++)
{
    if (osvenyMezo[i] == 'V' || osvenyMezo[i] == 'E')
    {
        kulonlegesKarakterek.Add($"{i}\t{osvenyMezo[i]}");
    }
}
File.WriteAllLines("kulonleges.txt", kulonlegesKarakterek);

//7.feladat
Console.WriteLine("\n7. feladat");
int kor = 0;
int nyertesJatekos = -1;
int legutobbiDobas = 0;
for (int i = 0; i < jatekosokSzama; i++)
{
    jatekosok.Add(0);
}
while (true)
{
    kor++;
    for (int i = 0; i < jatekosokSzama; i++)
    {
        jatekosok[i] += Convert.ToInt32(dobasok[legutobbiDobas]);
        legutobbiDobas++;
        if (jatekosok[i] >= osvenyMezo.Length)
        {
            nyertesJatekos = i;
            break;
        }
    }
    if (nyertesJatekos != -1)
    {
        break;
    }
}
Console.WriteLine($"A játék a(z) {kor}. körben fejeződött be. A legtávolabb jutó(k) sorszáma: {nyertesJatekos + 1}");

//8.feladat
