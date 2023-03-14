using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PRS.Models
{
    public class RequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        [JsonIgnore]
        public virtual Request? Request { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product? Product { get; set; }
        [Required]
        [DefaultValue(1)]
        public int Quantity { get; set; }
    }
}
