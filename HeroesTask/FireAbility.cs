using HeroesTask.Abstract;

namespace HeroesTask;

class FireAbility : IAbility
{
    public ILogger Logger { get; }
    public string Name { get; }
    public int Damage { get; }
    public int DamageRadius { get; }
    
    public int FireDuration { get; }

    public FireAbility(string name, int damage, int damageRadius, ILogger logger, int fireDuration)
    {
        Logger = logger;
        Name = name;
        Damage = damage;
        DamageRadius = damageRadius;
        FireDuration = fireDuration;
    }

    public int Use()
    {
        Logger.SendMessage($"Using {Name}. Damage {Damage}, Radius: {DamageRadius}, Fire duration: {FireDuration}");
        return Damage;
    }
}