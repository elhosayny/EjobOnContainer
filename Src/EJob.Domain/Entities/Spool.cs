using EJob.Domain.Interfaces;

namespace EJob.Domain.Entities
{
    public class Spool: Entity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int CustomerCount { get; set; }
        public int SheetCount { get; set; }
    }
}
