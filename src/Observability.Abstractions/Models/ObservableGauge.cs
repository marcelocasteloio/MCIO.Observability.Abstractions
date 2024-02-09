using MCIO.OutputEnvelop.Models;
using MCIO.OutputEnvelop;

namespace MCIO.Observability.Abstractions.Models
{
    public readonly struct ObservableGauge
    {
        // Constants
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE = "ObservableGauge.Name.Should.Required";
        public const string NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION = "Name should required";

        // Properties
        public string Name { get; }
        public string Description { get; }
        public string Unit { get; }
        public bool IsValid { get; }

        // Constructors
        private ObservableGauge(
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
        public static OutputEnvelop<ObservableGauge?> Create(
            string name,
            string description,
            string unit
        )
        {
            return string.IsNullOrWhiteSpace(name)
                ? OutputEnvelop<ObservableGauge?>.CreateError(
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
                : OutputEnvelop<ObservableGauge?>.CreateSuccess(
                    new ObservableGauge(name, description, unit)
                );
        }
    }
}
