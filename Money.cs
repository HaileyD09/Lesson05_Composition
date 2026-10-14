namespace Toolkit;

public record Money
{
    /// <summary>
    /// TODO: This is much more complicated
    /// </summary>

    public int Gold { get; }

    public static Money Default { get; } = new Money(0);

    private Money(int gold)
    {
        Gold = gold;
    }
}