//Erstellen sie eine sortierte Liste mit 5 Schülern und sortierschlüssel ihre Grösse

/* using System.Collections;


grösse();


static void grösse()
{
    SortedList<int, string> tabelle = new SortedList<int, string>();
    for (int i = 0; i <=5; i++)
    {
        try
        {
            Console.Write($"Geben sie den Namen des Schülers ein: ");
            string x=Console.ReadLine();
            Console.Write($"Geben sie die Grösse des Schülers ein: ");
            int y = Convert.ToInt32(Console.ReadLine());


            tabelle.Add(y,x);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    foreach  (KeyValuePair<int,string> x in tabelle)
    {
        Console.WriteLine($"\nDer Schüler: {x.Value} ist {x.Key} Gross");
    }

}
*/
/*Stack<string> stapel=new Stack<string>();

stapel.Push("Karo 10");
stapel.Push("Karo 8");
stapel.Push("Karo 5");
stapel.Push("Karo 9");
stapel.Push("Herz 5");

foreach (var x in stapel)
{
    Console.WriteLine($"Die karte ist : {x}");

}

for (int i =stapel.Count; i >0; i--)
{
    if(stapel.Peek().Equals("Karo 5"))
    {
        break;
    }
    else
    {
        stapel.Pop();
    }
}

Console.WriteLine($"___________________________\n\nErgebnis nach der Schleife\n___________________________");
foreach (var x in stapel)
{
    Console.WriteLine($"Die karten : {x}");
}
*/
//Erstelle ein Stack wenn man die karo 5 trifft löscht es den rest
Stack<string> tabelle = new Stack<string>();
tabelle.Push("Karo 6");
tabelle.Push("Herz 6");
tabelle.Push("Kleeblatt 6");
tabelle.Push("Pick 7");
tabelle.Push("Karo 5");
tabelle.Push("Karo 10");
tabelle.Push("Karo 9");
tabelle.Push("Karo 2");

foreach (var x in tabelle)
{
    Console.WriteLine(x);
}

for (int i = tabelle.Count; i > 0; i--)
{
    if (tabelle.Peek().Equals("Karo 5"))
    {

        break;
    }
    else
    {
        tabelle.Pop();
    }
}

Console.WriteLine($"\nTabelle nach der Schleife\n");
foreach (var x in tabelle)
{
    Console.WriteLine(x);
}