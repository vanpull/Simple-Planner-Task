namespace Planner.Data.Migrations
{
    using Core.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// Db Migration Configuration
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<Planner.Data.PlannerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Planner.Data.PlannerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var statuses = new Status[]
            {
                new Status() { Id = 1, Name = "Assigned" },
                new Status() { Id = 2, Name = "InProgress" },
                new Status() { Id = 3, Name = "Deferred" },
                new Status() { Id = 4, Name = "Completed" },
                new Status() { Id = 5, Name = "Closed" }
            };
            context.Statuses.AddOrUpdate(statuses);

            var priorities = new Priority[]
            {
                new Priority() { Id = 1, Name = "Low" },
                new Priority() { Id = 2, Name = "Medium" },
                new Priority() { Id = 3, Name = "High" }
            };
            context.Priorities.AddOrUpdate(priorities);

            var roles = new Role[]
            {
                new Role() { Id = 1, Name = "Manager" },
                new Role() { Id = 2, Name = "Employee" }
            };

            context.Roles.AddOrUpdate(roles);


            var employees = new Employee[]
            {
                new Employee()
                    {
                        Id = 1,
                        FirstName = "Manager",
                        LastName = "1",
                        Phone = "9632587410",
                        Email = "manager@planner.com",
                        Password = "manager",
                        RoleId = 1
                    },
                new Employee()
                    {
                        Id = 2,
                        FirstName = "Employee",
                        LastName = "1",
                        Phone = "9874563210",
                        Email = "emp1@planner.com",
                        Password = "emp1",
                        RoleId = 2
                    },
                new Employee()
                    {
                        Id = 3,
                        FirstName = "Employee",
                        LastName = "2",
                        Phone = "9874563210",
                        Email = "emp2@planner.com",
                        Password = "emp2",
                        RoleId = 2
                    },
                new Employee()
                    {
                        Id = 4,
                        FirstName = "Employee",
                        LastName = "3",
                        Phone = "9513574260",
                        Email = "emp3@planner.com",
                        Password = "emp3",
                        RoleId = 2
                    },
                new Employee()
                    {
                        Id = 5,
                        FirstName = "Employee",
                        LastName = "4",
                        Phone = "9874521036",
                        Email = "emp4@planner.com",
                        Password = "emp4",
                        RoleId = 2
                    },

            };

            context.Employees.AddOrUpdate(employees);
        }
    }
}
