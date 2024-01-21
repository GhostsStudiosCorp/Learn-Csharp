Random damage = new Random();

int healthHero = 10;
int healthMonster = 10;

/*
Este bloque de codigo consiste en un juego muy basico de rol en el que comienza de forma 
automatica nuestro player(Hero) atacando a un monstruo y el monstro ataca en consecuencia igual hazta que la vida(healthMonster, healthHero) llegue a 0 o menos
*/
do
{
    int strange = 0;

    strange = damage.Next(1, 11);
    healthMonster -= strange;

    Console.WriteLine($"Monster was damaged and lost {strange} health and now has {healthMonster} health.");

    if (healthMonster <= 0) continue;
    
    strange = damage.Next(1, 11);
    healthHero -= strange;

    Console.WriteLine($"Hero was damaged and lost {strange} health and now has {healthHero} health.");

} while ((healthMonster > 0) && (healthHero > 0));

Console.WriteLine(healthHero > healthMonster ? "Hero wins" : "Monster wins");