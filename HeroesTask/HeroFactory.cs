using HeroesTask.Abstract;

namespace HeroesTask;

public class HeroFactory
{
    private static ILogger CreateLogger(ConsoleColor consoleColor) => new ConsoleLogger(consoleColor);

    #region AbilityCreationMethods


    public static IAbility CreateSwordAbility(int damageMultiplier, ILogger logger) =>
        new SwordAbility("Sword", 10, 1, logger, damageMultiplier);

    public static IAbility CreateFireAbility(int fireDuration, ILogger logger) =>
        new FireAbility("Fire", 30, 4, logger, fireDuration);

    public static IAbility CreateFreezeAbility(FreezeAbility.FreezeColor freezeColor,
        int cooldownDuration, ILogger logger) =>
        new FreezeAbility("Freeze", 20, 2, logger, freezeColor, cooldownDuration);

    #endregion
    
    #region HeroCreationMethods

    public static IHero CreateSwordHero()
    {
        ILogger logger = CreateLogger(ConsoleColor.Black);
        return new Hero("SwordHero",
            new IAbility[] { CreateSwordAbility(2, logger) },
            logger);
    }

    public static IHero CreateFireHero()
    {
        ILogger logger = CreateLogger(ConsoleColor.DarkRed);
        return new Hero("SwordFireHero",
            new IAbility[]
            {
                CreateSwordAbility(3, logger),
                CreateFireAbility(5, logger)
            },
            logger);
    }

    public static IHero CreateFreezeHero()
    {
        ILogger logger = CreateLogger(ConsoleColor.DarkCyan);
        return new Hero("SwordFreezeHero",
            new IAbility[]
            {
                CreateSwordAbility(4, logger),
                CreateFreezeAbility(FreezeAbility.FreezeColor.Blue, 2, logger)
            },
            logger);
    }

    #endregion
}