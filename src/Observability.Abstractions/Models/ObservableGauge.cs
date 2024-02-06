namespace MCIO.Observability.Abstractions.Models
{
    public class ObservableGauge
    {
        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unity { get; }

        // Constructors
        private ObservableGauge(
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
        public static ObservableGauge Create(string name, string description, string unity)
            => new ObservableGauge(name, description, unity);
    }
}
