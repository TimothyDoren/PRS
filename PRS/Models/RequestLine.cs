using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PRS.Models
{
    public class RequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public virtual Request? Request { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required]
        [DefaultValue(1)]
        public int Quantity { get; set; }
    }
}
