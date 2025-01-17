﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TennisDbContext))]
    [Migration("20240910190550_bookingScheduleIdAdded")]
    partial class bookingScheduleIdAdded
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

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.BookingSchedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<long>("ScheduleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("BookingSchedule");
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

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<int>("SurfaceType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourtOrganizationId");

                    b.ToTable("Courts");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("SiteLink")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("CourtDictionaries");
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

                    b.Property<string>("Metro")
                        .HasColumnType("text");

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

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtReview", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int?>("CourtOrganizationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int[]>("Disappointments")
                        .HasColumnType("integer[]");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<long?>("ReviewerId")
                        .HasColumnType("bigint");

                    b.Property<int[]>("Satisfactions")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("CourtOrganizationId");

                    b.HasIndex("GameId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("CourtReviews");
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

                    b.Property<long?>("FriendId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int?>("CourtOrganizationId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Expectations")
                        .HasColumnType("integer");

                    b.Property<double?>("GameLevelMax")
                        .HasColumnType("double precision");

                    b.Property<double?>("GameLevelMin")
                        .HasColumnType("double precision");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TimeSlots")
                        .HasColumnType("jsonb");

                    b.Property<int?>("Type")
                        .HasColumnType("integer");

                    b.Property<long?>("UpdateUserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("WhoPays")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourtOrganizationId");

                    b.HasIndex("UpdateUserId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("Action")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("UserStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GamesHistory");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("UserStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("GameOrders");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<string>("Controller")
                        .HasColumnType("text");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int?>("LogLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Request")
                        .HasColumnType("jsonb");

                    b.Property<string>("Response")
                        .HasColumnType("jsonb");

                    b.Property<string>("Service")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Logs");
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

            modelBuilder.Entity("Infrastructure.Data.Entities.Notification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Action")
                        .HasColumnType("integer");

                    b.Property<bool>("IsSent")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TelegramId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("CourtId")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time without time zone");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourtId");

                    b.ToTable("Schedules");
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

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int?>("CourtDictionaryId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FirstStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HomeCourt")
                        .HasColumnType("text");

                    b.Property<int?>("HowOftenPlay")
                        .HasColumnType("integer");

                    b.Property<bool?>("IsRegistered")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLogInDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Occupation")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("jsonb");

                    b.Property<DateTime?>("RegistrationDate")
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

                    b.HasIndex("CityId");

                    b.HasIndex("CourtDictionaryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBookings");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserInterest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("InterestId")
                        .HasColumnType("integer");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInterests");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserReview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("GameId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<long?>("ReviewedPlayerId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReviewerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("ReviewedPlayerId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("UserReviews");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.BookingSchedule", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Entities.Schedule", null)
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Court", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.CourtOrganization", "CourtOrganization")
                        .WithMany()
                        .HasForeignKey("CourtOrganizationId");

                    b.Navigation("CourtOrganization");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtDictionary", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
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

            modelBuilder.Entity("Infrastructure.Data.Entities.CourtReview", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.CourtOrganization", "CourtOrganization")
                        .WithMany()
                        .HasForeignKey("CourtOrganizationId");

                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("Infrastructure.Data.Entities.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");

                    b.Navigation("CourtOrganization");

                    b.Navigation("Game");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.District", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Friendship", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.User", "Friend")
                        .WithMany()
                        .HasForeignKey("FriendId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Friend");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Game", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.CourtOrganization", "CourtOrganization")
                        .WithMany()
                        .HasForeignKey("CourtOrganizationId");

                    b.HasOne("Infrastructure.Data.Entities.User", "UpdateUser")
                        .WithMany()
                        .HasForeignKey("UpdateUserId");

                    b.Navigation("CourtOrganization");

                    b.Navigation("UpdateUser");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameHistory", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.GameOrder", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Booking");

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Log", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Booking");

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

            modelBuilder.Entity("Infrastructure.Data.Entities.Notification", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.Schedule", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Court", "Court")
                        .WithMany()
                        .HasForeignKey("CourtId");

                    b.Navigation("Court");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.User", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Infrastructure.Data.Entities.CourtDictionary", "CourtDictionary")
                        .WithMany()
                        .HasForeignKey("CourtDictionaryId");

                    b.Navigation("City");

                    b.Navigation("CourtDictionary");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserBooking", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Booking");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserInterest", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Interest", "Interest")
                        .WithMany()
                        .HasForeignKey("InterestId");

                    b.HasOne("Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Interest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Entities.UserReview", b =>
                {
                    b.HasOne("Infrastructure.Data.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("Infrastructure.Data.Entities.User", "ReviewedPlayer")
                        .WithMany()
                        .HasForeignKey("ReviewedPlayerId");

                    b.HasOne("Infrastructure.Data.Entities.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");

                    b.Navigation("Game");

                    b.Navigation("ReviewedPlayer");

                    b.Navigation("Reviewer");
                });
#pragma warning restore 612, 618
        }
    }
}
