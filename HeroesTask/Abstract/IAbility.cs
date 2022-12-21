namespace HeroesTask.Abstract;

public interface IAbility : ILoggable
{
    public string Name { get; }
    public int Damage { get; }
    public int DamageRadius { get; }
    public int Use();
}