using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSite.Models
{
    [Table("Job")]
    public class Job
    {
        [Key]
        [Column("Job #")]
        public int JobId { get; set; }

        [Column("Client Id")]
        public int ClientId { get; set; }

        [Column("Costing Sheet Id")]
        public int CostingSheetId { get; set; }

        public string? Status { get; set; }

        [Column("Drive Folder Id")]
        public string? DriveFolderId { get; set; }

        public string? Description { get; set; }
    }
}