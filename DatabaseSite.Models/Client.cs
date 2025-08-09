using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSite.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [Column("Client Id")]
        public int ClientId { get; set; }

        public string? Name { get; set; }

        [Column("email/number")]
        public string? EmailOrNumber { get; set; }

        [Column("Last Margin")]
        public double LastMargin { get; set; }

        [Column("client folder id")]
        public string? ClientFolderId { get; set; }

        [Column("adress")]
        public string? Address { get; set; }
    }
}