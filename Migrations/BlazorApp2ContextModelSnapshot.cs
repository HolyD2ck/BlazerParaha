﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp2.Migrations
{
    [DbContext(typeof(BlazorApp2Context))]
    partial class BlazorApp2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp2.Models.Posetitel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Возраст")
                        .HasColumnType("int");

                    b.Property<string>("Имя")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Комната")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Мини_бар")
                        .HasColumnType("bit");

                    b.Property<string>("Отчество")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Питомец")
                        .HasColumnType("bit");

                    b.Property<string>("Размер_багажа")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Судимость")
                        .HasColumnType("bit");

                    b.Property<string>("Фамилия")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Фото")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Posetitel");
                });

            modelBuilder.Entity("BlazorApp2.Models.Rabotnik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Возраст")
                        .HasColumnType("int");

                    b.Property<string>("Должность")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Имя")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Образование")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Отчество")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Планета_происхождения")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Рост")
                        .HasColumnType("int");

                    b.Property<int>("Стаж")
                        .HasColumnType("int");

                    b.Property<string>("Фамилия")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Фото")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Rabotnik");
                });
#pragma warning restore 612, 618
        }
    }
}