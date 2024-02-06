namespace MCIO.Observability.Abstractions.Models
{
    public class Counter
    {
        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unity { get; }

        // Constructors
        private Counter(
            string name,
            string description,
            string unity
        ) 
        {
            Name = name;
            Description = description;
            Unity = unity;
        }

        // Builders
        public static Counter Create(string name, string description, string unity)
            => new Counter(name, description, unity);
    }
}