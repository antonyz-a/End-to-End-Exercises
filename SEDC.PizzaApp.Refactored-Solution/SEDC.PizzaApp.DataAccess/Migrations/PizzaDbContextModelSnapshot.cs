﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.PizzaApp.DataAccess;

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new { Id = 1, Email = "test@gmail.com", Message = "Siciliana was too salty this time", Name = "Too salty", UserId = 1 },
                        new { Id = 2, Email = "test@gmail.com", Message = "10 stars to the chef for the Mexicana", Name = "Exelent", UserId = 2 },
                        new { Id = 3, Email = "test@gmail.com", Message = "Check your cheff", Name = "I found a finger in your pizza", UserId = 2 }
                    );
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, UserId = 1 },
                        new { Id = 2, UserId = 1 },
                        new { Id = 3, UserId = 2 }
                    );
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("PizzaSize");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new { Id = 1, Image = "Kapri.png", Name = "Kapri", PizzaSize = 1, Price = 7.0 },
                        new { Id = 2, Image = "Kapri.png", Name = "Kapri", PizzaSize = 2, Price = 7.0 },
                        new { Id = 3, Image = "Kapri.png", Name = "Kapri", PizzaSize = 3, Price = 7.0 },
                        new { Id = 4, Image = "Peperoni.png", Name = "Peperoni", PizzaSize = 1, Price = 9.0 },
                        new { Id = 5, Image = "Peperoni.png", Name = "Peperoni", PizzaSize = 2, Price = 8.0 },
                        new { Id = 6, Image = "Peperoni.png", Name = "Peperoni", PizzaSize = 3, Price = 8.0 },
                        new { Id = 7, Image = "Margarita.png", Name = "Margarita", PizzaSize = 1, Price = 10.5 },
                        new { Id = 8, Image = "Margarita.png", Name = "Margarita", PizzaSize = 2, Price = 10.5 },
                        new { Id = 9, Image = "Margarita.png", Name = "Margarita", PizzaSize = 3, Price = 10.5 },
                        new { Id = 10, Image = "Siciliana.png", Name = "Siciliana", PizzaSize = 1, Price = 6.5 },
                        new { Id = 11, Image = "Siciliana.png", Name = "Siciliana", PizzaSize = 2, Price = 9.5 },
                        new { Id = 12, Image = "Siciliana.png", Name = "Siciliana", PizzaSize = 3, Price = 9.5 }
                    );
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.PizzaOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("PizzaId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaOrder");

                    b.HasData(
                        new { Id = 1, OrderId = 1, PizzaId = 1 },
                        new { Id = 2, OrderId = 1, PizzaId = 4 },
                        new { Id = 3, OrderId = 2, PizzaId = 1 },
                        new { Id = 4, OrderId = 2, PizzaId = 5 },
                        new { Id = 5, OrderId = 2, PizzaId = 7 },
                        new { Id = 6, OrderId = 3, PizzaId = 5 },
                        new { Id = 7, OrderId = 3, PizzaId = 9 },
                        new { Id = 8, OrderId = 3, PizzaId = 12 }
                    );
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<long>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Address = "Bob street", FirstName = "Bob", LastName = "Bobski", Phone = 3565645546567L },
                        new { Id = 2, Address = "Jill street", FirstName = "Jill", LastName = "Wayne", Phone = 3565645546123L }
                    );
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.Feedback", b =>
                {
                    b.HasOne("SEDC.PizzaApp.Domain.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.Order", b =>
                {
                    b.HasOne("SEDC.PizzaApp.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.PizzaApp.Domain.Models.PizzaOrder", b =>
                {
                    b.HasOne("SEDC.PizzaApp.Domain.Models.Order", "Order")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEDC.PizzaApp.Domain.Models.Pizza", "Pizza")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
