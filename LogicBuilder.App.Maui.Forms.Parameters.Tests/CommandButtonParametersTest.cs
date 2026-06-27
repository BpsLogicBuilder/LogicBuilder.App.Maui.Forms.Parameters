using LogicBuilder.App.Maui.Forms.Parameters;
using Xunit;

namespace LogicBuilder.App.Maui.Forms.Parameters.Tests
{
    public class CommandButtonParametersTest
    {
        [Fact]
        public void ConstructorShouldInitializeAllProperties()
        {
            // Arrange
            string command = "SubmitCommand";
            string buttonIcon = "Save";

            // Act
            var parameters = new CommandButtonParameters(
                command: command,
                buttonIcon: buttonIcon
            );

            // Assert
            Assert.Equal(command, parameters.Command);
            Assert.Equal(buttonIcon, parameters.ButtonIcon);
        }
    }
}
