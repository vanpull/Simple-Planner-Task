using Planner.Core.Domain;
using Planner.Data.Mapping;
using Planner.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Planner.Data
{
    /// <summary>
    /// Represents Database Context for Planner Database
    /// </summary>
    public class PlannerContext : DbContext
    {
        public PlannerContext()
            : base("PlannerConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PlannerContext, Configuration>());
            //Database.SetInitializer<PlannerContext>(null);
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(AppEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
