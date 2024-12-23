﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnSight.Infra.Data;

#nullable disable

namespace OnSight.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241112175717_InstantSolutionDescriptionColumnAdded")]
    partial class InstantSolutionDescriptionColumnAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OnSight.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("char(8)")
                        .HasColumnName("cep");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("complement");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.HasKey("Id");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char(14)")
                        .HasColumnName("cnpj");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("trade_name");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.IndividualPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("char(9)")
                        .HasColumnName("rg");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("individual_persons");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.MetricCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("MetricDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("metric_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("metrics_categories");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.MetricHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("MetricCategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("metric_category_id");

                    b.Property<DateTime>("MetricDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("metric_date_time");

                    b.Property<decimal>("PercentualDelta")
                        .HasColumnType("numeric")
                        .HasColumnName("percentual_delta");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("MetricCategoryId");

                    b.ToTable("metric_histories");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.ServiceCall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid")
                        .HasColumnName("address_id");

                    b.Property<DateTime?>("ArrivalDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("arrival_date_time");

                    b.Property<DateTime?>("AttributionDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("attribution_date_time");

                    b.Property<string>("CallCode")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)")
                        .HasColumnName("call_code");

                    b.Property<int>("CallStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("call_status_id");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<DateTime?>("ConclusionDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("conclusion_date_time");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("contact_email");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)")
                        .HasColumnName("contact_phone_number");

                    b.Property<DateTime?>("CreationDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("creation_date_time");

                    b.Property<DateOnly?>("Deadline")
                        .HasColumnType("date")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("InstantSolutionDescription")
                        .HasColumnType("text")
                        .HasColumnName("instant-solution-description");

                    b.Property<bool>("IsRecurringCall")
                        .HasColumnType("boolean")
                        .HasColumnName("is_recurring_call");

                    b.Property<Guid?>("ResponsibleAttendantId")
                        .HasColumnType("uuid")
                        .HasColumnName("responsible_attendant_id");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("service_type_id");

                    b.Property<Guid?>("TechnicianId")
                        .HasColumnType("uuid")
                        .HasColumnName("technician_id");

                    b.Property<int?>("UrgencyStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("urgency_status_id");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ResponsibleAttendantId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("service_calls");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.Technician", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("IndividualPersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("individual_person_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("technician_status_id");

                    b.HasKey("Id");

                    b.HasIndex("IndividualPersonId");

                    b.ToTable("technicians");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.UnavailabilityRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_on");

                    b.Property<TimeOnly>("EstimatedDurationTime")
                        .HasColumnType("time without time zone")
                        .HasColumnName("estimated_duration_time");

                    b.Property<string>("ReasonDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("reason_description");

                    b.Property<Guid>("TechnicianId")
                        .HasColumnType("uuid")
                        .HasColumnName("technician_id");

                    b.HasKey("Id");

                    b.HasIndex("TechnicianId");

                    b.ToTable("unavailability_records");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_hash");

                    b.Property<string>("PasswordRecoverCode")
                        .HasColumnType("char(4)")
                        .HasColumnName("password_recover_code");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("password_salt");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("char(11)")
                        .HasColumnName("phone_number");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("profile_image_url");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("user_type_id");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.Client", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.IndividualPerson", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.MetricHistory", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.MetricCategory", "MetricCategory")
                        .WithMany()
                        .HasForeignKey("MetricCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MetricCategory");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.ServiceCall", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnSight.Domain.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnSight.Domain.Entities.IndividualPerson", "IndividualPerson")
                        .WithMany()
                        .HasForeignKey("ResponsibleAttendantId");

                    b.HasOne("OnSight.Domain.Entities.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId");

                    b.Navigation("Address");

                    b.Navigation("Client");

                    b.Navigation("IndividualPerson");

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.Technician", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.IndividualPerson", "IndividualPerson")
                        .WithMany()
                        .HasForeignKey("IndividualPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IndividualPerson");
                });

            modelBuilder.Entity("OnSight.Domain.Entities.UnavailabilityRecord", b =>
                {
                    b.HasOne("OnSight.Domain.Entities.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Technician");
                });
#pragma warning restore 612, 618
        }
    }
}
