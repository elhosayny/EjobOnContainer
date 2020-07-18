using EJob.Domain.Entities;
using EJob.Domain.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EJob.Infrastructure
{
    public class EJobDbContext : IdentityDbContext, IUnitOfWork
    {
        public EJobDbContext(DbContextOptions<EJobDbContext> options)
            :base(options)
        {

        }

        protected EJobDbContext() { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Envelope> Envelopes { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Spool> Spools { get; set; }

    }
}
