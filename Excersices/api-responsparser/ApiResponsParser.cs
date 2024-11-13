using Excersices.api_responsparser.abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Excersices.api_responsparser
{

    public class ApiResponsParser
    {
        // Method that takes in a Json and deserialize it to Product
        public Product ParseProduct(string productJson)
        {
			try
			{
				Product result = JsonSerializer.Deserialize<Product>(productJson, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
                return result;
			}
			catch (Exception ex)
			{

				throw new InvalidOperationException(ex.Message);
			}
        }
    }
}
