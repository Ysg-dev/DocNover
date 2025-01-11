using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocNover.Domain.Models
{
    public class Topic
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("topic_name")]
        public string? Name { get; set; }

        [Column("topics")]
        public List<Topic> Topics { get; set; } = [];

        [Column("documents")]
        public List<Document> Documents { get; set; } = [];

        public bool IsExpanded { get; set; } = false;

        [Column("parent_topic_id")]
        public int ParentId { get; set; }
    }
}
