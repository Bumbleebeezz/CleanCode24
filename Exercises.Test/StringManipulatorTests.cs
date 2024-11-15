using Excersices.string_manipulation;
using System.Diagnostics.Metrics;

namespace Exercises.Test
{
    public class StringManipulatorTests
    {
//        6. String Joiner
//             Uppgift: Skriv en metod JoinStrings som sammanfogar en array av strängar med ett specifikt avskiljtecken.
//             Tester: Använd xUnit för att skapa tester som verifierar att metoden korrekt hanterar olika scenarier, inklusive tomma arrays och null-värden.
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