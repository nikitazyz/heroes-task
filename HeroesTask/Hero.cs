using HeroesTask.Abstract;

namespace HeroesTask;

public class Hero : ILoggable, IHero
{
    public string Name { get; }
    private readonly IList<IAbility> _abilities;
    public ILogger Logger { get; }

    public Hero(string name, IList<IAbility> abilities, ILogger logger)
    {
        Logger = logger;
        Name = name;
        _abilities = abilities;
    }

    public void Attack(IHero hero)
    {
        Logger.SendMessage($"{Name} attacks {hero.Name}");
        int damage = _abilities.Sum(ability => ability.Use());
        hero.TakeDamage(damage, hero);
    }

    public void TakeDamage(int damage, IHero hero)
    {
        Logger.SendMessage($"{Name} received {damage} damage from {hero.Name}");
    }
}