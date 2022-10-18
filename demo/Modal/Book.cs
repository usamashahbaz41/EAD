using Microsoft.Extensions.Hosting.Internal;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace demo.Modal
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int book_id { get;set;}
        public string name { get;set;}

        public string image { get;set;}

        // We create a function which store data in json format and we can it whenever we want.
        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }
    }
}
