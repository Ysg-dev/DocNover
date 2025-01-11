using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DocNover.Domain.Models
{
    public class Document
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("document_name")]
        public string? Name { get; set; }

        [Column("document_path")]
        public string? Path { get; set; }

        [Column("document_file_extension")]
        public string? FileExtension { get; set; }

        [Column("TopicId")]
        public int TopicId { get; set; }

        public bool IsSelected { get; set; }

    }
}
