using Excersices.string_manipulation;

namespace Exercises.Test
{
    public class StringManipulatorTests
    {
        [Fact]
        public void JoinStrings_WithValidInput_ReturnsConcatenatedString()
        {
            // Arrage
            string[] strings = { "apple", "banana", "cherry"};
            string seperator = ",";

            // Act
            string result = StringManipulator.JoinStrings(strings,seperator);

             // Assert
             Assert.Equal("apple,banana,cherry", result);
        }
    }
}