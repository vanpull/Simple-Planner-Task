using Planner.Core.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.Data.Mapping
{
    /// <summary>
    /// Represents Role Table Mapping
    /// </summary>
    public partial class RoleMap : AppEntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("Role");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
