using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJob.Application.JobCQ.Command.AddJob;
using EJob.Application.JobCQ.Queries.GetAllJobs;
using EJob.Application.JobCQ.Queries.GetJobById;
using EJob.Application.ViewModels;
using EJob.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EJob.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class JobsController : Controller
    {
        private readonly IMediator _mediator;

        [HttpGet]
        public async Task<IEnumerable<JobViewModel>> Index()
        {
            var query = new GetAllJobsQuery();
            var jobs = await _mediator.Send(query);
            return jobs;
        }

        public JobsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetJobById(int id)
        {
            var query = new GetJobByIdQuery { Id = id };
            var job = await _mediator.Send(query);
            if (job == null) return BadRequest();
            return Ok(job);
        }

        [HttpPost]
        public async Task<ActionResult> AddJob(JobViewModel job)
        {
            if (job == null) return BadRequest();
            var command = new AddJobCommand();
            command.Job = job;
            var newJob = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetJobById),new {newJob.ID},newJob);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateJob(JobViewModel job)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            var job = await _mediator.Send(new DeleteJobCommand {Id =id });
            if (job == null) return BadRequest();
            return NoContent(); 
        }

        [HttpPost]
        [Route("upload")]
        public async Task<ActionResult> UploadFile(IFormFile file)
        {
            return Ok("OK");
        }


    }
}