using System;
using MafraaHajeeraApi.Doamin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MafraaHajeeraApi.Conf;

public class RegionConf : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.HasData(new[]
{
    new { Id = 1, Name = "حجيرة", CityId = 2 },
    new { Id = 2, Name = "الحسنية", CityId = 2 },
    new { Id = 3, Name = "نجهة", CityId = 2 },
    new { Id = 4, Name = "خربة الورد", CityId = 2 },
        });

    }
}
