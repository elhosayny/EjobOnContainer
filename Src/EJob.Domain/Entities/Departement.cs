using EJob.Domain.Interfaces;

namespace EJob.Domain.Entities
{
    public class Departement: Entity
    {
        public string Name { get; set; }

        public Client Client { get; set; }
    }
}
