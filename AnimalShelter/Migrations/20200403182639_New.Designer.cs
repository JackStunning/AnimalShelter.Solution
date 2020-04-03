﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Solution.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20200403182639_New")]
    partial class New
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnimalName");

                    b.Property<string>("Gender");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            AnimalName = "Burger",
                            Gender = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            AnimalName = "Hotdog",
                            Gender = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            AnimalName = "Slinko",
                            Gender = "Male",
                            Species = "Snake"
                        },
                        new
                        {
                            AnimalId = 4,
                            AnimalName = "Larry",
                            Gender = "Male",
                            Species = "Bird"
                        },
                        new
                        {
                            AnimalId = 5,
                            AnimalName = "Shelly",
                            Gender = "Female",
                            Species = "Turtle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
