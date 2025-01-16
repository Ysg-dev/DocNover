using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocNover.Domain.Models
{
    public class Catalog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("catalog_name")]
        public string? Name { get; set; }

        [Column("catalog_discription")]
        public string? Description { get; set; }

        [Column("catalog_image_paths")]
        public List<string>? CatalogImagePaths { get; set; }

        [Column("document_id")]
        public int DocumentId { get; set; }

        [Column("topic_id")]
        public int TopicId { get; set; }

        public bool IsSelected { get; set; }
    }
}
