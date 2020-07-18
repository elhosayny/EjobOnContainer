using AutoMapper;
using EJob.Application.ViewModels;
using EJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJob.Application.Mappings
{
    public class JobProfile : Profile
    {
        public JobProfile()
        {
            CreateMap<JobViewModel, Job>().ReverseMap();
        }
    }
}
