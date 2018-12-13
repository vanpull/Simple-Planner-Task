using Planner.Core.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.Data.Mapping
{
    public partial class TaskMap : AppEntityTypeConfiguration<Task>
    {
        /// <summary>
        /// Represents Task Table Mapping
        /// </summary>
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Description)
                .HasMaxLength(500);

            this.Property(t => t.StartDate)
                .HasColumnType("datetime2");

            this.Property(t => t.EndDate)
                .HasColumnType("datetime2");

            this.Property(t => t.CreatedOn)
                .HasColumnType("datetime2");

            // Table & Column Mappings
            this.ToTable("Task");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.EstimatedTime).HasColumnName("EstimatedTime");
            this.Property(t => t.ActualTime).HasColumnName("ActualTime");


            this.HasOptional(p => p.TaskPriority)
                .WithMany()
                .HasForeignKey(p => p.Priority);

            this.HasOptional(p => p.TaskStatus)
                .WithMany()
                .HasForeignKey(p => p.Status);

            this.HasOptional(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.AssignedTo);

            this.HasOptional(p => p.Manager)
                .WithMany()
                .HasForeignKey(p => p.AssignedBy);

            this.Ignore(a => a.EmployeeName);
            this.Ignore(a => a.ManagerName);
            this.Ignore(a => a.TaskStatusName);
        }
    }
}
