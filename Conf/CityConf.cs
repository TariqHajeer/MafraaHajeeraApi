using MafraaHajeeraApi.Doamin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MafraaHajeeraApi.Conf;

public class CityConf : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasData(
    [
    new { Id = 1, Name = "دمشق" },
    new { Id = 2, Name = "ريف دمشق" },
    new { Id = 3, Name = "حمص" },
    new { Id = 4, Name = "حلب" },
    new { Id = 5, Name = "اللاذقية" },
    new { Id = 6, Name = "طرطوس" },
    new { Id = 7, Name = "حماة" },
    new { Id = 8, Name = "دير الزور" },
    new { Id = 9, Name = "الرقة" },
    new { Id = 10, Name = "درعا" },
    new { Id = 11, Name = "السويداء" },
    new { Id = 12, Name = "القنيطرة" },
    new { Id = 13, Name = "ادلب" },
    new { Id = 14, Name = "الحسكة" } // تمت إضافة محافظة الحسكة
    ]);
    }
}
