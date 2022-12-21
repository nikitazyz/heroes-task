using HeroesTask.Abstract;

namespace HeroesTask;

internal static class Program
{
    public static void Main()
    {
        IHero swordHero = HeroFactory.CreateSwordHero();
        IHero fireHero = HeroFactory.CreateFireHero();
        IHero freezeHero = HeroFactory.CreateFreezeHero();
        
        swordHero.Attack(fireHero);
        fireHero.Attack(freezeHero);
        freezeHero.Attack(swordHero);
    }
}