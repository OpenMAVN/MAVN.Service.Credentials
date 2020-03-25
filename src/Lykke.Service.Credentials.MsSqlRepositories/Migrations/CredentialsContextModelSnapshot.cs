﻿// <auto-generated />
using System;
using Lykke.Service.Credentials.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.Credentials.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CredentialsContext))]
    partial class CredentialsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("credentials")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.AdminCredentialsEntity", b =>
                {
                    b.Property<string>("Login")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("login");

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnName("admin_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("Login");

                    b.ToTable("admin_credentials");
                });

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.CustomerCredentialsEntity", b =>
                {
                    b.Property<string>("Login")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("login");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("Login");

                    b.ToTable("customer_credentials");
                });

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.PartnerCredentialsEntity", b =>
                {
                    b.Property<string>("PartnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("partner_id")
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnName("client_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("PartnerId");

                    b.HasIndex("PartnerId")
                        .IsUnique();

                    b.ToTable("partner_credentials");
                });

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.PasswordResetEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnName("expires_at");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnName("identifier");

                    b.HasKey("CustomerId");

                    b.ToTable("password_reset");
                });

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.PinCodeEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnName("hash");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnName("salt");

                    b.HasKey("CustomerId");

                    b.ToTable("customer_pin_codes");
                });

            modelBuilder.Entity("Lykke.Service.Credentials.MsSqlRepositories.Entities.PinCodeEntity", b =>
                {
                    b.HasOne("Lykke.Service.Credentials.MsSqlRepositories.Entities.CustomerCredentialsEntity")
                        .WithOne("PinCode")
                        .HasForeignKey("Lykke.Service.Credentials.MsSqlRepositories.Entities.PinCodeEntity", "CustomerId")
                        .HasPrincipalKey("Lykke.Service.Credentials.MsSqlRepositories.Entities.CustomerCredentialsEntity", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
