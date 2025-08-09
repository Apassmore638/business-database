using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSite.Models
{
    [Table("Costing Sheets")]
    public class CostingSheet
    {
        [Key]
        [Column("Sheet Id")]
        public int SheetId { get; set; }

        [Column("Job #")]
        public int JobId { get; set; }

        public string? date { get; set; }

        [Column("quote amount")]
        public double QuoteAmount { get; set; }

        public double margin { get; set; }

        public string? client { get; set; }
    }
}