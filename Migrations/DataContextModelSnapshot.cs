﻿// <auto-generated />
using System;
using HRMangementApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMangementApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRMangementApi.Models.ApproveRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("ApproveRequests");
                });

            modelBuilder.Entity("HRMangementApi.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaveBalanceId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeaveBalanceId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HRMangementApi.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Extenstion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeOffRequestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeOffRequestId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("HRMangementApi.Models.LeaveBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("leaveBalances");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeOffPolicyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeOffPolicyId");

                    b.ToTable("TimeOffCategories");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TimeOffPolicies");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApproveRequestId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApproveRequestId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TimeOffRequests");
                });

            modelBuilder.Entity("HRMangementApi.Models.Manager", b =>
                {
                    b.HasBaseType("HRMangementApi.Models.Employee");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("HRMangementApi.Models.ApproveRequests", b =>
                {
                    b.HasOne("HRMangementApi.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("HRMangementApi.Models.Employee", b =>
                {
                    b.HasOne("HRMangementApi.Models.LeaveBalance", "LeaveBalance")
                        .WithMany()
                        .HasForeignKey("LeaveBalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMangementApi.Models.Manager", "Manager")
                        .WithMany("Employees")
                        .HasForeignKey("ManagerId");

                    b.Navigation("LeaveBalance");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("HRMangementApi.Models.File", b =>
                {
                    b.HasOne("HRMangementApi.Models.TimeOffRequest", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TimeOffRequestId");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffCategory", b =>
                {
                    b.HasOne("HRMangementApi.Models.TimeOffPolicy", "TimeOffPolicy")
                        .WithMany("Categories")
                        .HasForeignKey("TimeOffPolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeOffPolicy");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffRequest", b =>
                {
                    b.HasOne("HRMangementApi.Models.ApproveRequests", "ApproveRequest")
                        .WithMany("TimeOffRequest")
                        .HasForeignKey("ApproveRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMangementApi.Models.TimeOffCategory", "Category")
                        .WithMany("Requests")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApproveRequest");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HRMangementApi.Models.ApproveRequests", b =>
                {
                    b.Navigation("TimeOffRequest");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffCategory", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffPolicy", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("HRMangementApi.Models.TimeOffRequest", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("HRMangementApi.Models.Manager", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}