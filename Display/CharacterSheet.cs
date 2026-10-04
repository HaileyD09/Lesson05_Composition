namespace Toolkit.Display;

/// <summary>
/// Prints character sheets.  Display lives here, beside the data, the way
/// Lesson 3 moved it.
/// </summary>
public static class CharacterSheet
{
    extension(Player player)
    {
        public void ShowSheet()
        {
            Console.WriteLine($"== {player.Name} ==  level {player.Level}, {player.Experience} XP");
            Console.WriteLine($"   HP {player.CurrentHealth}/{player.MaxHealth}    Gold {player.Gold}");
            Console.WriteLine($"   STR {Score(player.Strength)}   DEX {Score(player.Dexterity)}   CON {Score(player.Constitution)}");
            Console.WriteLine($"   INT {Score(player.Intelligence)}   WIS {Score(player.Wisdom)}   CHA {Score(player.Charisma)}");
            Console.WriteLine();
        }
    }

    extension(Creature creature)
    {
        public void ShowSheet()
        {
            Console.WriteLine($"== {creature.Name} ==  worth {creature.ExperienceReward} XP");
            Console.WriteLine($"   HP {creature.CurrentHealth}/{creature.MaxHealth}");
            Console.WriteLine($"   STR {Score(creature.Strength)}   DEX {Score(creature.Dexterity)}   CON {Score(creature.Constitution)}");
            Console.WriteLine($"   INT {Score(creature.Intelligence)}   WIS {Score(creature.Wisdom)}   CHA {Score(creature.Charisma)}");
            Console.WriteLine();
        }
    }

    /// <summary>A score and its modifier, the way a sheet prints it:  "14 (+2)".</summary>
    private static string Score(int score)
    {
        int modifier = (score - 10) / 2;
        return $"{score,2} ({modifier:+0;-0;+0})";
    }
}
