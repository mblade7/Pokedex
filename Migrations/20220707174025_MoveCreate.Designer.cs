﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Pokedex.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220707174025_MoveCreate")]
    partial class MoveCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Moves", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Accuracy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartPP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("Pokemon", b =>
                {
                    b.Property<int>("DexNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_ATK")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_DEF")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_HP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_SPC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Base_SPD")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Catch_Rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Japanese_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RedBlueDex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Type2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("YellowDex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DexNum");

                    b.ToTable("Pokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
