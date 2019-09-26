﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovoDiagnosis.Data;

namespace NovoDiagnosis.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StaffId");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("AuthorizationNote");

                    b.Property<int?>("AuthorizationStatus");

                    b.Property<int?>("AuthorizedBy");

                    b.Property<DateTime?>("AuthorizedDate");

                    b.Property<string>("City");

                    b.Property<string>("Code");

                    b.Property<int?>("CompanyListPageId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("DeletionNote");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DisapprovalDate");

                    b.Property<string>("DisapprovalNote");

                    b.Property<int?>("DisapprovedBy");

                    b.Property<string>("Email");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsRenewal");

                    b.Property<string>("LogoLink");

                    b.Property<int?>("Logoid");

                    b.Property<string>("Name");

                    b.Property<long?>("Parentid");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Plans");

                    b.Property<int?>("RegAgeLimit");

                    b.Property<string>("RegCode");

                    b.Property<int?>("SiteId");

                    b.Property<long?>("Stateid");

                    b.Property<bool?>("Status");

                    b.Property<int?>("SubscriptionStatus");

                    b.Property<int?>("SubsidiaryId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<bool?>("WeboperationMode");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.CompanyBenefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BenefitId");

                    b.Property<string>("BenefitLimit");

                    b.Property<int?>("CompanyPlanid");

                    b.Property<int?>("Companyid");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int?>("SiteId");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("CompanyBenefit");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.CompanyBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch");

                    b.Property<int?>("CompanyId");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int?>("SiteId");

                    b.Property<int?>("Statecode");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyBranch");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.CompanyPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AllowChildEnrollee");

                    b.Property<decimal?>("AnnualPremium");

                    b.Property<string>("AuthorizationNote");

                    b.Property<int?>("AuthorizationStatus");

                    b.Property<int?>("AuthorizedBy");

                    b.Property<DateTime?>("AuthorizedDate");

                    b.Property<int?>("Companyid");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int?>("Createdby");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DisapprovalDate");

                    b.Property<string>("DisapprovalNote");

                    b.Property<int?>("DisapprovedBy");

                    b.Property<decimal?>("Discountlump");

                    b.Property<decimal?>("Discountperenrollee");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int?>("MaxNoOfDependant");

                    b.Property<string>("Planfriendlyname");

                    b.Property<int?>("Planid");

                    b.Property<string>("ProviderConsession");

                    b.Property<int?>("SiteId");

                    b.Property<bool?>("Status");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("CompanyPlans");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.CompanySubsidiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int?>("ParentcompanyId");

                    b.Property<int?>("SiteId");

                    b.Property<string>("Subsidaryname");

                    b.Property<string>("Subsidaryprofile");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("CompanySubsidiaries");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.DiagnosisDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppointmentDate");

                    b.Property<string>("AppointmentTime");

                    b.Property<bool>("Approve");

                    b.Property<string>("AuthorizationCode");

                    b.Property<bool>("CompletedAnnualMedical");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Diagnosis");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("History");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("PlanTest");

                    b.Property<string>("PresentingComplain");

                    b.Property<string>("Provider")
                        .IsRequired();

                    b.Property<string>("Recommendation");

                    b.Property<bool>("Reject");

                    b.Property<string>("StaffId")
                        .IsRequired();

                    b.Property<string>("State");

                    b.Property<string>("Status");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("DiagnosisDetails");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Enrollee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age");

                    b.Property<int?>("Bulkjobid");

                    b.Property<int?>("Companyid");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int?>("Createdby");

                    b.Property<DateTime?>("Dateexpunged");

                    b.Property<DateTime?>("Datereceived");

                    b.Property<DateTime?>("Dob");

                    b.Property<string>("Emailaddress");

                    b.Property<int?>("EnrolleePassportId");

                    b.Property<string>("ExpungeNote");

                    b.Property<int?>("Expungedby");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("HasRefPolicyNumber");

                    b.Property<bool?>("Hasactivesubscription");

                    b.Property<bool?>("Hasdependents");

                    b.Property<bool?>("IdCardPrinted");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("Isexpundged");

                    b.Property<int?>("LastyearBirthdaymsgsent");

                    b.Property<int?>("Lgaid");

                    b.Property<int?>("Maritalstatus");

                    b.Property<string>("Mobilenumber");

                    b.Property<string>("Mobilenumber2");

                    b.Property<string>("Occupation");

                    b.Property<string>("Othernames");

                    b.Property<int?>("Parentid");

                    b.Property<int?>("Parentrelationship");

                    b.Property<int?>("Passphrase");

                    b.Property<string>("Policynumber");

                    b.Property<string>("Preexistingmedicalhistory");

                    b.Property<int?>("Primaryprovider");

                    b.Property<string>("RefPolicynumber");

                    b.Property<string>("Residentialaddress");

                    b.Property<int?>("Sex");

                    b.Property<string>("Specialidcardfield1");

                    b.Property<string>("Specialidcardfield2");

                    b.Property<string>("Specialidcardfield3");

                    b.Property<int?>("Sponsorshiptype");

                    b.Property<string>("Sponsorshiptypenote");

                    b.Property<string>("Sponsorshiptypeothername");

                    b.Property<int?>("Staffprofileid");

                    b.Property<int?>("Stateid");

                    b.Property<int?>("Status");

                    b.Property<int?>("Subscriptionplanid");

                    b.Property<string>("Surname");

                    b.Property<string>("Title");

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<int?>("staffId");

                    b.HasKey("Id");

                    b.HasIndex("staffId");

                    b.ToTable("Enrollee");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<int>("StateId");

                    b.HasKey("Id");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyId");

                    b.Property<int?>("CompanySubsidiary");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int?>("Createdby");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("HasProfile");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsExpunged");

                    b.Property<int?>("NewStaffId");

                    b.Property<int?>("Profileid");

                    b.Property<string>("StaffFullname");

                    b.Property<string>("StaffId");

                    b.Property<int?>("StaffJobId");

                    b.Property<int?>("StaffPlanid");

                    b.Property<DateTime?>("StafflinkDate");

                    b.Property<int?>("StafflinkUser");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("CreatedOn");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<string>("ReplyBy");

                    b.Property<string>("Status");

                    b.Property<string>("Subject");

                    b.Property<string>("UpdatedOn");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("CugMobilephone");

                    b.Property<string>("CurrentEncryption");

                    b.Property<bool?>("DisableNotifications");

                    b.Property<string>("Dob");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<Guid>("Guid");

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsDeleted");

                    b.Property<DateTime?>("LastLoginDate");

                    b.Property<string>("LastName");

                    b.Property<DateTime?>("LastNotificationReadDate");

                    b.Property<int?>("LoginAttempts");

                    b.Property<string>("Mobilephone");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<DateTime?>("ResetPasswordExpiry");

                    b.Property<Guid?>("ResetPasswordGuid");

                    b.Property<string>("Uiculture");

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NovoDiagnosis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NovoDiagnosis.Models.CompanyBranch", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.Company", "Company")
                        .WithMany("CompanyBranch")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("NovoDiagnosis.Models.Enrollee", b =>
                {
                    b.HasOne("NovoDiagnosis.Models.Staff", "staff")
                        .WithMany()
                        .HasForeignKey("staffId");
                });
#pragma warning restore 612, 618
        }
    }
}
