﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using job_buddy_backend.Models.DataContext;

#nullable disable

namespace job_buddy_backend.Migrations
{
    [DbContext(typeof(JobBuddyDbContext))]
    [Migration("20241119181706_added ispremium for user")]
    partial class addedispremiumforuser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobBuddyBackend.Models.ATSScore", b =>
                {
                    b.Property<int>("ATSScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ATSScoreID"));

                    b.Property<string>("ATSFeedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("ResumeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ATSScoreID");

                    b.HasIndex("JobID");

                    b.HasIndex("ResumeID");

                    b.ToTable("ATSScores");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.JobListing", b =>
                {
                    b.Property<int>("JobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployerID")
                        .HasColumnType("int");

                    b.Property<string>("ExperienceLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PayRatePerHour")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("PayRatePerYear")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortJobDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobID");

                    b.HasIndex("EmployerID");

                    b.ToTable("JobListings");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.JobTag", b =>
                {
                    b.Property<int>("JobTagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobTagID"));

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTagID");

                    b.HasIndex("JobID");

                    b.ToTable("JobTags");
                });

            modelBuilder.Entity("job_buddy_backend.Helpers.AppSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SettingKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SettingKey")
                        .IsUnique();

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("job_buddy_backend.Models.Application", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationID"));

                    b.Property<string>("CoverLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FollowUpReminder")
                        .HasColumnType("bit");

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResumeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ApplicationID");

                    b.HasIndex("JobID");

                    b.HasIndex("ResumeID");

                    b.HasIndex("UserID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Chat", b =>
                {
                    b.Property<int>("ChatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatID"));

                    b.Property<int>("EmployerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("JobSeekerID")
                        .HasColumnType("int");

                    b.HasKey("ChatID");

                    b.HasIndex("EmployerID");

                    b.HasIndex("JobID");

                    b.HasIndex("JobSeekerID");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Connection", b =>
                {
                    b.Property<int>("ConnectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConnectionID"));

                    b.Property<DateTime?>("AcceptedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JobID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequesteeID")
                        .HasColumnType("int");

                    b.Property<int>("RequestorID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ConnectionID");

                    b.HasIndex("RequesteeID");

                    b.HasIndex("RequestorID");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"));

                    b.Property<int>("ChatID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("SenderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("MessageID");

                    b.HasIndex("ChatID");

                    b.HasIndex("SenderID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("job_buddy_backend.Models.EmployerProfile", b =>
                {
                    b.Property<int>("EmployerProfileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployerProfileID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyWebsite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("OfficeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployerProfileID");

                    b.HasIndex("UserID");

                    b.ToTable("EmployerProfiles");
                });

            modelBuilder.Entity("job_buddy_backend.Models.Resume", b =>
                {
                    b.Property<int>("ResumeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResumeID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperienceSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeFileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ResumeID");

                    b.HasIndex("UserID");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ResumeSkill", b =>
                {
                    b.Property<int>("ResumeSkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResumeSkillID"));

                    b.Property<int>("ResumeID")
                        .HasColumnType("int");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResumeSkillID");

                    b.HasIndex("ResumeID");

                    b.ToTable("ResumeSkills");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailConfirmationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProfileComplete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkedInUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserCertification", b =>
                {
                    b.Property<int>("UserCertificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserCertificationID"));

                    b.Property<string>("CredentialUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IssuedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserCertificationID");

                    b.HasIndex("UserID");

                    b.ToTable("UserCertifications");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserEducation", b =>
                {
                    b.Property<int>("UserEducationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserEducationID"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserEducationID");

                    b.HasIndex("UserID");

                    b.ToTable("UserEducations");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserExperience", b =>
                {
                    b.Property<int>("UserExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserExperienceID"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserExperienceID");

                    b.HasIndex("UserID");

                    b.ToTable("UserExperiences");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserPhoneNumber", b =>
                {
                    b.Property<int>("UserPhoneNumberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPhoneNumberID"));

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserPhoneNumberID");

                    b.HasIndex("UserID");

                    b.ToTable("UserPhoneNumbers");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserProject", b =>
                {
                    b.Property<int>("UserProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserProjectID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("UserProjects");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.ATSScore", b =>
                {
                    b.HasOne("JobBuddyBackend.Models.JobListing", "JobListing")
                        .WithMany()
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("job_buddy_backend.Models.Resume", "Resume")
                        .WithMany("ATSScores")
                        .HasForeignKey("ResumeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobListing");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.JobListing", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "Employer")
                        .WithMany("JobListings")
                        .HasForeignKey("EmployerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.JobTag", b =>
                {
                    b.HasOne("JobBuddyBackend.Models.JobListing", "JobListing")
                        .WithMany("JobTags")
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobListing");
                });

            modelBuilder.Entity("job_buddy_backend.Models.Application", b =>
                {
                    b.HasOne("JobBuddyBackend.Models.JobListing", "JobListing")
                        .WithMany("Applications")
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("job_buddy_backend.Models.Resume", "Resume")
                        .WithMany("Applications")
                        .HasForeignKey("ResumeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("job_buddy_backend.Models.UserModel.User", "JobSeeker")
                        .WithMany("Applications")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("JobListing");

                    b.Navigation("JobSeeker");

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Chat", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("JobBuddyBackend.Models.JobListing", "Job")
                        .WithMany()
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("job_buddy_backend.Models.UserModel.User", "JobSeeker")
                        .WithMany()
                        .HasForeignKey("JobSeekerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employer");

                    b.Navigation("Job");

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Connection", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("RequesteeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("job_buddy_backend.Models.UserModel.User", null)
                        .WithMany()
                        .HasForeignKey("RequestorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Message", b =>
                {
                    b.HasOne("job_buddy_backend.Models.ChatModel.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("job_buddy_backend.Models.UserModel.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("job_buddy_backend.Models.EmployerProfile", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "Employer")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("job_buddy_backend.Models.Resume", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "JobSeeker")
                        .WithMany("Resumes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobSeeker");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ResumeSkill", b =>
                {
                    b.HasOne("job_buddy_backend.Models.Resume", "Resume")
                        .WithMany("ResumeSkills")
                        .HasForeignKey("ResumeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserCertification", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "User")
                        .WithMany("Certifications")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserEducation", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserExperience", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserPhoneNumber", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "User")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.UserProject", b =>
                {
                    b.HasOne("job_buddy_backend.Models.UserModel.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobBuddyBackend.Models.JobListing", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("JobTags");
                });

            modelBuilder.Entity("job_buddy_backend.Models.ChatModel.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("job_buddy_backend.Models.Resume", b =>
                {
                    b.Navigation("ATSScores");

                    b.Navigation("Applications");

                    b.Navigation("ResumeSkills");
                });

            modelBuilder.Entity("job_buddy_backend.Models.UserModel.User", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Certifications");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("JobListings");

                    b.Navigation("PhoneNumbers");

                    b.Navigation("Projects");

                    b.Navigation("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
