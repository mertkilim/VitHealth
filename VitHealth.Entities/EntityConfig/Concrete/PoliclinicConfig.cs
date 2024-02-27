using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Concrete;
using VitHealth.Entities.EntityConfig.Abstract;

namespace VitHealth.Entities.EntityConfig.Concrete
{
    public class PoliclinicConfig : BaseConfig<Policlinic, int>
    {
        public override void Configure(EntityTypeBuilder<Policlinic> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.PoliclinicName).HasMaxLength(100);
        }
    }
}
