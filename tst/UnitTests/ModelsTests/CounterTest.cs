using FluentAssertions;
using MCIO.Observability.Abstractions.Models;

namespace MCIO.Observability.Abstractions.UnitTests.ModelsTests;
public class CounterTest
{
    [Fact]
    public void Counter_Should_Created()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = Guid.NewGuid().ToString();
        var unity = Guid.NewGuid().ToString();

        // Act
        var counter = Models.Counter.Create(name, description, unity).Output!.Value;

        // Assert
        counter.Name.Should().Be(name);
        counter.Description.Should().Be(description);
        counter.Unity.Should().Be(unity);
        counter.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Counter_Should_Created_With_Only_Name()
    {
        // Arrange
        var name = Guid.NewGuid().ToString();
        var description = default(string);
        var unity = default(string);

        // Act
        var counter = Models.Counter.Create(name, description, unity).Output!.Value;

        // Assert
        counter.Name.Should().Be(name);
        counter.Description.Should().Be(description);
        counter.Unity.Should().Be(unity);
        counter.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Counter_Should_Not_Valid_From_Default()
    {
        // Arrange and Act
        var counter = default(Models.Counter);

        // Assert
        counter.Name.Should().BeNull();
        counter.Description.Should().BeNull();
        counter.Unity.Should().BeNull();
        counter.IsValid.Should().BeFalse();
    }

    [Fact]
    public void Counter_Should_Not_Created()
    {
        // Arrange
        var name = default(string);
        var description = default(string);
        var unity = default(string);

        // Act
        var output = Models.Counter.Create(name, description, unity);

        // Assert
        output.IsSuccess.Should().BeFalse();
        output.HasOutput.Should().BeFalse();
        output.Output.Should().BeNull();

        output.OutputMessageCollectionCount.Should().Be(1);
        output.OutputMessageCollection.Any(q =>
            q.Type == OutputEnvelop.Enums.OutputMessageType.Error
            && q.Code == Counter.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_CODE
            && q.Description == Counter.NAME_SHOULD_REQUIRED_REQUIRED_MESSAGE_DESCRIPTION
        ).Should().BeTrue();
    }
}