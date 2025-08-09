using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSite.Models
{
    [Table("Line Items")]
    public class LineItem
    {
        [Key]
        [Column("Line Item Id")]
        public int LineItemId { get; set; }

        [Column("Job #")]
        public int JobId { get; set; }

        [Column("Item name")]
        public string? ItemName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}