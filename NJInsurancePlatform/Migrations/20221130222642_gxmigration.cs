﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NJInsurancePlatform.Migrations
{
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
    public partial class gxmigration : Migration
========
    public partial class initial : Migration
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BeneficiaryMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentZipcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CurrentState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrentEmployer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IsPrimaryPolicyHolder = table.Column<bool>(type: "bit", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinimumPayment = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillMUID);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    ClaimMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyMUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimUserDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DateOfClaim = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimMUID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrentCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrentZipcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CurrentState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrentEmployer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsPrimaryPolicyHolder = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerMUID);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    FaqMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.FaqMUID);
                });

            migrationBuilder.CreateTable(
                name: "GroupRoomMessages",
                columns: table => new
                {
                    GroupRoomMessageMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupRoomMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRoomMessages", x => x.GroupRoomMessageMUID);
                });

            migrationBuilder.CreateTable(
                name: "GroupRooms",
                columns: table => new
                {
                    GroupMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRooms", x => x.GroupMUID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CardExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DebitOrCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoutingNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    CheckNumber = table.Column<int>(type: "int", nullable: false),
                    CheckImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentMUID);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameOfPolicy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PolicyOwner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deductible = table.Column<double>(type: "float", nullable: false),
                    OutOfPocketLimit = table.Column<double>(type: "float", nullable: false),
                    AnnualLimitOfCoverage = table.Column<double>(type: "float", nullable: false),
                    PolicyPaymentisDue = table.Column<bool>(type: "bit", nullable: false),
                    PolicyTotalAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyPaidOffAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyStart_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyEnd_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyMUID);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRequests",
                columns: table => new
                {
                    RequestMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRequests", x => x.RequestMUID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Deductible = table.Column<double>(type: "float", nullable: false),
                    AnnualLimitOfCoverage = table.Column<double>(type: "float", nullable: false),
                    OutOfPocketLimit = table.Column<double>(type: "float", nullable: false),
                    PolicyPaidOffAmount = table.Column<double>(type: "float", nullable: false),
                    PolicyTotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductMUID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isPaymentComplete = table.Column<bool>(type: "bit", nullable: false),
                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionMUID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    BeneficiaryMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    TransactionMUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.BeneficiaryMUID);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Transactions_TransactionMUID",
                        column: x => x.TransactionMUID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionMUID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "30110b7a-7b0f-4a20-acec-2703cb0e85b8", "Beneficiary", "BENEFICIARY" },
                    { "4ccdb6fe-310a-4d2e-adac-a948d65283ca", "7da3a0b0-fde2-4417-84b8-f64ec230284c", "Pending", "PENDING" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "0bdb499d-d5b3-4081-a8ac-371a564ec834", "Customer", "CUSTOMER" },
                    { "f66d9f19-6a33-4d5c-9da9-616967a9edbb", "d2e64540-a53f-442e-b7e6-dadf0c05b9cf", "Admin", "ADMIN" }
========
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "31eda4a4-3f40-4233-ae38-5b55d34a4456", "Beneficiary", "BENEFICIARY" },
                    { "6d803124-ad9e-4ae0-bcde-cf295e51d713", "0bbd2c31-dcc9-4731-90ec-ce1c81c42277", "Pending", "PENDING" },
                    { "91765d77-19fc-4104-9835-ceb4fdef5024", "7424cdec-ca74-492a-9c02-95b14967e985", "Admin", "ADMIN" },
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "ea42e981-c923-4497-a972-866cab6b980a", "Customer", "CUSTOMER" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BeneficiaryMUID", "ConcurrencyStamp", "CreatedDate", "CurrentAddress", "CurrentCity", "CurrentEmployer", "CurrentState", "CurrentZipcode", "CustomerMUID", "DOB", "Discriminator", "Email", "EmailAddress", "EmailConfirmed", "FirstName", "Gender", "IsPrimaryPolicyHolder", "LastName", "LicenseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PolicyMUID", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { "32b894d6-5027-4b30-8c1e-b5f21d15cf6b", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "8f472c46-3069-4e8a-914a-0bfd25009a9e", new DateTime(2022, 11, 30, 17, 26, 41, 840, DateTimeKind.Local).AddTicks(7157), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEF2w4ZsZTeynDeLJKnaj0frk1wX2UImeMw6UeQOD64NSPoXKt0i5nWPoGM+oQ09X3Q==", "8790985467", false, null, "123456789", "c3e852ae-0a73-4899-b3b4-4d5420e1c510", false, "AndreaB@mymail.com" },
                    { "4015a99f-444c-440d-96b6-6e29bb72586a", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "b8f89d17-fe9a-4026-a3b3-dcb912d4dc74", new DateTime(2022, 11, 30, 17, 26, 41, 842, DateTimeKind.Local).AddTicks(8002), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEAfnt87weDnboL5I2SM70X7AsTPczOtd9YnxihYelEeEYJWWvGIa47R4j8JE7BKIXw==", "8790985467", false, null, "123456789", "5d31fe4e-4cfb-4218-ac88-43e72e5cff11", false, "BritneyG@mymail.com" },
                    { "481d2d38-a518-4f83-9650-0b7de0a80dfd", 0, true, null, "32d7beef-096d-427e-af5d-c1b17b27d1ac", new DateTime(2022, 11, 30, 17, 26, 41, 839, DateTimeKind.Local).AddTicks(6596), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAEBxThB102GsNgeTAAwChCIHIJiR2SRLjIfcoXhmhIUTa50GZlltGCTFrVP44ILnCAQ==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "717ce062-60d1-468a-b3d2-9cbf0c89227e", false, "LeonaW@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "d778cafe-c32b-419b-a116-4930eec22fb6", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEMu6Bz4iRSeCRZ/xdfCg1v1qI8iZCAUa64islmCTVS6TorIXxz/hiLxr+6m3q6w3Zg==", null, false, null, null, "597f512e-7463-4d8d-8cd9-816c894819bc", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "0479f441-00a2-4261-be2b-74a2f1b5e1d0", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEFCUYI9DHlVTyYg+g2WoyoQ58E0sQTb7SwKW15sTRfSHqHs3jlchdYHxQCcb4Pir8g==", null, false, null, null, "62384a69-bd94-4bb7-8f63-2244f82b7daa", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "0d0384a0-49bc-42eb-be82-e0cc98c29bb9", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEGRTds+G5mKr+TRIRGvhRKAuhJQXI4RqO1wIYskV74he7Iq3d2dC+SbJ/X1MumZvLw==", null, false, null, null, "94197e2b-c387-46d1-9c67-4f5c1098cacb", false, "admin" },
                    { "adaa93cd-694e-4be2-8289-d2b4822d7446", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "d1da8389-e599-4a5d-a9f6-107eeae95ab2", new DateTime(2022, 11, 30, 17, 26, 41, 841, DateTimeKind.Local).AddTicks(7479), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEI4K4HbpzkvxOg3dQcoaoKX+g8mV/F6tz5+VnW9ZVo0DiyjoJgLNvUUgJKMInMrXxw==", "8790985467", false, null, "123456789", "2b9a9434-060f-4c48-8342-02c0728fcb64", false, "CynthiaS@mymail.com" },
                    { "b4bb8b48-edcf-4204-ad46-c2cc90f2d9e7", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "6db2aa0d-f6ad-4269-b234-c885bed4a41c", new DateTime(2022, 11, 30, 17, 26, 41, 843, DateTimeKind.Local).AddTicks(8290), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAEIMq4UuNO377dC95Ba3akSo/h1M6QLs+DDUyUsWmVcTseMnuf3kke3TPFRSGhG7bvQ==", "8790985467", false, null, "123456789", "3e861a19-789d-4092-be50-31fa510e401b", false, "JoanaM@mymail.com" },
                    { "ce214807-51a0-4cce-9470-ed2fa5c9d1f6", 0, true, null, "7846b0e0-bbfe-4cc9-94ce-84923982d215", new DateTime(2022, 11, 30, 17, 26, 41, 838, DateTimeKind.Local).AddTicks(6259), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAECCG02KTOX6k4X8dShvB6XDtIKwLqrQHojx5CVh8GQ7WCDW0SnC79ZQpi8fFdL0vYQ==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "2dd28934-29a1-4f87-b9d5-af7d73674d2b", false, "NikosiT@mymail.com" },
                    { "cfdb5e3f-6932-44c4-96fa-49c904691038", 0, true, null, "7241963e-74af-4e35-8e38-a89a1d142fcd", new DateTime(2022, 11, 30, 17, 26, 41, 836, DateTimeKind.Local).AddTicks(2988), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAELpuErlnDBxgJ3DKx1gJJo5hhHmkvwHOKWY1zjQOqFN9UQvZarnZxJVjF4hjVpoJ7Q==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "14316c93-7f5e-47b2-bf84-f51910917675", false, "Pato" },
                    { "fb359e2e-46b4-4734-8f26-4609cdc367d4", 0, true, null, "78a7c33e-a5fc-43a1-9b2a-98f3e138b1f7", new DateTime(2022, 11, 30, 17, 26, 41, 837, DateTimeKind.Local).AddTicks(4215), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEF+eXlpZ6oJCYRwZsNigXIwSGSbkVxNyAg/RW2+Vj1pby2YYU2ywkqR0gDHD4cYpjQ==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "137d92dd-acf4-4969-8885-580159f06b77", false, "EricD@mymail.com" }
========
                    { "040ba841-bb3a-44f6-bdda-3ee9731218f2", 0, true, null, "e7496894-3641-44b0-86ad-e0366014d697", new DateTime(2022, 11, 30, 11, 39, 46, 147, DateTimeKind.Local).AddTicks(8401), "3464 Brinkly street", "Gathersburg", "Brimson distributers", "Maryland", "7897678", new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "LeonaW@mymail.com", false, "Leona", "female", true, "Wilson", "39kh8087hf", false, null, null, "LEONAW@MYMAIL.COM", "AQAAAAEAACcQAAAAECbZw7qjq3WOudhCj2yDhkLHdIM0o9Uy7lG8qLETsgO/FAl3AYH3SbYPybJUC6XT0Q==", "8790985467", false, new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "123456789", "0d5df980-3afe-418f-893d-d908d52b7d21", false, "LeonaW@mymail.com" },
                    { "04b44a8c-9a4c-4834-b712-61bec619b545", 0, true, null, "e2a1277e-f039-4357-ade5-fcf12fc5d330", new DateTime(2022, 11, 30, 11, 39, 46, 133, DateTimeKind.Local).AddTicks(2893), "456 main street", "Baltimore", "Xillon Co", "Maryland", "7897678", new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "EricD@mymail.com", false, "Eric", "male", true, "Daley", "39kh8087hf", false, null, null, "ERICD@MYMAIL.COM", "AQAAAAEAACcQAAAAEJhCYDL3MHBFrzkbqmZ5iLqCw1u50rTt2iwQlyC+7HB0UdFxMz1IuC4sMobUk6OnNw==", "8790985467", false, new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "123456789", "054b0998-5049-47aa-bdf3-421d49dca830", false, "EricD@mymail.com" },
                    { "63735308-4e1e-4738-9002-ebca7ed3b52c", 0, true, null, "89c2f7f0-eb9b-4302-86f2-8824ccdaf118", new DateTime(2022, 11, 30, 11, 39, 46, 140, DateTimeKind.Local).AddTicks(3700), "789 Grove street", "Rockville", "techumseh International", "Maryland", "7897678", new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "NikosiT@mymail.com", false, "Nikosi", "female", true, "Thom", "39kh8087hf", false, null, null, "NIKOSIT@MYMAIL.COM", "AQAAAAEAACcQAAAAENDdWZiastkNCHuXicp5LMYjjHi6YSnidOAQjHX695FNWjQ/o7c9R4cLVzs8ChFJ+A==", "8790985467", false, new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "123456789", "485e2b2c-bb15-42e8-ada4-9d98e18f0e95", false, "NikosiT@mymail.com" },
                    { "7df548f2-8144-4536-a0cf-f979c231ae0e", 0, true, null, "25e8afd8-1ada-4ea7-802d-dbfc0abf6e09", new DateTime(2022, 11, 30, 11, 39, 46, 125, DateTimeKind.Local).AddTicks(155), "123 Elm street", "Milwaukee", "Alphabet Corp", "Wisconsin", "7897678", new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "PatrickL@mymail.com", false, "Patrick", "male", true, "Leon", "39kh8087hf", false, null, null, "PATO", "AQAAAAEAACcQAAAAEN2cyS6YEpROfh2QqF8zXT1xjV84MuW16A+KHnuwsKLtClhFRBKBKsyzy4Hoid2X6w==", "2019878709", false, new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "123456789", "a9f28df3-fdcc-43f5-90c4-168ad5de383d", false, "Pato" },
                    { "8b7eb503-35d6-4e1c-9339-374b4c4a6672", 0, true, new Guid("6808f1f0-47c1-4136-b775-b1f6ffc541fd"), "67ef69e8-40a8-47cf-ac1e-9e89437dbbfb", new DateTime(2022, 11, 30, 11, 39, 46, 155, DateTimeKind.Local).AddTicks(2453), null, null, null, null, null, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "AndreaB@mymail.com", false, "Andrea", "female", false, "Bogataw", "39kh8087hf", false, null, null, "ANDREAB@MYMAIL.COM", "AQAAAAEAACcQAAAAEIQGXcGntsNghh02lMygetg0e86UGpsgrrJAORF8RuvtEo3vWLPJt3gZurfern/QNw==", "8790985467", false, null, "123456789", "58934c7f-58cc-4df9-9a6c-8dadb81e81a9", false, "AndreaB@mymail.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, false, null, "117b37f2-0995-4608-a277-528b3919e8ec", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "customer", false, null, null, false, null, null, false, null, null, "CUSTOMER", "AQAAAAEAACcQAAAAEDwvErrj+M45qUTPWODF9zGfeJbdNRXA1OUS/HYpXMvHgEUh12hN3McXuewGCyuI7w==", null, false, null, null, "8008d7b5-50ca-4c92-af1e-19cf5cc220e6", false, "customer" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, false, null, "f2d50f1f-227a-4191-a578-7c916df73d32", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "beneficiary", false, null, null, false, null, null, false, null, null, "BENEFICIARY", "AQAAAAEAACcQAAAAEMHyzEuX6U5xvPZef2oeYdKiT56n4PrguWJqMawNP8e+3q1khVMuj19lRVgrqmM6lg==", null, false, null, null, "d030f2c5-61fd-4dab-8fe2-f918f703fa14", false, "beneficiary" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, false, null, "4ed1322d-b5cf-4d72-84f5-688b7b26c235", null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "admin", false, null, null, false, null, null, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEOMJ/7dzFwPqroW9cI/uhP6D2O6RdWa3BkCmwxyNNmn3ibpvIOyV1qYBQ47SFaSFKQ==", null, false, null, null, "472ecdce-8099-4658-803e-dd444f7479ad", false, "admin" },
                    { "d7a10c84-450f-42ea-a601-9e0ea61c3b98", 0, true, new Guid("78d9cd41-acde-48fc-baa9-29b5065af159"), "4f139719-103d-4cfe-810f-2622419bf941", new DateTime(2022, 11, 30, 11, 39, 46, 170, DateTimeKind.Local).AddTicks(6076), null, null, null, null, null, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "BritneyG@mymail.com", false, "Brittney", "female", false, "Giles", "39k8ew8087hf", false, null, null, "BRITNEYG@MYMAIL.COM", "AQAAAAEAACcQAAAAEEtPVjQQXIESEaRsuZQWwueQs9CuR6mRGi2PAIx/yD1nShOIo7Dbdixk7/1v6XZQEg==", "8790985467", false, null, "123456789", "2b57f086-1c3a-4463-bad0-daf7089b00c8", false, "BritneyG@mymail.com" },
                    { "dd6d4216-cdf4-4e91-91c4-82c1346376a4", 0, true, new Guid("fa75877d-66a1-4f63-b8fa-d2cdb59fbdd1"), "bbd169cb-a3d5-4a20-97d3-ac3c396af1b6", new DateTime(2022, 11, 30, 11, 39, 46, 178, DateTimeKind.Local).AddTicks(4199), null, null, null, null, null, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "JoanaM@mymail.com", false, "Joana", "female", false, "Martin", "39k8ew8087hf", false, null, null, "JOANAM@MYMAIL.COM", "AQAAAAEAACcQAAAAECPp88wRO+mTDLvw3UrPuVEhk1KWRTyMEjQVRPu0UUeLiRJQSR4DQlUDihlCQt5ulQ==", "8790985467", false, null, "123456789", "5e0c66f2-6a6b-420c-8ddb-e130b99925ad", false, "JoanaM@mymail.com" },
                    { "fc82c6b9-10ec-4ace-b819-d7fbfee4cf56", 0, true, new Guid("54d5eae1-ee39-4f2d-8535-5f610d2e1cff"), "f1120581-f92c-4dc1-b179-15ad03b59caa", new DateTime(2022, 11, 30, 11, 39, 46, 163, DateTimeKind.Local).AddTicks(601), null, null, null, null, null, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ApplicationUser", null, "CynthiaS@mymail.com", false, "Cynthia", "female", false, "Smithers", "39k8ew8087hf", false, null, null, "CYNTHIAS@MYMAIL.COM", "AQAAAAEAACcQAAAAEB3DMW/cZbiWYJqxvwAmCCNJz+oehFqYSNEPJmM5Q23I4zkD0QaOUf7WW+ANWThIiQ==", "8790985467", false, null, "123456789", "f9ff08bb-f604-443b-aba1-07ffe096e1eb", false, "CynthiaS@mymail.com" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "BillMUID", "Balance", "CreatedDate", "MinimumPayment", "PolicyDueDate", "PolicyMUID", "Status" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1365), 283.99000000000001, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1363), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "status" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1370), 449.08999999999997, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1369), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "status" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1367), 129.09, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1366), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "status" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1361), 123.98999999999999, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1359), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "status" }
========
                    { new Guid("417a8279-0227-43c4-8504-c4396860ada0"), 509.33999999999997, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5206), 283.99000000000001, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5204), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), "status" },
                    { new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), 278.33999999999997, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5213), 449.08999999999997, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5212), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), "status" },
                    { new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), 109.34, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5210), 129.09, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5208), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), "status" },
                    { new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), 799.34000000000003, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5202), 123.98999999999999, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5200), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), "status" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqMUID", "Answer", "Question" },
                values: new object[,]
                {
                    { new Guid("1aaf2fe6-d0a2-406d-b872-878f8902c5cf"), "That is your initial role when you first register.  An Admin will approve your account and set you to your appropriate role.", "Why is my role listed as pending?" },
                    { new Guid("906a6638-af9b-479f-a67f-ea41c0597807"), "Somerset, NJ", "Where Is our company based out of?" },
                    { new Guid("9ad2222c-e13f-4a02-a3ed-5213d1b5cbae"), "Your policy must first be approved by an Admin, please check your policy again in a little while.", "Why is my policy listed as pending?" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "GroupRoomMessages",
                columns: new[] { "GroupRoomMessageMUID", "CreatedDate", "GroupRoomMUID", "Message", "SenderMUID" },
                values: new object[,]
                {
                    { new Guid("4db427d8-8084-4987-9783-ef1154a0627b"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5298), new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Sure, What would you like to know?", new Guid("93fa9038-9c45-42cf-993b-fc3d15764f18") },
                    { new Guid("7a9ff0a2-6386-4094-8ae8-9240611eef7a"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5295), new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "yes, How Can I Help you?", new Guid("a7071f27-db08-47fb-a05a-0a7da44b44c4") },
                    { new Guid("82ba35e1-0c52-4f91-8ff3-7ba15a87c237"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5291), new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Hello, And Welcome", new Guid("d9ef788c-a3f8-48b3-92ce-804170aba836") },
                    { new Guid("e857e40b-d4d6-45dc-912f-4be6fc749c2d"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5297), new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "I have a question About My Policy", new Guid("a7071f27-db08-47fb-a05a-0a7da44b44c4") }
                });

            migrationBuilder.InsertData(
                table: "GroupRooms",
                columns: new[] { "GroupMUID", "Name" },
                values: new object[,]
                {
                    { new Guid("7e5319b1-4285-4811-bf88-c8542ac4bfa1"), "Leona's Group" },
                    { new Guid("80d2744e-2de6-47cc-97d1-05f8a0794f6c"), "Eric's Group" },
                    { new Guid("858efa88-5226-47e5-8bd0-80546b2f469d"), "Patrick's Group" },
                    { new Guid("f4f42d43-4d51-43a9-b398-5430131efd2a"), "Nikosi's Group" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentMUID", "AccountNumber", "AdditionalInfo", "Amount", "BankName", "BillMUID", "CVV", "CardExpireDate", "CardNumber", "CheckImage", "CheckNumber", "CreatedDate", "DebitOrCredit", "PaidDate", "PayerFirstName", "PayerLastName", "PaymentMethod", "RoutingNumber", "ZipCode" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), "123", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1413), "123498732", "check Image", 9870, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1415), "credit", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1412), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), "123", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1402), "123498732", "check Image", 345, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1404), "credit", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1400), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), "123", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1408), "123498732", "check Image", 4532, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1410), "credit", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1406), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), "123", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1396), "123498732", "check Image", 123, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1399), "debit", new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1393), "Jillian", "Flowers", "visa", "2345432", "12345" }
========
                    { new Guid("0b73fbd0-eb85-42c4-a634-e8ee78d81218"), "2345643", "Additional info", 58.990000000000002, "Bank of the Oranges", new Guid("9b7d532c-62a8-4a8d-96d9-6a7a80b118d4"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5254), "123498732", "check Image", 9870, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5256), "credit", new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5252), "katherine", "Rivera", "visa", "2345432", "12345" },
                    { new Guid("0b8e18c5-0b17-4bc1-b2a3-00abe6fb5e72"), "2345643", "Additional info", 234.88999999999999, "Peoples Savings", new Guid("417a8279-0227-43c4-8504-c4396860ada0"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5242), "123498732", "check Image", 345, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5244), "credit", new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5239), "Fred", "Sanders", "mastercard", "2345432", "12345" },
                    { new Guid("0fc63b41-88b2-4ad9-9035-0951611d62ae"), "2345643", "Additional info", 563.99000000000001, "Bank of Nova Scotia", new Guid("c28330de-a718-465b-9772-5b28ad6395e8"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5248), "123498732", "check Image", 4532, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5250), "credit", new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5246), "Phillis", "McMahon", "visa", "2345432", "12345" },
                    { new Guid("d3bfa2b2-a707-412f-9c4d-cbf1ec275693"), "2345643", "Additional info", 123.98999999999999, "Spring Savings", new Guid("f46090ed-d574-4456-8e18-97150ff885ed"), new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5233), "123498732", "check Image", 123, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5237), "debit", new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5230), "Jillian", "Flowers", "visa", "2345432", "12345" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyMUID", "AnnualLimitOfCoverage", "CustomerMUID", "Deductible", "NameOfPolicy", "OutOfPocketLimit", "Pending", "PolicyEnd_Date", "PolicyOwner", "PolicyPaidOffAmount", "PolicyPaymentisDue", "PolicyStart_Date", "PolicyTotalAmount", "ProductMUID" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1315), 769564, "Leona wilson", 0.0, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1314), 35000.0 },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1312), 78910, "Nikosi Thom", 0.0, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1310), 35000.0 },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1304), 1234, "Patrick Leon", 0.0, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1262), 35000.0 },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1308), 4567, "Eric Daley", 0.0, false, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1307), 35000.0 }
========
                    { new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), 14999.99, new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5154), "Leona wilson", 0.0, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5152), 35000.0, new Guid("e4a9822a-2cc4-4f9d-bcee-57dbdbf07b58") },
                    { new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), 14999.99, new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 100.25, "Eye Emarald", 999.99000000000001, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5150), "Nikosi Thom", 0.0, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5148), 35000.0, new Guid("821f419a-f7e2-4aa7-b6f2-e4d885afdeda") },
                    { new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), 14999.99, new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 100.25, "Dental Gold", 999.99000000000001, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5140), "Patrick Leon", 0.0, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5109), 35000.0, new Guid("f9097017-1c13-4590-b6bb-355418ec018e") },
                    { new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), 14999.99, new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 100.25, "Health Platinum", 999.99000000000001, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5146), "Eric Daley", 0.0, false, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5144), 35000.0, new Guid("4744efb6-564d-42ff-8ebd-e86fce1b3ccf") }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductMUID", "AnnualLimitOfCoverage", "Deductible", "Description", "OutOfPocketLimit", "PolicyPaidOffAmount", "PolicyTotalAmount", "Price", "ProductName" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { new Guid("16798f0b-3ab3-4c0a-972f-3cc8fe17e4ba"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 789.0, "Eye Emerald" },
                    { new Guid("38290d76-1c38-4c9d-b33f-cf6abf4797fc"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 3343.0, "Health Platinum" },
                    { new Guid("419f6e4f-cb20-4d50-a931-f9e64f13fcbb"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 2343.0, "DentalGold" },
                    { new Guid("7c7d7e6b-a8f8-4cb5-8895-63fffedb8089"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 1200.98, "Empoyee Individual" }
========
                    { new Guid("4744efb6-564d-42ff-8ebd-e86fce1b3ccf"), 25999.990000000002, 200.15000000000001, "Enum Zelgar Phlnnub nilsup", 999.99000000000001, 0.0, 150000.0, 3343.0, "Health Platinum" },
                    { new Guid("821f419a-f7e2-4aa7-b6f2-e4d885afdeda"), 1345.99, 50.670000000000002, "Lorus Plorem enum taknut", 1200.45, 0.0, 2000.0, 789.0, "Eye Emerald" },
                    { new Guid("e4a9822a-2cc4-4f9d-bcee-57dbdbf07b58"), 5345.9899999999998, 160.69, "Bupka ladna velnup halstus", 5600.4499999999998, 0.0, 100000.0, 1200.98, "Empoyee Individual" },
                    { new Guid("f9097017-1c13-4590-b6bb-355418ec018e"), 14999.99, 100.25, "Lorus Plorem enum taknut", 999.99000000000001, 0.0, 10000.0, 2343.0, "DentalGold" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionMUID", "CustomerMUID", "PaymentAmount", "PaymentDate", "PolicyMUID", "isPaymentComplete" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1339), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1335), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1332), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 11, 30, 17, 26, 41, 833, DateTimeKind.Local).AddTicks(1337), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
========
                    { new Guid("3287bca8-d9dc-4f75-94ca-227cfb4c72da"), new Guid("3498cdd0-6913-4c08-b29f-5291f28201ce"), 189.05000000000001, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5179), new Guid("46c76123-4e2c-4cce-95fa-0646268c5b1d"), false },
                    { new Guid("530f62a1-8730-4784-bb71-a257136dd9f6"), new Guid("0d7a4ff8-5b33-44bf-a0fe-bd0f696187f1"), 2109.7800000000002, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5175), new Guid("abdafd4a-48ff-4f1a-bcc6-fd3dd2c659a5"), true },
                    { new Guid("76098a5e-bcda-46be-9cf3-a19f24d14018"), new Guid("7e46ae9d-ff19-47da-ae69-922069555efb"), 1199.78, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5172), new Guid("a61a15af-6a7d-4e82-9659-c5003721f5ea"), true },
                    { new Guid("f752a2a0-7300-42ba-beab-dc65992ca945"), new Guid("f71979e2-b649-4fbc-bc63-3bafa1d65176"), 109.08, new DateTime(2022, 11, 30, 11, 39, 46, 102, DateTimeKind.Local).AddTicks(5177), new Guid("67bb56de-01c9-42e2-b066-eea2c082f06f"), false }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
<<<<<<<< HEAD:NJInsurancePlatform/Migrations/20221130222642_gxmigration.cs
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "32b894d6-5027-4b30-8c1e-b5f21d15cf6b" },
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "4015a99f-444c-440d-96b6-6e29bb72586a" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "481d2d38-a518-4f83-9650-0b7de0a80dfd" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "f66d9f19-6a33-4d5c-9da9-616967a9edbb", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "adaa93cd-694e-4be2-8289-d2b4822d7446" },
                    { "43b58f44-9a2b-496e-b16e-ac1dedaae366", "b4bb8b48-edcf-4204-ad46-c2cc90f2d9e7" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "ce214807-51a0-4cce-9470-ed2fa5c9d1f6" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "cfdb5e3f-6932-44c4-96fa-49c904691038" },
                    { "d3e1cf63-a360-4721-b9f1-26073ab53180", "fb359e2e-46b4-4734-8f26-4609cdc367d4" }
========
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "040ba841-bb3a-44f6-bdda-3ee9731218f2" },
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "04b44a8c-9a4c-4834-b712-61bec619b545" },
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "63735308-4e1e-4738-9002-ebca7ed3b52c" },
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "7df548f2-8144-4536-a0cf-f979c231ae0e" },
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "8b7eb503-35d6-4e1c-9339-374b4c4a6672" },
                    { "a59c54d5-8815-4983-8317-88c0d1f02304", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "91765d77-19fc-4104-9835-ceb4fdef5024", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "d7a10c84-450f-42ea-a601-9e0ea61c3b98" },
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "dd6d4216-cdf4-4e91-91c4-82c1346376a4" },
                    { "497a132b-dfc8-4e70-bff8-2acb96325392", "fc82c6b9-10ec-4ace-b819-d7fbfee4cf56" }
>>>>>>>> Main:NJInsurancePlatform/Migrations/20221130163946_initial.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_TransactionMUID",
                table: "Beneficiaries",
                column: "TransactionMUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "GroupRoomMessages");

            migrationBuilder.DropTable(
                name: "GroupRooms");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "PolicyRequests");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
