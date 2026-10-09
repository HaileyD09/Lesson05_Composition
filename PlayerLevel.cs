namespace Toolkit;

public record PlayerLevel
{
    public int Experience { get; }
    
        /// <summary>
        /// TO-DO: calculate this in a future lesson
        /// </summary>
        public int Level { get; }

        private PlayerLevel(int Experience)
        {
            this.Experience = Experience;
            
            //TODO: THIS IS BAD!
            
            this.Level = 1 + Experience / 100;
        }
    
}