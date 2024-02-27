using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Concrete;
using VitHealth.Entities.EntityConfig.Abstract;

namespace VitHealth.Entities.EntityConfig.Concrete
{
    public class DoctorConfig : BaseConfig<Doctor, int>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DoctorName).HasMaxLength(50);
            builder.Property(p => p.DoctorSurname).HasMaxLength(50);
        }
    }
}
