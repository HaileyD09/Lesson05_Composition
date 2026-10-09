namespace Toolkit;

public record Money
{
    /// <summary>
    /// TODO: This is much more complicated
    /// </summary>
    
    public int Gold { get;  }

    private Money(int gold)
    {
        Gold = gold;
    }
}