using Planner.Core.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.Data.Mapping
{
    /// <summary>
    /// Represents Status Table Mapping
    /// </summary>
    public partial class StatusMap : AppEntityTypeConfiguration<Status>
    {
        public StatusMap() 
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
            this.ToTable("Status");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
