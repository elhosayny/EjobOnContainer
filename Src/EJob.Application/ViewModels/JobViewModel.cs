using EJob.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EJob.Application.ViewModels
{
    public class JobViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DocumentId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime ProcessingDate { get; set; }
        public DateTime ValidationDate { get; set; }
        public int PageCount { get; set; }
        public int CustomerCount { get; set; }
        public int SheetCount { get; set; }
        public string PrintingFlowPath { get; set; }
        public int CustomProcessingDays { get; private set; }
        public int CustomProductionDays { get; private set; }
    }
}
