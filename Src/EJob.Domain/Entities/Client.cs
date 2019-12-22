using EJob.Domain.Interfaces;
using System.Collections.Generic;

namespace EJob.Domain.Entities
{
    public class Client : Entity, IAggregateRoot
    {
        public int Name { get; set; }
        public ICollection<Departement> Departements { get; set; }
    }
}
