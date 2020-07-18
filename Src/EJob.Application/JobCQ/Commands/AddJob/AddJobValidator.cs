using FluentValidation;

namespace EJob.Application.JobCQ.Command.AddJob
{
    public class AddJobValidator: AbstractValidator<AddJobCommand>
    {
        public AddJobValidator()
        {
            RuleFor(v => v.Job.Name).NotEmpty();
            //RuleFor(v => v.Job.PageCount).NotEmpty();
            //RuleFor(v => v.Job.SheetCount).NotEmpty();
            //RuleFor(v => v.Job.CustomerCount).NotEmpty();
        }
    }
}
