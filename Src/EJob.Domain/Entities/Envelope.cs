using EJob.Domain.Interfaces;

namespace EJob.Domain.Entities
{
    public class Envelope: Entity
    {
        public string Name { get; set; }
        public string Codification { get; set; }
    }
}
