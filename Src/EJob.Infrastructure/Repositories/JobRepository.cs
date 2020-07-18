using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using EJob.Domain.RepositoryContacts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                .Where(j => j.Id == jobId).SingleOrDefaultAsync();
            return job;
        }

        public Job Update(Job job)
        {
            return _context.Update(job).Entity;
        }

        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> DeleteAsync(int id)
        {
            var jobToDelete = await GetAsync(id);
            return _context.Jobs.Remove(jobToDelete).Entity;
        }
    }
}
