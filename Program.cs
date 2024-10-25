

using System.Security.Cryptography.X509Certificates;

Pokemon CreateBulbasaur()
{
    return new Pokemon
    {
        Name = "Bulbasaur",
        Health = 45,
        Attack = 50,
        Defence = 50,
        Special = 65,
        Speed = 45,
    };
}

Pokemon CreateCharmander()
{
    return new Pokemon
    {
        Name = "Charmander",
        Health = 40,
        Attack = 55,
        Defence = 45,
        Special = 50,
        Speed = 65,
    };
}

Pokemon CreateSquirtle()
{
    return new Pokemon
    {
        Name = "Squirtle",
        Health = 45,
        Attack = 50,
        Defence = 65,
        Special = 50,
        Speed = 45,
    };
}

Pokemon CreatePikachu()
{
    return new Pokemon
    {
        Name = "Pikachu",
        Health = 35,
        Attack = 55,
        Defence = 40,
        Special = 50,
        Speed = 90,
    };
}

Pokemon CreateEevee()
{
    return new Pokemon
    {
        Name = "Eevee",
        Health = 55,
        Attack = 55,
        Defence = 50,
        Special = 65,
        Speed = 55,
    };
}

public class Pokemon
{
    public string Name;
    public int Health;
    public int Attack;
    public int Defence;
    public int Special;
    public int Speed;

    public virtual void BasicAttack()
    {
        
    }
}

public class Bulbasaur : Pokemon
{
    public override void BasicAttack()
    {
        base.BasicAttack();
    }
}
