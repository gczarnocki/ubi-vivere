using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HackathonServer.Models;

namespace HackathonServer.Migrations
{
    [DbContext(typeof(HackathonContext))]
    [Migration("20160924155202_Add_EducationFacilityDtos")]
    partial class Add_EducationFacilityDtos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HackathonServer.Dtos.EducationFacilityDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("FacilityType");

                    b.Property<string>("HomeNumber");

                    b.Property<string>("Name");

                    b.Property<string>("Postcode");

                    b.Property<string>("Street");

                    b.Property<string>("StreetNumber");

                    b.Property<string>("Telephone");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("EducationFacilityDtos");
                });

            modelBuilder.Entity("HackathonServer.Models.ExampleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Examples");
                });
        }
    }
}
