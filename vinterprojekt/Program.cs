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
    Queen_of_hearts q=new();
    r.Attack(q); 
    r.Attacksave(u); 
    r.Attacksave(q); 
}
else
{
    Chloe c=new(); 
    Uliana u=new(); 
    Queen_of_hearts q=new();
    c.Attack(q); 
    c.Attack(u); 
    c.Attacksave(q); 
    c.Attacksave(u); 
}


Console.ReadLine(); 