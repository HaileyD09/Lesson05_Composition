namespace Toolkit;

public record PlayerLevel
{
    public int Experience { get; }

    /// <summary>
    /// TO-DO: calculate this in a future lesson
    /// </summary>
    public int Level { get; }

    public static PlayerLevel Default { get; } = new PlayerLevel(0);

    private PlayerLevel(int experience)
    {
        Experience = experience;

        //TODO: THIS IS BAD!

        Level = 1 + experience / 100;
    }
}