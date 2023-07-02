using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsOnPrem
{
    [Table("smartwatches", Schema = "pw_gruppo1")]
    public class SmartwatchesOnPrem
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("buying_date")]
        public DateTime BuyingDate { get; set; }
        [Column("production_batch")]
        public string? ProductionBatch { get; set; }
        [Column("user_id")]
        public Guid UserId { get; set; }
    }
}