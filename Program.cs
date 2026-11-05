using dolgozatgyakorlo;

List<Eszkoz> eszkozok = new List<Eszkoz>();
if (File.Exists("eszkozok.txt"))
{
    foreach (string aktsor in File.ReadAllLines("eszkozok.txt"))
    {
        string[] adatok = aktsor.Split(";");
        int db = adatok.Count();
        if (db == 4)
        {
            if (int.TryParse(adatok[3], out int napiDij))
            {
                if (!string.IsNullOrWhiteSpace(adatok[0]))
                {
                    Eszkoz aktualis = new Eszkoz(adatok[0], adatok[1], adatok[2], napiDij);
                    eszkozok.Add(aktualis);
                }
                else Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú eszköz adatai hibásak, átugorva!");
            }
            else Console.WriteLine($"[HIBA] A számkonverzió meghiúsult, átugorva!");
        }
        else if (db == 5)
        {
            if (int.TryParse(adatok[3], out int napiDij) && int.TryParse(adatok[4], out int keszlet))
            {
                if (!string.IsNullOrWhiteSpace(adatok[0]))
                {
                    Eszkoz aktualis = new Eszkoz(adatok[0], adatok[1], adatok[2], napiDij, keszlet);
                    eszkozok.Add(aktualis);
                }
                else Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú eszköz adatai hibásak, átugorva!");
            }
            else Console.WriteLine($"[HIBA] A számkonverzió meghiúsult, átugorva!");
        }
        else Console.WriteLine($"[HIBA] A sorban szereplő elemek száma nem megfelelő, átugorva!");
    }
}
else Console.WriteLine("Az eszkozok.txt nem található");
Console.WriteLine(eszkozok.ToString());

