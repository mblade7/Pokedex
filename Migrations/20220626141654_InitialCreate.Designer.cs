// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Pokedex.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220626141654_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

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

                    b.Property<string>("Type1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type2")
                        .HasColumnType("TEXT");

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
