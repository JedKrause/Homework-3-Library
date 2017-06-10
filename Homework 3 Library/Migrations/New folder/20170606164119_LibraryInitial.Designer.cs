using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Homework_3_Library.Data;

namespace Homework3Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20170606164119_LibraryInitial")]
    partial class LibraryInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Homework_3_Library.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("BookID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Homework_3_Library.Models.Patron", b =>
                {
                    b.Property<int>("PatronID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("MembershipDate");

                    b.HasKey("PatronID");

                    b.ToTable("Patron");
                });

            modelBuilder.Entity("Homework_3_Library.Models.Rental", b =>
                {
                    b.Property<int>("RentalID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookID");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("PatronID");

                    b.HasKey("RentalID");

                    b.HasIndex("BookID");

                    b.HasIndex("PatronID");

                    b.ToTable("Rental");
                });

            modelBuilder.Entity("Homework_3_Library.Models.Rental", b =>
                {
                    b.HasOne("Homework_3_Library.Models.Book", "Book")
                        .WithMany("Rentals")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Homework_3_Library.Models.Patron", "Patron")
                        .WithMany("Rentals")
                        .HasForeignKey("PatronID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
