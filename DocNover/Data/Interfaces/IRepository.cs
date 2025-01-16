using DocNover.Domain.Models;

namespace DocNover.Data.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Topic> GetTopics();
        IEnumerable<Topic> GetAllTopics();
        Topic? GetTopicById(int id);
        IEnumerable<Document> GetDocuments();
        Document? GetDocumentById(int id);
        IEnumerable<Catalog> GetCatalogs();
        Catalog? GetCatalogById(int id);        
    }
}
