using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PRS.Models
{
    public class Request
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string? RejectionReason { get; set; } = null!;
        [StringLength(20)]
        [DefaultValue("Pickup")]
        public string DeliveryMode { get; set; }
        [StringLength(10)]
        [DefaultValue("NEW")]
        public string Status { get; set; }
        [Column(TypeName="decimal(11,2)")]
        [DefaultValue(0)]
        public decimal Total { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [JsonIgnore]
        public virtual User? User { get; set; }

        public virtual ICollection<RequestLine>? RequestLines { get; set; }




    }
}
