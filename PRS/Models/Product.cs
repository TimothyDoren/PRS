using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PRS.Models
{
    [Index("PartNbr", IsUnique=true)]
    public class Product
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string PartNbr { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName="decimal(11,2)")]
        public decimal Price { get; set; }
        [StringLength(30)]
        public string Unit { get; set; }
        [StringLength(30)]
        public string? PhotoPath { get; set; } = null!;
        public int VendorId { get; set; }
        [JsonIgnore]
        public virtual Vendor? Vendor { get; set; }

    }
}
