using AutoMapper;
using JobSearchEndProject.Models;
using JobSearchEndProject.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Job, JobsReturnDto>()
                .ForMember(x => x.Category
                    , o =>
                        o.MapFrom(x => x.Category.CategoryName))
                .ForMember(x => x.Country
                    , o =>
                        o.MapFrom(x => x.Country))
                 .ForMember(x => x.Country
                    , o =>
                        o.MapFrom(x => x.Country.CountryName))
                 .ForMember(x => x.City
                    , o =>
                        o.MapFrom(x => x.City.CityName))
                 .ForMember(x => x.AppUser
                    , o =>
                        o.MapFrom(x => x.AppUser.FullName));
        }

       
    }
}
