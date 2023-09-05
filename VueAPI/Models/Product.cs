
using System.Text.Json.Serialization;

namespace VueAPI.Models
{
    public class Product
    {public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    [JsonIgnore]
    public List<User> Users { get; set; }
    }
}
 
