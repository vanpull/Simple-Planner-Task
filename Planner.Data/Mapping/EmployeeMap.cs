using Planner.Core.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.Data.Mapping
{
    public partial class EmployeeMap : AppEntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.LastName)                
                .HasMaxLength(32);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Password)
                .IsRequired();                

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Phone).HasColumnName("Name");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
                       
            this.Ignore(t => t.FullName);

            this.HasRequired(p => p.Role)
                .WithMany()
                .HasForeignKey(p => p.RoleId);
        }
    }
}
