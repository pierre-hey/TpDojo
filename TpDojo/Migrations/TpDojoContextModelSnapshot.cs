// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TpDojo.Data;

#nullable disable

namespace TpDojo.Migrations
{
    [DbContext(typeof(TpDojoContext))]
    partial class TpDojoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BO.Arme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Degat")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arme");
                });

            modelBuilder.Entity("BO.ArtMartial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ArtMartial");
                });

            modelBuilder.Entity("BO.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArmeId")
                        .HasColumnType("int");

                    b.Property<int>("Force")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArmeId")
                        .IsUnique()
                        .HasFilter("[ArmeId] IS NOT NULL");

                    b.ToTable("Samurai");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Force = 1724,
                            Nom = "Abe Masakatsu"
                        },
                        new
                        {
                            Id = 2,
                            Force = 38,
                            Nom = "Adachi Yasumori"
                        },
                        new
                        {
                            Id = 3,
                            Force = 1682,
                            Nom = "Adachi Kagemori"
                        },
                        new
                        {
                            Id = 4,
                            Force = 1301,
                            Nom = "Adams William"
                        },
                        new
                        {
                            Id = 5,
                            Force = 340,
                            Nom = "Aiou Mototsuna"
                        },
                        new
                        {
                            Id = 6,
                            Force = 1563,
                            Nom = "Akai Terukage"
                        },
                        new
                        {
                            Id = 7,
                            Force = 713,
                            Nom = "Akao Kiyotsuna"
                        },
                        new
                        {
                            Id = 8,
                            Force = 592,
                            Nom = "Akechi Mitsuhide"
                        },
                        new
                        {
                            Id = 9,
                            Force = 1429,
                            Nom = "Akiyama Nobutomo"
                        },
                        new
                        {
                            Id = 10,
                            Force = 665,
                            Nom = "Chiba Shusaku Narimasa"
                        },
                        new
                        {
                            Id = 11,
                            Force = 1714,
                            Nom = "Chōsokabe Morichika"
                        },
                        new
                        {
                            Id = 12,
                            Force = 220,
                            Nom = "Chōsokabe Kunichika"
                        },
                        new
                        {
                            Id = 13,
                            Force = 1854,
                            Nom = "Chōsokabe Motochika"
                        },
                        new
                        {
                            Id = 14,
                            Force = 1242,
                            Nom = "Chōsokabe Nobuchika"
                        },
                        new
                        {
                            Id = 15,
                            Force = 148,
                            Nom = "Collache Eugène"
                        },
                        new
                        {
                            Id = 16,
                            Force = 1129,
                            Nom = "Date Masamune"
                        },
                        new
                        {
                            Id = 17,
                            Force = 1450,
                            Nom = "Honda Tadatomo"
                        },
                        new
                        {
                            Id = 18,
                            Force = 1557,
                            Nom = "Honganji Kennyo"
                        },
                        new
                        {
                            Id = 19,
                            Force = 1958,
                            Nom = "Horio Yoshiharu"
                        },
                        new
                        {
                            Id = 20,
                            Force = 519,
                            Nom = "Hosokawa Fujitaka"
                        },
                        new
                        {
                            Id = 21,
                            Force = 1928,
                            Nom = "Imai Kanehira"
                        },
                        new
                        {
                            Id = 22,
                            Force = 213,
                            Nom = "Inaba Yoshimichi"
                        },
                        new
                        {
                            Id = 23,
                            Force = 799,
                            Nom = "Inugami Nagayasu"
                        },
                        new
                        {
                            Id = 24,
                            Force = 1337,
                            Nom = "Ishida Mitsunari"
                        },
                        new
                        {
                            Id = 25,
                            Force = 351,
                            Nom = "Isshiki Fujinaga"
                        },
                        new
                        {
                            Id = 26,
                            Force = 773,
                            Nom = "Itagaki Nobukata"
                        },
                        new
                        {
                            Id = 27,
                            Force = 772,
                            Nom = "Itō Hirobumi"
                        },
                        new
                        {
                            Id = 28,
                            Force = 140,
                            Nom = "Iwanari Tomomichi"
                        },
                        new
                        {
                            Id = 29,
                            Force = 1473,
                            Nom = "Jinbo Nagamoto"
                        },
                        new
                        {
                            Id = 30,
                            Force = 1460,
                            Nom = "Jonas Tönse"
                        },
                        new
                        {
                            Id = 31,
                            Force = 665,
                            Nom = "Kannan Kumar(Salem)"
                        },
                        new
                        {
                            Id = 32,
                            Force = 1108,
                            Nom = "Kakeda Toshimune"
                        },
                        new
                        {
                            Id = 33,
                            Force = 1686,
                            Nom = "Maeda Matsu"
                        },
                        new
                        {
                            Id = 34,
                            Force = 1455,
                            Nom = "Maeda Nagatane"
                        },
                        new
                        {
                            Id = 35,
                            Force = 1627,
                            Nom = "Maeda Toshiie"
                        },
                        new
                        {
                            Id = 36,
                            Force = 911,
                            Nom = "Maeda Toshinaga"
                        },
                        new
                        {
                            Id = 37,
                            Force = 645,
                            Nom = "Maeda Toshitsune"
                        },
                        new
                        {
                            Id = 38,
                            Force = 1308,
                            Nom = "Magome Kageyu"
                        },
                        new
                        {
                            Id = 39,
                            Force = 1580,
                            Nom = "Manabe Akifusa"
                        },
                        new
                        {
                            Id = 40,
                            Force = 975,
                            Nom = "Matsudaira Katamori"
                        },
                        new
                        {
                            Id = 41,
                            Force = 43,
                            Nom = "Matsudaira Nobutsuna"
                        },
                        new
                        {
                            Id = 42,
                            Force = 1585,
                            Nom = "Matsudaira Nobuyasu"
                        },
                        new
                        {
                            Id = 43,
                            Force = 941,
                            Nom = "Matsudaira Higo no Kami Katamori"
                        },
                        new
                        {
                            Id = 44,
                            Force = 823,
                            Nom = "Matsudaira Sadanobu"
                        },
                        new
                        {
                            Id = 45,
                            Force = 931,
                            Nom = "Miura Anjin"
                        },
                        new
                        {
                            Id = 46,
                            Force = 1644,
                            Nom = "Miura Yoshimoto"
                        },
                        new
                        {
                            Id = 47,
                            Force = 500,
                            Nom = "Miyamoto Musashi"
                        },
                        new
                        {
                            Id = 48,
                            Force = 1825,
                            Nom = "Miyoshi Chōkei"
                        },
                        new
                        {
                            Id = 49,
                            Force = 1816,
                            Nom = "Miyoshi Kazuhide"
                        },
                        new
                        {
                            Id = 50,
                            Force = 928,
                            Nom = "Mōri Okimoto"
                        },
                        new
                        {
                            Id = 51,
                            Force = 786,
                            Nom = "Mori Ranmaru"
                        },
                        new
                        {
                            Id = 52,
                            Force = 430,
                            Nom = "Mōri Takamoto"
                        },
                        new
                        {
                            Id = 53,
                            Force = 1720,
                            Nom = "Mori Tadamasa"
                        },
                        new
                        {
                            Id = 54,
                            Force = 562,
                            Nom = "Mōri Terumoto"
                        },
                        new
                        {
                            Id = 55,
                            Force = 767,
                            Nom = "Mori Yoshinari"
                        },
                        new
                        {
                            Id = 56,
                            Force = 421,
                            Nom = "Murai Sadakatsu"
                        },
                        new
                        {
                            Id = 57,
                            Force = 1891,
                            Nom = "Nagakura Shinpachi"
                        },
                        new
                        {
                            Id = 58,
                            Force = 1981,
                            Nom = "Saitō Hajime"
                        },
                        new
                        {
                            Id = 59,
                            Force = 915,
                            Nom = "Saito Musashibō Benkei"
                        },
                        new
                        {
                            Id = 60,
                            Force = 464,
                            Nom = "Saitō Yoshitatsu"
                        },
                        new
                        {
                            Id = 61,
                            Force = 1800,
                            Nom = "Sakai Tadakiyo"
                        },
                        new
                        {
                            Id = 62,
                            Force = 1239,
                            Nom = "Sakai Tadashige"
                        },
                        new
                        {
                            Id = 63,
                            Force = 1415,
                            Nom = "Sakai Tadatsugu"
                        },
                        new
                        {
                            Id = 64,
                            Force = 1889,
                            Nom = "Sakai Tadayo"
                        },
                        new
                        {
                            Id = 65,
                            Force = 915,
                            Nom = "Shimazu Takahisa"
                        },
                        new
                        {
                            Id = 66,
                            Force = 1429,
                            Nom = "Shimazu Toyohisa"
                        },
                        new
                        {
                            Id = 67,
                            Force = 930,
                            Nom = "Shimazu Yoshihiro"
                        },
                        new
                        {
                            Id = 68,
                            Force = 171,
                            Nom = "Shimazu Yoshihisa"
                        },
                        new
                        {
                            Id = 69,
                            Force = 1201,
                            Nom = "Shindou Hiroshii"
                        },
                        new
                        {
                            Id = 70,
                            Force = 144,
                            Nom = "Sogo Nagayasu"
                        },
                        new
                        {
                            Id = 71,
                            Force = 840,
                            Nom = "Sue Yoshitaka"
                        },
                        new
                        {
                            Id = 72,
                            Force = 1318,
                            Nom = "Tachibana Muneshige"
                        },
                        new
                        {
                            Id = 73,
                            Force = 1195,
                            Nom = "Tachibana Dōsetsu"
                        },
                        new
                        {
                            Id = 74,
                            Force = 1187,
                            Nom = "Tachibana Ginchiyo"
                        },
                        new
                        {
                            Id = 75,
                            Force = 1194,
                            Nom = "Taigen Sessai"
                        },
                        new
                        {
                            Id = 76,
                            Force = 1559,
                            Nom = "Taira no Kiyomori"
                        },
                        new
                        {
                            Id = 77,
                            Force = 158,
                            Nom = "Taira Masakado"
                        },
                        new
                        {
                            Id = 78,
                            Force = 666,
                            Nom = "Takahashi Shigetane"
                        },
                        new
                        {
                            Id = 79,
                            Force = 1046,
                            Nom = "Takenaka Shigeharu"
                        },
                        new
                        {
                            Id = 80,
                            Force = 1847,
                            Nom = "Takasugi Shinsaku"
                        },
                        new
                        {
                            Id = 81,
                            Force = 234,
                            Nom = "Takayama Justo"
                        },
                        new
                        {
                            Id = 82,
                            Force = 177,
                            Nom = "Takayama Ukon"
                        },
                        new
                        {
                            Id = 83,
                            Force = 1333,
                            Nom = "Ukita Okiie"
                        },
                        new
                        {
                            Id = 84,
                            Force = 382,
                            Nom = "Umezawa Michiharu"
                        },
                        new
                        {
                            Id = 85,
                            Force = 40,
                            Nom = "Usami Sadamitsu"
                        },
                        new
                        {
                            Id = 86,
                            Force = 1536,
                            Nom = "Yamanaka Yukimori"
                        },
                        new
                        {
                            Id = 87,
                            Force = 1519,
                            Nom = "Yamanami Keisuke"
                        },
                        new
                        {
                            Id = 88,
                            Force = 138,
                            Nom = "Yamaoka Tesshū"
                        },
                        new
                        {
                            Id = 89,
                            Force = 883,
                            Nom = "Yanagawa Kenzaburo"
                        },
                        new
                        {
                            Id = 90,
                            Force = 1389,
                            Nom = "Yanagisawa Yoshiyasu"
                        },
                        new
                        {
                            Id = 91,
                            Force = 715,
                            Nom = "Yonekura Shigetsugu"
                        },
                        new
                        {
                            Id = 92,
                            Force = 1585,
                            Nom = "Yūki Hideyasu"
                        },
                        new
                        {
                            Id = 93,
                            Force = 534,
                            Nom = "Yasuke"
                        });
                });

            modelBuilder.Entity("SamuraiArt", b =>
                {
                    b.Property<int>("ArtMartiauxId")
                        .HasColumnType("int");

                    b.Property<int>("SamuraisId")
                        .HasColumnType("int");

                    b.HasKey("ArtMartiauxId", "SamuraisId");

                    b.HasIndex("SamuraisId");

                    b.ToTable("SamuraiArt");
                });

            modelBuilder.Entity("BO.Samurai", b =>
                {
                    b.HasOne("BO.Arme", "Arme")
                        .WithOne("Samurai")
                        .HasForeignKey("BO.Samurai", "ArmeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Arme");
                });

            modelBuilder.Entity("SamuraiArt", b =>
                {
                    b.HasOne("BO.ArtMartial", null)
                        .WithMany()
                        .HasForeignKey("ArtMartiauxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BO.Samurai", null)
                        .WithMany()
                        .HasForeignKey("SamuraisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BO.Arme", b =>
                {
                    b.Navigation("Samurai");
                });
#pragma warning restore 612, 618
        }
    }
}
