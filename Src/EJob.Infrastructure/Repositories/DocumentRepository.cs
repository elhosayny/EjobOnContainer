using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using EJob.Domain.RepositoryContacts;
using System;
using System.Threading.Tasks;

namespace EJob.Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private EJobDbContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public DocumentRepository(EJobDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Document Add(Document document)
        {
            throw new NotImplementedException();
        }

        public Task<Document> GetAsync(int documentId)
        {
            throw new NotImplementedException();
        }

        public Document Update(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
