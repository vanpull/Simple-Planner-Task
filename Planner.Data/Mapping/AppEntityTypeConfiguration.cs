using System.Data.Entity.ModelConfiguration;

namespace Planner.Data.Mapping
{
    /// <summary>
    /// Base Entity Mapping
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AppEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected AppEntityTypeConfiguration()
        {
            PostInitialize();
        }
        protected virtual void PostInitialize()
        {

        }
    }
}
