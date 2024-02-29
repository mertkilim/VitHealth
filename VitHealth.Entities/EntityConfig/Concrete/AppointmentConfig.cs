using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VitHealth.Entities.Concrete;
using VitHealth.Entities.EntityConfig.Abstract;

namespace VitHealth.Entities.EntityConfig.Concrete
{
    public class AppointmentConfig : BaseConfig<Appointment, int>
    {
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);
        }
    }
}
