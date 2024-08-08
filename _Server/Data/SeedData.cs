using Microsoft.EntityFrameworkCore;
using RuslanPR_Library.Models;

namespace RuslanPR_Server.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.Migrate();

            // Seed Projects
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        Name = "Project 1",
                        Description = "Description for project 1"
                    },
                    new Project
                    {
                        Name = "Project 2",
                        Description = "Description for project 2"
                    }
                );
            }

            // Seed Orders
            if (!context.Orders.Any())
            {
                context.Orders.AddRange(
                    new Order
                    {
                        Status =  "In Progress",
                        Description = "Order 1"
                    },
                    new Order
                    {
                        Status = "Completed",
                        Description = "Order 2"
                    }
                );
            }

            context.SaveChanges();
        }
    }
}