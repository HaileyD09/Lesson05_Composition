namespace Toolkit;

/// <summary>
/// A player character.  Everything a character sheet says, one property per
/// line.
///
/// Built the Lesson 2 way:  the constructor is private, and the only way in is
/// the factory method below, which checks every number before it lets one
/// through.
/// </summary>
public record Player
{
    public string Name { get; }

    public int Level { get; }
    public int Experience { get; }

    public int CurrentHealth { get; }
    public int MaxHealth { get; }

    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }

    public int Gold { get; }

    private Player(string name, int level, int experience,
        int currentHealth, int maxHealth,
        int strength, int dexterity, int constitution,
        int intelligence, int wisdom, int charisma,
        int gold)
    {
        Name = name;
        Level = level;
        Experience = experience;
        CurrentHealth = currentHealth;
        MaxHealth = maxHealth;
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
        Gold = gold;
    }

    /// <summary>
    /// Builds a player, or refuses to.  Every player in the program comes
    /// through here.
    /// </summary>
    public static Player Create(string name, int level, int experience,
        int currentHealth, int maxHealth,
        int strength, int dexterity, int constitution,
        int intelligence, int wisdom, int charisma,
        int gold)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("A player needs a name.", nameof(name));

        if (level < 1 || level > 20)
            throw new ArgumentOutOfRangeException(
                nameof(level), level, "Level runs from 1 to 20.");

        if (experience < 0)
            throw new ArgumentOutOfRangeException(
                nameof(experience), experience, "Experience can't be negative.");

        if (maxHealth < 1)
            throw new ArgumentOutOfRangeException(
                nameof(maxHealth), maxHealth, "Max health is at least 1.");

        if (currentHealth < 0 || currentHealth > maxHealth)
            throw new ArgumentOutOfRangeException(
                nameof(currentHealth), currentHealth,
                $"Current health runs from 0 to max health ({maxHealth}).");

        if (strength < 3 || strength > 18)
            throw new ArgumentOutOfRangeException(
                nameof(strength), strength, "Ability scores run from 3 to 18.");

        if (dexterity < 3 || dexterity > 18)
            throw new ArgumentOutOfRangeException(
                nameof(dexterity), dexterity, "Ability scores run from 3 to 18.");

        if (constitution < 3 || constitution > 18)
            throw new ArgumentOutOfRangeException(
                nameof(constitution), constitution, "Ability scores run from 3 to 18.");

        if (intelligence < 3 || intelligence > 18)
            throw new ArgumentOutOfRangeException(
                nameof(intelligence), intelligence, "Ability scores run from 3 to 18.");

        if (wisdom < 3 || wisdom > 18)
            throw new ArgumentOutOfRangeException(
                nameof(wisdom), wisdom, "Ability scores run from 3 to 18.");

        if (charisma < 3 || charisma > 18)
            throw new ArgumentOutOfRangeException(
                nameof(charisma), charisma, "Ability scores run from 3 to 18.");

        if (gold < 0)
            throw new ArgumentOutOfRangeException(
                nameof(gold), gold, "Gold can't be negative.");

        return new Player(name, level, experience,
            currentHealth, maxHealth,
            strength, dexterity, constitution,
            intelligence, wisdom, charisma,
            gold);
    }
}
