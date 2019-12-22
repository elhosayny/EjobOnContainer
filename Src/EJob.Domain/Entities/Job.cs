using EJob.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace EJob.Domain.Entities
{
    public class Job : Entity, IAggregateRoot
    {
        public Job()
        {
            Spools = new HashSet<Spool>();
        }

        public string Name { get; set; }
        public Document Document { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime ProcessingDate { get; set; }
        public DateTime ValidationDate { get; set; }
        public int PageCount { get; set; }
        public int CustomerCount { get; set; }
        public int SheetCount { get; set; }
        public string PrintingFlowPath { get; set; }
        public int CustomProcessingDays { get; private set; }
        public int CustomProductionDays { get; private set; }
        public ICollection<Spool> Spools { get; private set; }
    }
}
