﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TennisDbContext))]
    [Migration("20240724203832_ScheduleBooking")]
    partial class ScheduleBooking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Entities.Booking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("ScheduleId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Court", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourtOrganizationId")
                        .HasColumnType("integer");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("SurfaceType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourtOrganizationId");

                    b.HasIndex("GameId");

                    b.ToTable("Courts");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("jsonb");

                    b.Property<string>("WebSiteLink")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("CourtOrganizations");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Friendship", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("FriendId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<List<int>>("CourtIds")
                        .HasColumnType("integer[]");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("integer");

                    b.Property<int>("Expectations")
                        .HasColumnType("integer");

                    b.Property<double>("GameLevelMax")
                        .HasColumnType("double precision");

                    b.Property<double>("GameLevelMin")
                        .HasColumnType("double precision");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TimeSlots")
                        .HasColumnType("jsonb");

                    b.Property<int?>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("WhoPays")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourtId")
                        .HasColumnType("integer");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("UserStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourtId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("GameOrders");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessLevel")
                        .HasColumnType("integer");

                    b.Property<int?>("CourtOrganizationId")
                        .HasColumnType("integer");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourtOrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("CourtId")
                        .HasColumnType("integer");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourtId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("AccountStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int?>("InterestsId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Occupation")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Sex")
                        .HasColumnType("integer");

                    b.Property<long>("TelegramId")
                        .HasColumnType("bigint");

                    b.Property<string>("TelegramUsername")
                        .HasColumnType("text");

                    b.Property<double?>("TennisLevel")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Booking", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Schedule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Court", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.CourtOrganization", "CourtOrganization")
                        .WithMany()
                        .HasForeignKey("CourtOrganizationId");

                    b.HasOne("Infrastructure.Data.Entities.Game", null)
                        .WithMany("Courts")
                        .HasForeignKey("GameId");

                    b.Navigation("CourtOrganization");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtOrganization", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Infrastructure.Data.Entities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.Navigation("City");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.District", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Game", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Infrastructure.Data.Entities.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.Navigation("City");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameOrder", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Court", "Court")
                        .WithMany()
                        .HasForeignKey("CourtId");

                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Court");

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Membership", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.CourtOrganization", "CourtOrganization")
                        .WithMany()
                        .HasForeignKey("CourtOrganizationId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("CourtOrganization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Schedule", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Court", "Court")
                        .WithMany()
                        .HasForeignKey("CourtId");

                    b.Navigation("Court");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Game", b =>
                {
                    b.Navigation("Courts");
                });
#pragma warning restore 612, 618
        }
    }
}
