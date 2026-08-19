using CitySimulation.Domain.Entities;
using CitySimulation.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimulation.Persistence.Seeds
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var cityId = Guid.NewGuid();

            var techCompanyId = Guid.NewGuid();
            var educationCompanyId = Guid.NewGuid();
            var healthCompanyId = Guid.NewGuid();

            var officeId = Guid.NewGuid();
            var schoolId = Guid.NewGuid();
            var hospitalId = Guid.NewGuid();

            var developerJobId = Guid.NewGuid();
            var managerJobId = Guid.NewGuid();
            var teacherJobId = Guid.NewGuid();
            var doctorJobId = Guid.NewGuid();
            var nurseJobId = Guid.NewGuid();

            var person1Id = Guid.NewGuid();
            var person2Id = Guid.NewGuid();
            var person3Id = Guid.NewGuid();
            var person4Id = Guid.NewGuid();
            var person5Id = Guid.NewGuid();
            var person6Id = Guid.NewGuid();
            var person7Id = Guid.NewGuid();
            var person8Id = Guid.NewGuid();
            var person9Id = Guid.NewGuid();
            var person10Id = Guid.NewGuid();

            // City
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = cityId,
                    Name = "Lviv"
                });

            // Companies
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = techCompanyId,
                    Name = "LvivTech",
                    Money = 100000,
                    CityId = cityId
                },
                new Company
                {
                    Id = educationCompanyId,
                    Name = "Lviv Education",
                    Money = 50000,
                    CityId = cityId
                },
                new Company
                {
                    Id = healthCompanyId,
                    Name = "Lviv Health",
                    Money = 150000,
                    CityId = cityId
                });

            // Workplaces
            modelBuilder.Entity<Workplace>().HasData(
                new Workplace
                {
                    Id = officeId,
                    Name = "Tech Office",
                    Capacity = 10,
                    CompanyId = techCompanyId
                },
                new Workplace
                {
                    Id = schoolId,
                    Name = "Lviv School",
                    Capacity = 5,
                    CompanyId = educationCompanyId
                },
                new Workplace
                {
                    Id = hospitalId,
                    Name = "City Hospital",
                    Capacity = 5,
                    CompanyId = healthCompanyId
                });

            // Jobs
            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = developerJobId,
                    Title = "Software Developer",
                    AnnualSalary = 3000,
                    WorkplaceId = officeId
                },
                new Job
                {
                    Id = managerJobId,
                    Title = "Project Manager",
                    AnnualSalary = 4000,
                    WorkplaceId = officeId
                },
                new Job
                {
                    Id = teacherJobId,
                    Title = "Teacher",
                    AnnualSalary = 2000,
                    WorkplaceId = schoolId
                },
                new Job
                {
                    Id = doctorJobId,
                    Title = "Doctor",
                    AnnualSalary = 4500,
                    WorkplaceId = hospitalId
                },
                new Job
                {
                    Id = nurseJobId,
                    Title = "Nurse",
                    AnnualSalary = 2500,
                    WorkplaceId = hospitalId
                });

            // People
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = person1Id,
                    Name = "Max",
                    Age = 22,
                    Gender = Gender.Male,
                    CityId = cityId,
                    JobId = developerJobId
                },
                new Person
                {
                    Id = person2Id,
                    Name = "Anna",
                    Age = 28,
                    Gender = Gender.Female,
                    CityId = cityId,
                    JobId = teacherJobId
                },
                new Person
                {
                    Id = person3Id,
                    Name = "John",
                    Age = 35,
                    Gender = Gender.Male,
                    CityId = cityId,
                    JobId = managerJobId
                },
                new Person
                {
                    Id = person4Id,
                    Name = "Emma",
                    Age = 31,
                    Gender = Gender.Female,
                    CityId = cityId,
                    JobId = doctorJobId
                },
                new Person
                {
                    Id = person5Id,
                    Name = "Alex",
                    Age = 25,
                    Gender = Gender.Male,
                    CityId = cityId,
                    JobId = nurseJobId
                },
                new Person
                {
                    Id = person6Id,
                    Name = "Sophie",
                    Age = 17,
                    Gender = Gender.Female,
                    CityId = cityId,
                    JobId = null
                },
                new Person
                {
                    Id = person7Id,
                    Name = "Daniel",
                    Age = 16,
                    Gender = Gender.Male,
                    CityId = cityId,
                    JobId = null
                },
                new Person
                {
                    Id = person8Id,
                    Name = "Olivia",
                    Age = 8,
                    Gender = Gender.Female,
                    CityId = cityId,
                    JobId = null
                },
                new Person
                {
                    Id = person9Id,
                    Name = "James",
                    Age = 67,
                    Gender = Gender.Male,
                    CityId = cityId,
                    JobId = null
                },
                new Person
                {
                    Id = person10Id,
                    Name = "Mia",
                    Age = 70,
                    Gender = Gender.Female,
                    CityId = cityId,
                    JobId = null
                });
        }
    }
}