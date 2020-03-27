﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(TeamBlueTestContext))]
    [Migration("20200327193446_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.UserInput", b =>
                {
                    b.Property<string>("DistinctText")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DistinctText");

                    b.HasIndex("DistinctText")
                        .IsUnique();

                    b.ToTable("UserInputs");
                });

            modelBuilder.Entity("Models.WatchListWord", b =>
                {
                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Word");

                    b.HasIndex("Word")
                        .IsUnique();

                    b.ToTable("WatchListWords");
                });
#pragma warning restore 612, 618
        }
    }
}