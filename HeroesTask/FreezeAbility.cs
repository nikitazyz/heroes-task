using HeroesTask.Abstract;

namespace HeroesTask;

public class FreezeAbility : IAbility
{
    public ILogger Logger { get; }
    public string Name { get; }
    public int Damage { get; }
    public int DamageRadius { get; }
    public FreezeColor IceColor { get; }
    public int CooldownDuration { get; }

    public FreezeAbility(string name, int damage, int damageRadius, ILogger logger, FreezeColor iceColor, int cooldownDuration)
    {
        Logger = logger;
        Name = name;
        Damage = damage;
        DamageRadius = damageRadius;
        IceColor = iceColor;
        CooldownDuration = cooldownDuration;
    }

    public int Use()
    {
        Logger.SendMessage($"Using {Name}. Damage {Damage}, Radius {DamageRadius}, Cooldown duration: {CooldownDuration}, IceColor: {IceColor}");
        return Damage;
    }
    
    public enum FreezeColor
    {
        White,
        Blue,
        Green,
        Yellow,
        Red,
    }
}