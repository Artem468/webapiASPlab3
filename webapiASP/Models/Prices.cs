using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapiASP.Models;

public class Prices
{
    [Key]
    public long PricesId { get; set; }

    public long ProductCode { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    [JsonIgnore]
    public ICollection<RegistrationProduct>? RegistrationProducts { get; set; }
}