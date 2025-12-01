Console.WriteLine("Välj vilken Hero du vill vara");
List<string>Heros=[]; 
Heros.Add("Red"); 
Heros.Add("Chloe");
Console.WriteLine(Heros[0]);
Console.WriteLine(Heros[1]);

bool done=false; 
string Heroname=""; 
while (!done)
{
Heroname=Console.ReadLine(); 
if (Heros.Contains(Heroname))
{
    Console.WriteLine($"Du är {Heroname}");
    done=true; 
}
    else
    {
        Console.WriteLine("Skriv ett nams från listan");
    }
}

if (Heroname=="Red")
{
    Red r=new(); 
    Uliana u=new(); 
    r.Attack(u); 
    r.Attacksave(u); 
}
else
{
    Chloe ch=new(); 
}


Console.ReadLine(); 