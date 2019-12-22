using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using EJob.Domain.RepositoryContacts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EJob.Infrastructure.Repositories
{
    public class JobRepository : IJobRepository
    {
        private EJobDbContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public JobRepository(EJobDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Job Add(Job job)
        {
            return _context.Add(job).Entity;
        }

        public async Task<Job> GetAsync(int jobId)
        {
            var job = await _context
                .Jobs.Include(x => x.Spools)
                .FirstOrDefaultAsync(j => j.Id == j.Id);
            return job;
        }

        public Job Update(Job job)
        {
            return _context.Update(job).Entity;
        }
    }
}
