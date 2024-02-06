namespace MCIO.Observability.Abstractions.Models
{
    public class Histogram
    {
        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unity { get; }

        // Constructors
        private Histogram(
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
        public static Histogram Create(string name, string description, string unity)
            => new Histogram(name, description, unity);
    }
}
