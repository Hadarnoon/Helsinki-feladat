using Helsinki;

var adatok = new List<Adat>();
using var sr = new StreamReader(@"..\..\..\src\helsinki.txt");
while (!sr.EndOfStream) adatok.Add(new Adat(sr.ReadLine()));
Console.WriteLine("3.feladat: ");
var pontszerzo = adatok.Count();
Console.WriteLine($"Pontszerző helyezések száma: {pontszerzo}");

Console.WriteLine("4.feladat: ");
var arany = adatok.Where(a => a.Helyezes == 1).Count();
var ezust = adatok.Where(a => a.Helyezes == 2).Count();
var bronz = adatok.Where(a => a.Helyezes == 3).Count();
Console.WriteLine($"arany:{arany}\nezüst:{ezust}\nbronz:{bronz}\nÖsszesen:{arany+ezust+bronz}");

Console.WriteLine("5.feladat: ");
var elso = adatok.Where(a => a.Helyezes == 1).Count();
var masodik = adatok.Where(a => a.Helyezes == 2).Count();
var harmadik = adatok.Where(a => a.Helyezes == 3).Count();
var negyedik = adatok.Where(a => a.Helyezes == 4).Count();
var otodik = adatok.Where(a => a.Helyezes == 5).Count();
var hatodik = adatok.Where(a => a.Helyezes == 6).Count();
Console.WriteLine($"Olimpiai pontok száma: {elso * 7 + masodik * 5 + harmadik * 4 + negyedik * 3 + otodik * 2 + hatodik}");


Console.WriteLine("6.feladat: ");
var uszok = adatok.Where(a => a.SportAg == "uszas");
var tornasok = adatok.Where(a => a.SportAg == "torna");

int uszokermei = 0;
int tornasokermei = 0;
foreach (var item in uszok)
{
	if (item.Helyezes >= 3)
	{
		uszokermei += item.SportoloSzam;
	}
}
foreach (var item in tornasok)
{
	if (item.Helyezes >= 3)
	{
		tornasokermei += item.SportoloSzam;
	}
}

if (uszokermei > tornasokermei)
{
    Console.WriteLine($"Uszás sportágban szereztek több érmet");
}
else if (uszokermei < tornasokermei)
{
    Console.WriteLine($"Torna sportágban szereztek több érmet");
}
else
{
    Console.WriteLine("Egyenlő volt az érmek száma");
}

var jolista = new List<Adat>(adatok);
using var sw = new StreamWriter(@"..\..\..\src\helskini2.txt");
foreach (var item in jolista)
{
	if (item.SportAg  == "kajakkenu")
	{
		item.SportAg = "kajak-kenu";
	}
}
foreach (var item in jolista)
{
	sw.WriteLine(item);
}
Console.WriteLine("8.feladat: ");
var legtobbsportolo = adatok.Where(a => a.SportoloSzam == adatok.Max(m => m.SportoloSzam)).First();
Console.WriteLine($"Helyezés: {legtobbsportolo.Helyezes}\nSportág: {legtobbsportolo.SportAg}\nVersenyszám: {legtobbsportolo.VersenySzam}\nSportolók száma: {legtobbsportolo.SportoloSzam}");

