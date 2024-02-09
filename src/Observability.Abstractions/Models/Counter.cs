using MCIO.OutputEnvelop;
using MCIO.OutputEnvelop.Models;

namespace MCIO.Observability.Abstractions.Models
{
    public readonly struct Counter
    {
        // Constants
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE = "Counter.Name.Should.Required";
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION = "Name should required";

        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unit { get; }
        public bool IsValid { get; }

        // Constructors
        private Counter(
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
        public static OutputEnvelop<Counter?> Create(
            string name, 
            string description, 
            string unit
        )
        {
            return string.IsNullOrWhiteSpace(name)
                ? OutputEnvelop<Counter?>.CreateError(
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
                : OutputEnvelop<Counter?>.CreateSuccess(
                    new Counter(name, description, unit)
                );
        }
    }
}