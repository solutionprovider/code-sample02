﻿using HRM.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.API.Db
{
    public class SeedDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HRMContext(
                serviceProvider.GetRequiredService<DbContextOptions<HRMContext>>()))
            {
                // Check any employee exists 
                if (context.Employees.Any())
                {
                    return; // Data already exists no need to generate
                }

                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Abdur Rehman",
                        Designation = "Software Development",
                        FathersName = "Saeed Iqbal",
                        MothersName = "",
                        DateOfBirth = new DateTime(1984, 12, 19, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Muzammal Shafique",
                        Designation = "System Administrator",
                        FathersName = " ",
                        MothersName = " ",
                        DateOfBirth = new DateTime(1990, 10, 29, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Muhammad Usama is Good Boy",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2017, 09, 17, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Humaira Hasan]]]",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2021, 03, 17, 00, 00, 00)
                    }
                );
                context.SaveChanges();

            }
        }
    }
}
