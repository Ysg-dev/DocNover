using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocNover.Domain.Models
{
    public class Journal
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("jurnal_name")]
        public string? Name { get; set; }

        [Column("jurnal_discription")]
        public string? Description { get; set; }

        [Column("jurnal_image_paths")]
        public List<string>? JurnalImagePaths { get; set; }

        [Column("document_id")]
        public int DocumentId { get; set; }

        [Column("topic_id")]
        public int TopicId { get; set; }

        public bool IsSelected { get; set; }
    }
}
