namespace EJob.Domain.Enumerations
{
    public enum JobStatus
    {
        WaitingValidation,
        ReadyToPrint,
        Printing,
        ReadyToFold,
        Folding,
        Disposed,
        Complete
    }
}
