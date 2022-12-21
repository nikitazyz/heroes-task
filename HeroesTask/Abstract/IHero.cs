namespace HeroesTask.Abstract;

public interface IHero
{
    string Name { get; }
    void Attack(IHero hero);
    void TakeDamage(int damage, IHero hero);
}