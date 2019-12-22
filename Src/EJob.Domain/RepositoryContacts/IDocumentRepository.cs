using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using System.Threading.Tasks;

namespace EJob.Domain.RepositoryContacts
{
    public interface IDocumentRepository : IRepository<Document>
    {
        Document Add(Document document);
        Document Update(Document document);
        Task<Document> GetAsync(int documentId);
    }
}
