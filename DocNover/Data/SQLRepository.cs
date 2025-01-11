using System;
using DocNover.Data.Interfaces;
using DocNover.Domain.Models;
//using DocNover.Domain.Models.Authentication;

namespace DocNover.Data
{
    public class SQLRepository : IRepository
    {

        private readonly AppDbContext _context;
        public List<Topic> allTopics = new List<Topic>();
        public List<Topic> topics = new List<Topic>();
        public List<Document> documents = new List<Document>();

        public SQLRepository(AppDbContext context)
        {
            _context = context;
            var seed = Seed();
            topics = seed.Item1;
            documents = seed.Item2;
            allTopics = seed.Item3;


        }
        public IEnumerable<Topic> GetAllTopics()
        {
            return allTopics;
        }

        public Document? GetDocumentById(int id)
        {
            return documents.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Document> GetDocuments()
        {
            return documents;
        }

        public Topic? GetTopicById(int id)
        {
            return topics.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Topic> GetTopics()
        {
            return topics;
        }


        private (List<Topic>, List<Document>, List<Topic>) Seed()
        {
            var allDocuments = _context.Documents.ToList();
            var topicWithParent = _context.Topics.Where(x => x.ParentId != 0).ToList();
            List<Topic> topics = new List<Topic>();
            List<Topic> allTopics = new List<Topic>();

            foreach(var topic in _context.Topics)
            {
                var insideTopics = _context.Topics.Where(x => x.ParentId == topic.Id).ToList();
                foreach (var isideTopic in insideTopics)
                {
                    topic.Topics.Add(isideTopic);
                }
                var documents = _context.Documents.Where(x => x.TopicId == topic.Id).ToList();
                foreach (var doc in documents)
                {
                    topic.Documents.Add(doc);
                }

                topics.Add(topic);
                allTopics.Add(topic);
            }

            var parentTopic = topics.Where(x => x.ParentId == 0).ToList();

            return (parentTopic, allDocuments, allTopics);
        }
    }
}
