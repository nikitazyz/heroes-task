using HeroesTask.Abstract;

namespace HeroesTask;

public class SwordAbility : IAbility
{
    public ILogger Logger { get; }
    public string Name { get; }
    public int Damage { get; }
    public int DamageRadius { get; }

    public int DamageMultiplier { get; }

    public SwordAbility(string name, int damage, int damageRadius, ILogger logger, int damageMultiplier)
    {
        Logger = logger;
        Name = name;
        Damage = damage;
        DamageRadius = damageRadius;
        DamageMultiplier = damageMultiplier;
    }

    public int Use()
    {
        int overallDamage = Damage * DamageMultiplier;
        Logger.SendMessage($"Using {Name}. Base damage: {Damage}, Overall damage: {overallDamage}, Radius: {DamageRadius}, Damage multiplier: {DamageMultiplier}");
        return overallDamage;
    }
}