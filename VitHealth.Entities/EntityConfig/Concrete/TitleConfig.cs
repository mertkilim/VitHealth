using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Concrete;
using VitHealth.Entities.EntityConfig.Abstract;

namespace VitHealth.Entities.EntityConfig.Concrete
{
    public class TitleConfig : BaseConfig<Title, int>
    {
        public override void Configure(EntityTypeBuilder<Title> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.TitleName).HasMaxLength(70);
        }
    }
}
