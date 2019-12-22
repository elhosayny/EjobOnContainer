using EJob.Domain.Enumerations;
using EJob.Domain.Interfaces;

namespace EJob.Domain.Entities
{
    public class Document : Entity, IAggregateRoot
    {

        public string Name { get; set; }

        public DocuemntSendingMode DocuemntSendingMode { get; set; }

        public ColorMode ColorMode { get; set; }

        public PrintingMode PrintingMode { get; set; }

        public bool HasAdvertisingInsert { get; set; }

        public JobPipline JobPipline { get; set; }

        public Paper Paper { get; set; }

        public Envelope Envelope { get; set; }

        public int ProcessingDays { get; private set; }
        public int ProductionDays { get; private set; }

    }
}
