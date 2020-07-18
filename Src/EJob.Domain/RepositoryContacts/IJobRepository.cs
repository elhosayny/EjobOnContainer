using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EJob.Domain.RepositoryContacts
{
    public interface IJobRepository: IRepository<Job>
    {
        Job Add(Job job);
        Job Update(Job job);
        Task<Job> GetAsync(int jobId);
        Task<IEnumerable<Job>> GetAllAsync();
        Task<Job> DeleteAsync(int id);
    }
}
