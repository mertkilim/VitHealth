using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Abstract;

namespace VitHealth.Entities.EntityConfig.Abstract
{
    public abstract class BaseConfig<T, TId> : IEntityTypeConfiguration<T> where T : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property<DateTime>(p => p.CreateDate).HasDefaultValue((DateTime.UtcNow));
        }
    }
}
