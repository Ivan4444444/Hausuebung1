List<int> zahlenListe = new List<int>();
zahlenListe.Add(68);
zahlenListe.Add(41);
zahlenListe.Add(38);
zahlenListe.Add(23);

int summe = 0;
for (int i = 0; i < zahlenListe.Count; i++)
{
    summe += zahlenListe[i];
}

Console.WriteLine("Die Summe der Zahlen in der Liste ist: " + summe);