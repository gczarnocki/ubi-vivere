using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HackathonServer.Dtos;

namespace HackathonServer.Models
{
    public class HackathonContext : DbContext
    {
        public HackathonContext() : base("name=HackathonContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<EducationFacilityDto> EducationFacilities { get; set; }
    }
}