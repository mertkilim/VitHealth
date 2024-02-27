using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Concrete;
using VitHealth.Entities.EntityConfig.Abstract;

namespace VitHealth.Entities.EntityConfig.Concrete
{
    public class PatientConfig : BaseConfig<Patient, int>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.PatientName).HasMaxLength(50);
            builder.Property(p => p.PatientSurname).HasMaxLength(70);
            builder.Property(p => p.IdentificationNumber).HasMaxLength(11);
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.PhoneNumber).HasMaxLength(11);
        }

    }
}
