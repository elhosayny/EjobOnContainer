using MediatR;

namespace EJob.Application.JobServices.Queries.GetJobById
{
    public class GetJobByIdQuery : IRequest<JobViewModel>
    {
        public int Id { get; set; }
    }
}
