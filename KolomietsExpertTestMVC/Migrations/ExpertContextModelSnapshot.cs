﻿// <auto-generated />
using System;
using KolomietsExpertTestMVC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KolomietsExpertTestMVC.Migrations
{
    [DbContext(typeof(ExpertContext))]
    partial class ExpertContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.FilmCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmCategories");
                });

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.FilmCategory", b =>
                {
                    b.HasOne("KolomietsExpertTestMVC.Entities.Category", "Category")
                        .WithMany("FilmCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KolomietsExpertTestMVC.Entities.Film", "Film")
                        .WithMany("FilmCategories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.Category", b =>
                {
                    b.Navigation("FilmCategories");
                });

            modelBuilder.Entity("KolomietsExpertTestMVC.Entities.Film", b =>
                {
                    b.Navigation("FilmCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
