using MafraaHajeeraApi.Doamin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MafraaHajeeraApi.Conf;

public class NationalityConf : IEntityTypeConfiguration<Nationality>
{
    public void Configure(EntityTypeBuilder<Nationality> builder)
    {
        builder.HasData(new[]
{
    new Nationality { Id = 1, Name = "سوري" },
    new Nationality { Id = 2, Name = "فلسطيني" },
    new Nationality { Id = 3, Name = "مصري" },
    new Nationality { Id = 4, Name = "أردني" },
    new Nationality { Id = 5, Name = "لبناني" },
    new Nationality { Id = 6, Name = "عراقي" },
    new Nationality { Id = 7, Name = "سعودي" },
    new Nationality { Id = 8, Name = "إماراتي" },
    new Nationality { Id = 9, Name = "كويتي" },
    new Nationality { Id = 10, Name = "قطري" },
    new Nationality { Id = 11, Name = "بحريني" },
    new Nationality { Id = 12, Name = "عُماني" },
    new Nationality { Id = 13, Name = "يمني" },
    new Nationality { Id = 14, Name = "ليبي" },
    new Nationality { Id = 15, Name = "جزائري" },
    new Nationality { Id = 16, Name = "مغربي" },
    new Nationality { Id = 17, Name = "تونسي" },
    new Nationality { Id = 18, Name = "سوداني" },
    new Nationality { Id = 19, Name = "مورتاني" },
    new Nationality { Id = 20, Name = "صومالي" }
});

    }
}
