public class Hero
{
    public string Nameh;
    public string Weapon;
    public int WeaponHp;
        public int Hp;
        private string savename="Merlin"; 

    public void Attack(Villain target)
    {
        Console.WriteLine($"{Nameh} attackerar {target.NameV} med sitt{Weapon}");
        while (target.VillainHP > 0)
        {
            Console.WriteLine($"\n------=====Slå {target.NameV}=====------");
            Console.WriteLine($"{Nameh}:{Weapon}:{WeaponHp}:{target.NameV}:{target.VillainHP}\n");

            int weaponDamage = WeaponHp;
            target.VillainHP -= weaponDamage;
            target.VillainHP = Math.Max(0, target.VillainHP);

            Console.WriteLine($"{Weapon} gör{weaponDamage} på {target.VillainHP}");
            Console.ReadKey();
        }
        Console.WriteLine($"Yay du slog {target.NameV}");
    }
    public void Attacksave(Villain target)
    {
           Console.WriteLine($"{Nameh} attackerar {target.NameV} med sitt{Weapon}");
        while (target.VillainHP > 0)
        {
            Console.WriteLine($"\n------=====Rädda {savename}=====------");
            Console.WriteLine($"{Nameh}:{Weapon}:{WeaponHp}:{target.NameV}:{target.VillainHP}\n");

            int weaponDamage = WeaponHp;
            target.VillainHP -= weaponDamage;
            target.VillainHP = Math.Max(0, target.VillainHP);

            Console.WriteLine($"{Weapon} gör{weaponDamage} på {target.VillainHP}");
            Console.ReadKey();
        }
        Console.WriteLine($"Yay du räddade{savename} ");
    }
}