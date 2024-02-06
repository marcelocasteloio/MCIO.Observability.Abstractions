using FluentAssertions;
using MCIO.Observability.Abstractions.Models;

namespace MCIO.Observability.Abstractions.UnitTests.ModelsTests;
public class HistogramTest
{
    [Fact]
    public void Histogram_Should_Created()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = Guid.NewGuid().ToString();
        var unity = Guid.NewGuid().ToString();

        // Act
        var histogram = Models.Histogram.Create(name, description, unity).Output!.Value;

        // Assert
        histogram.Name.Should().Be(name);
        histogram.Description.Should().Be(description);
        histogram.Unity.Should().Be(unity);
        histogram.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Histogram_Should_Created_With_Only_Name()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = default(string);
        var unity = default(string);

        // Act
        var histogram = Models.Histogram.Create(name, description, unity).Output!.Value;

        // Assert
        histogram.Name.Should().Be(name);
        histogram.Description.Should().Be(description);
        histogram.Unity.Should().Be(unity);
        histogram.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Histogram_Should_Not_Valid_From_Default()
    {
        // Arrange and Act
        var histogram = default(Models.Histogram);

        // Assert
        histogram.Name.Should().BeNull();
        histogram.Description.Should().BeNull();
        histogram.Unity.Should().BeNull();
        histogram.IsValid.Should().BeFalse();
    }

    [Fact]
    public void Histogram_Should_Not_Created()
    {
        // Arrange
        var name = default(string);
        var description = default(string);
        var unity = default(string);

        // Act
        var output = Models.Histogram.Create(name, description, unity);

        // Assert
        output.IsSuccess.Should().BeFalse();
        output.HasOutput.Should().BeFalse();
        output.Output.Should().BeNull();

        output.OutputMessageCollectionCount.Should().Be(1);
        output.OutputMessageCollection.Any(q =>
            q.Type == OutputEnvelop.Enums.OutputMessageType.Error
            && q.Code == Histogram.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE
            && q.Description == Histogram.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION
        ).Should().BeTrue();
    }
}