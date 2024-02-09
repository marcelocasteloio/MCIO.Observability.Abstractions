using MCIO.OutputEnvelop.Models;
using MCIO.OutputEnvelop;

namespace MCIO.Observability.Abstractions.Models
{
    public readonly struct Histogram
    {
        // Constants
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE = "Histogram.Name.Should.Required";
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION = "Name should required";

        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unit { get; }
        public bool IsValid { get; }

        // Constructors
        private Histogram(
            string name,
            string description,
            string unit
        )
        {
            Name = name;
            Description = description;
            Unit = unit;
            IsValid = true;
        }

        // Builders
        public static OutputEnvelop<Histogram?> Create(
            string name,
            string description,
            string unit
        )
        {
            return string.IsNullOrWhiteSpace(name)
                ? OutputEnvelop<Histogram?>.CreateError(
                    output: null,
                    outputMessageCollection: new[]
                    {
                        OutputMessage.CreateError(
                            NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE,
                            NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION
                        )
                    },
                    exceptionCollection: null
                )
                : OutputEnvelop<Histogram?>.CreateSuccess(
                    new Histogram(name, description, unit)
                );
        }
    }
}
