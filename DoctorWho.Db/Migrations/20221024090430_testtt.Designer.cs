﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20221024090430_testtt")]
    partial class testtt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Author1"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Author2"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Author3"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Author4"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Author5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Companion1",
                            WhoPayed = "Payer1"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Companion1",
                            WhoPayed = "Payer2"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Companion1",
                            WhoPayed = "Payer3"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Companion1",
                            WhoPayed = "Payer4"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Companion1",
                            WhoPayed = "Payer5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.CompanionEpisode", b =>
                {
                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("CompanionId", "EpisodeId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("CompanionsEpisodes");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            CompanionId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            CompanionId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "doctor1",
                            DoctorNumber = 11
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "doctor2",
                            DoctorNumber = 22
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "doctor3",
                            DoctorNumber = 33
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "doctor4",
                            DoctorNumber = 44
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "doctor5",
                            DoctorNumber = 55
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Describtion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Describtion = "o",
                            EnemyName = "Enemy1"
                        },
                        new
                        {
                            EnemyId = 2,
                            Describtion = "o",
                            EnemyName = "Enemy2"
                        },
                        new
                        {
                            EnemyId = 3,
                            Describtion = "o",
                            EnemyName = "Enemy3"
                        },
                        new
                        {
                            EnemyId = 4,
                            Describtion = "o",
                            EnemyName = "Enemy4"
                        },
                        new
                        {
                            EnemyId = 5,
                            Describtion = "o",
                            EnemyName = "Enemy5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EnemyEpisode", b =>
                {
                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EnemyId", "EpisodeId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EnemyEpisodes");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "o",
                            Notes = "oo",
                            SeriesNumber = 1,
                            Title = "1"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "o",
                            Notes = "oo",
                            SeriesNumber = 2,
                            Title = "1"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "o",
                            Notes = "oo",
                            SeriesNumber = 3,
                            Title = "1"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "o",
                            Notes = "oo",
                            SeriesNumber = 4,
                            Title = "1"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "o",
                            Notes = "oo",
                            SeriesNumber = 5,
                            Title = "1"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "companion")
                        .WithMany("CompanionEpisodes")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "episode")
                        .WithMany("CompanionEpisodes")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companion");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", null)
                        .WithMany("EnemyEpisodes")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", null)
                        .WithMany("EnemyEpisodes")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("CompanionEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("EnemyEpisodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("CompanionEpisodes");

                    b.Navigation("EnemyEpisodes");
                });
#pragma warning restore 612, 618
        }
    }
}
