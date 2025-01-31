﻿// <auto-generated />
using System;
using MafraaHajeeraApi.Doamin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MafraaHajeeraApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Family", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string[]>("Committee")
                        .HasColumnType("text[]");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CurrentRegionDetails")
                        .HasColumnType("text");

                    b.Property<int>("CurrentRegionId")
                        .HasColumnType("integer");

                    b.Property<string>("Dept")
                        .HasColumnType("text");

                    b.Property<int>("FatherId")
                        .HasColumnType("integer");

                    b.Property<int>("HosunigType")
                        .HasColumnType("integer");

                    b.Property<int?>("MotherId")
                        .HasColumnType("integer");

                    b.Property<string>("MotherId1")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("OldRegionDetails")
                        .HasColumnType("text");

                    b.Property<int>("OldRegionId")
                        .HasColumnType("integer");

                    b.Property<string>("OtherAssistance")
                        .HasColumnType("text");

                    b.Property<string[]>("Priorities")
                        .HasColumnType("text[]");

                    b.Property<decimal?>("RentCost")
                        .HasColumnType("numeric");

                    b.Property<string>("Sponser")
                        .HasColumnType("text");

                    b.Property<string>("WhoSpend")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentRegionId");

                    b.HasIndex("FatherId");

                    b.HasIndex("MotherId1");

                    b.HasIndex("OldRegionId");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Father", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("BirthPalce")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("text");

                    b.Property<string>("FatherName")
                        .HasColumnType("text");

                    b.Property<string>("HealthStatus")
                        .HasColumnType("text");

                    b.Property<decimal?>("MonthlyIncome")
                        .HasColumnType("numeric");

                    b.Property<string>("MotherName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PersonalId")
                        .HasColumnType("text");

                    b.Property<string>("PrevousWork")
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNumberAndField")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Father");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FamilyId")
                        .HasColumnType("text");

                    b.Property<string>("FatherName")
                        .HasColumnType("text");

                    b.Property<string>("HealthStatus")
                        .HasColumnType("text");

                    b.Property<decimal?>("MonthlyIncom")
                        .HasColumnType("numeric");

                    b.Property<string>("MotherName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PersonalStatEnum")
                        .HasColumnType("integer");

                    b.Property<string>("Work")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "دمشق"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ريف دمشق"
                        },
                        new
                        {
                            Id = 3,
                            Name = "حمص"
                        },
                        new
                        {
                            Id = 4,
                            Name = "حلب"
                        },
                        new
                        {
                            Id = 5,
                            Name = "اللاذقية"
                        },
                        new
                        {
                            Id = 6,
                            Name = "طرطوس"
                        },
                        new
                        {
                            Id = 7,
                            Name = "حماة"
                        },
                        new
                        {
                            Id = 8,
                            Name = "دير الزور"
                        },
                        new
                        {
                            Id = 9,
                            Name = "الرقة"
                        },
                        new
                        {
                            Id = 10,
                            Name = "درعا"
                        },
                        new
                        {
                            Id = 11,
                            Name = "السويداء"
                        },
                        new
                        {
                            Id = 12,
                            Name = "القنيطرة"
                        },
                        new
                        {
                            Id = 13,
                            Name = "ادلب"
                        },
                        new
                        {
                            Id = 14,
                            Name = "الحسكة"
                        });
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Mother", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Ambition")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("BirthPalce")
                        .HasColumnType("text");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("text");

                    b.Property<string>("FatherName")
                        .HasColumnType("text");

                    b.Property<string>("HealthStatus")
                        .HasColumnType("text");

                    b.Property<decimal?>("MonthlyIncome")
                        .HasColumnType("numeric");

                    b.Property<string>("MotherName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NationalityId")
                        .HasColumnType("integer");

                    b.Property<string[]>("Phones")
                        .HasColumnType("text[]");

                    b.Property<string>("RegistrationNumberAndField")
                        .HasColumnType("text");

                    b.Property<string>("Work")
                        .HasColumnType("text");

                    b.Property<string>("WorkThatCanDo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Mothers");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "سوري"
                        },
                        new
                        {
                            Id = 2,
                            Name = "فلسطيني"
                        },
                        new
                        {
                            Id = 3,
                            Name = "مصري"
                        },
                        new
                        {
                            Id = 4,
                            Name = "أردني"
                        },
                        new
                        {
                            Id = 5,
                            Name = "لبناني"
                        },
                        new
                        {
                            Id = 6,
                            Name = "عراقي"
                        },
                        new
                        {
                            Id = 7,
                            Name = "سعودي"
                        },
                        new
                        {
                            Id = 8,
                            Name = "إماراتي"
                        },
                        new
                        {
                            Id = 9,
                            Name = "كويتي"
                        },
                        new
                        {
                            Id = 10,
                            Name = "قطري"
                        },
                        new
                        {
                            Id = 11,
                            Name = "بحريني"
                        },
                        new
                        {
                            Id = 12,
                            Name = "عُماني"
                        },
                        new
                        {
                            Id = 13,
                            Name = "يمني"
                        },
                        new
                        {
                            Id = 14,
                            Name = "ليبي"
                        },
                        new
                        {
                            Id = 15,
                            Name = "جزائري"
                        },
                        new
                        {
                            Id = 16,
                            Name = "مغربي"
                        },
                        new
                        {
                            Id = 17,
                            Name = "تونسي"
                        },
                        new
                        {
                            Id = 18,
                            Name = "سوداني"
                        },
                        new
                        {
                            Id = 19,
                            Name = "مورتاني"
                        },
                        new
                        {
                            Id = 20,
                            Name = "صومالي"
                        });
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 2,
                            Name = "حجيرة"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "الحسنية"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "نجهة"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Name = "خربة الورد"
                        });
                });

            modelBuilder.Entity("Family", b =>
                {
                    b.HasOne("MafraaHajeeraApi.Doamin.Region", "CurrentRegion")
                        .WithMany()
                        .HasForeignKey("CurrentRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Father", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MafraaHajeeraApi.Doamin.Mother", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherId1");

                    b.HasOne("MafraaHajeeraApi.Doamin.Region", "OldRegion")
                        .WithMany()
                        .HasForeignKey("OldRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentRegion");

                    b.Navigation("Father");

                    b.Navigation("Mother");

                    b.Navigation("OldRegion");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Child", b =>
                {
                    b.HasOne("Family", null)
                        .WithMany("children")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Mother", b =>
                {
                    b.HasOne("MafraaHajeeraApi.Doamin.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("MafraaHajeeraApi.Doamin.Region", b =>
                {
                    b.HasOne("MafraaHajeeraApi.Doamin.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Family", b =>
                {
                    b.Navigation("children");
                });
#pragma warning restore 612, 618
        }
    }
}
