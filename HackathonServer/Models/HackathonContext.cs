using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonServer.Dtos;
using Microsoft.EntityFrameworkCore;

namespace HackathonServer.Models
{
    public class HackathonContext : DbContext
    {
        public HackathonContext(DbContextOptions<HackathonContext> options) : base(options)
        {
            
        }

        public DbSet<ExampleModel> Examples { get; set; }
        public DbSet<EducationFacilityDto> EducationFacilityDtos { get; set; }
    }
}