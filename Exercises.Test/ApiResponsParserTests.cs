using Excersices.string_manipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Test
{
    public class ApiResponsParserTests
    {
        [Theory]
        [InlineData(new string[] { "apple", "banana", "cherry" }, ", ", "apple, banana, cherry")]
        [InlineData(new string[] { "dog", "cat", "mouse" }, " - ", "dog - cat - mouse")]
        [InlineData(new string[] { "one", "two", "three" }, "|", "one|two|three")]
        public void JoinStrings_WithVariousInput_ReturnsConcatenatedString(string[] strings, string seperator, string expected)
        {
            // Arrage


            //Act
            string result = StringManipulator.JoinStrings(strings, seperator);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
