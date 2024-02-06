using FluentAssertions;
using MCIO.Observability.Abstractions.Models;

namespace MCIO.Observability.Abstractions.UnitTests.ModelsTests;
public class ObservableGaugeTest
{
    [Fact]
    public void ObservableGauge_Should_Created()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = Guid.NewGuid().ToString();
        var unity = Guid.NewGuid().ToString();

        // Act
        var observableGauge = Models.ObservableGauge.Create(name, description, unity).Output!.Value;

        // Assert
        observableGauge.Name.Should().Be(name);
        observableGauge.Description.Should().Be(description);
        observableGauge.Unity.Should().Be(unity);
        observableGauge.IsValid.Should().BeTrue();
    }

    [Fact]
    public void ObservableGauge_Should_Created_With_Only_Name()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = default(string);
        var unity = default(string);

        // Act
        var observableGauge = Models.ObservableGauge.Create(name, description, unity).Output!.Value;

        // Assert
        observableGauge.Name.Should().Be(name);
        observableGauge.Description.Should().Be(description);
        observableGauge.Unity.Should().Be(unity);
        observableGauge.IsValid.Should().BeTrue();
    }

    [Fact]
    public void ObservableGauge_Should_Not_Valid_From_Default()
    {
        // Arrange and Act
        var observableGauge = default(Models.ObservableGauge);

        // Assert
        observableGauge.Name.Should().BeNull();
        observableGauge.Description.Should().BeNull();
        observableGauge.Unity.Should().BeNull();
        observableGauge.IsValid.Should().BeFalse();
    }

    [Fact]
    public void ObservableGauge_Should_Not_Created()
    {
        // Arrange
        var name = default(string);
        var description = default(string);
        var unity = default(string);

        // Act
        var output = Models.ObservableGauge.Create(name, description, unity);

        // Assert
        output.IsSuccess.Should().BeFalse();
        output.HasOutput.Should().BeFalse();
        output.Output.Should().BeNull();

        output.OutputMessageCollectionCount.Should().Be(1);
        output.OutputMessageCollection.Any(q =>
            q.Type == OutputEnvelop.Enums.OutputMessageType.Error
            && q.Code == ObservableGauge.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE
            && q.Description == ObservableGauge.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION
        ).Should().BeTrue();
    }
}