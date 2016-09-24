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
            Database.SetInitializer<HackathonContext>(new DropCreateDatabaseAlways<HackathonContext>());
            InitializeDatabase();
        }

        public HackathonContext(string connectionString) : base(connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!Database.Exists())
            {
                Database.Initialize(true);
                DatabaseInitializer.Seed(this);
            }
        }

        public virtual DbSet<EducationFacilityDto> EducationFacilities { get; set; }

        public virtual DbSet<BusStopDto> BusStops { get; set; }
    }
}