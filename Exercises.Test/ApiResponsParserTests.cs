using Excersices.api_responsparser;
using Excersices.api_responsparser.abstractions;

namespace Exercises.Test
{
    public class ApiResponsParserTests
    {
        //    9. API-responsparser
        //        Uppgift: Implementera en parser som konverterar JSON-svar från ett API till objekt.
        //        Tester: Skriv xUnit-tester som simulerar API-svar i olika format för att se till att parsningen hanterar dessa korrekt.

        private readonly ApiResponsParser _parser;
        public ApiResponsParserTests() 
        {
            _parser = new ApiResponsParser();
        }

        [Fact]
        public void ConvertJsonToObject_WithValidJson_ReturnsSpecificObject()
        {        
            // Arrange
            string productJson = "{\"id\": 1, \"name\": \"Laptop\", \"price\": 1200.50, \"inStock\": true}";

            // Act
            var result = _parser.ParseProduct(productJson);

            // Assert
            // Check all values in result
            Assert.NotNull(result);
            Assert.Equal(1,result.Id);
            Assert.Equal("Laptop",result.Name);
            Assert.Equal(1200.50,result.Price);
            Assert.True(result.InStock);
            Assert.IsType<Product>(result);  
        }
    }
}
