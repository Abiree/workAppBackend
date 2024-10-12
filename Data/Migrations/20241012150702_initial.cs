using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Args = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeLeaves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeLeaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Desc = table.Column<string>(type: "text", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    AvatarImg = table.Column<string>(type: "text", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StartDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DesignationId = table.Column<Guid>(type: "uuid", nullable: true),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: true),
                    ManagerId = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskTag",
                columns: table => new
                {
                    TaskId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTag", x => new { x.TaskId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TaskTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTag_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    InTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OutTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    WorkTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    BreakTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    OverTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    statutId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activities_Statuts_statutId",
                        column: x => x.statutId,
                        principalTable: "Statuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ManagerId = table.Column<string>(type: "text", nullable: true),
                    TypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Fromdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Todate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Days = table.Column<int>(type: "integer", nullable: true),
                    StatutId = table.Column<Guid>(type: "uuid", nullable: false),
                    Desc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_AspNetUsers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Leaves_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leaves_Statuts_StatutId",
                        column: x => x.StatutId,
                        principalTable: "Statuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leaves_TypeLeaves_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeLeaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e8356cb-a0fd-4859-b253-9e0fd7489adb"), "UI/UX designer" },
                    { new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), "Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a5550ea-a0fd-4859-b483-9e0fd7489adb"), "Project 1" },
                    { new Guid("3a5550ea-a0fd-4859-b483-9e0fd7489adb"), "Project 2" }
                });

            migrationBuilder.InsertData(
                table: "Statuts",
                columns: new[] { "Id", "Args", "Name" },
                values: new object[,]
                {
                    { new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"), "leaves", "Pending" },
                    { new Guid("1a5551ea-a0fd-4859-b483-9e0fd7489adb"), "leaves", "Approuved" },
                    { new Guid("1a5553ea-a0fd-4859-b483-9e0fd7489adb"), "leaves", "Denied" },
                    { new Guid("1e2549ea-a0fd-4859-b483-9e0fd7489adb"), "activity", "Absent" },
                    { new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb"), "activity", "Present" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e2549ea-a0fd-4859-b483-9e0fd7433adb"), "UI Design" },
                    { new Guid("1e4729ea-a0fd-4859-b483-9e0fd7422adb"), "Meeting" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e8356cb-a0fd-3256-b483-9e0fd7489adb"), "Team 2" },
                    { new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), "Team 1" }
                });

            migrationBuilder.InsertData(
                table: "TypeLeaves",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"), "Casual" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarImg", "ConcurrencyStamp", "DateBirth", "DesignationId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ManagerId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartDay", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e2226cb-a0fd-4859-b483-9e0fd7489afb", 0, null, "80c22e26-fc54-4fe3-9d76-c5e870b1dd7a", new DateTime(1999, 6, 3, 14, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), "abireghallabii@gmail.com", false, "Abire", "Ghallabi", false, null, null, "ABIREGHALLABII@GMAIL.COM", "ABIRE", "AQAAAAIAAYagAAAAEMajUZ6HCD8RlP3o+lWHwb/3o0OdbtzIC/9fzhpbWCXyo/ItbTctbL14YKkTzdT0MQ==", null, false, "99ac483a-2eb0-41fe-a725-561b7c7cbb21", new DateTime(2022, 9, 5, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), false, "abire" },
                    { "1e8356cb-a0fd-4859-b483-9e0fd7489afb", 0, null, "113ed34e-388d-4a50-a371-b0a7a6f0b355", new DateTime(1999, 3, 13, 14, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), "henry@gmail.com", false, "Courtney", "Henry", false, null, null, "HENRY@GMAIL.COM", "HENRY", "AQAAAAIAAYagAAAAEBYYdymCLjbFypcgeYOSqMUWW3iST/sIGzcNIuShrHjZAMqGL+ROeCWohVig2FJNwQ==", null, false, "ae6d1e13-ff87-467f-9be0-2bb69b25336d", new DateTime(2022, 9, 15, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), false, "henry" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreationDate", "Desc", "EndTime", "Name", "ProjectId", "StartTime" },
                values: new object[] { new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb"), new DateTime(2024, 10, 12, 15, 7, 2, 241, DateTimeKind.Utc).AddTicks(8330), "Description for Task 1", new DateTime(2023, 10, 11, 15, 0, 0, 0, DateTimeKind.Utc), "Task 1", new Guid("2a5550ea-a0fd-4859-b483-9e0fd7489adb"), new DateTime(2023, 10, 11, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "BreakTime", "Date", "InTime", "OutTime", "OverTime", "UserId", "WorkTime", "statutId" },
                values: new object[,]
                {
                    { new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489adb"), new TimeSpan(0, 1, 0, 0, 0), new DateTime(2024, 10, 12, 15, 7, 2, 241, DateTimeKind.Utc).AddTicks(8130), new DateTime(2024, 10, 12, 8, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 10, 12, 17, 30, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 0, 0, 0, 0), "1e8356cb-a0fd-4859-b483-9e0fd7489afb", new TimeSpan(0, 8, 0, 0, 0), new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb") },
                    { new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489e13"), new TimeSpan(0, 1, 0, 0, 0), new DateTime(2024, 10, 12, 15, 7, 2, 241, DateTimeKind.Utc).AddTicks(8120), new DateTime(2024, 10, 12, 8, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 10, 12, 18, 30, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 1, 0, 0, 0), "1e2226cb-a0fd-4859-b483-9e0fd7489afb", new TimeSpan(0, 9, 0, 0, 0), new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarImg", "ConcurrencyStamp", "DateBirth", "DesignationId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ManagerId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartDay", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e8356cb-a0fd-3619-b483-9e0fd7489aaa", 0, null, "e2909f1b-0a8a-4323-94ec-63b19808e47d", new DateTime(1999, 1, 3, 14, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b253-9e0fd7489adb"), "jenny@gmail.com", false, "Jenny", "Wilson", false, null, "1e2226cb-a0fd-4859-b483-9e0fd7489afb", "JENNY@GMAIL.COM", "JENNY", null, null, false, "00267712-acf7-46a6-a57e-93e8d6082a59", new DateTime(2022, 2, 5, 8, 30, 0, 0, DateTimeKind.Utc), new Guid("1e8356cb-a0fd-4859-b483-9e0fd7489adb"), false, "jenny" });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "Days", "Desc", "Fromdate", "ManagerId", "StatutId", "Todate", "TypeId", "UserId" },
                values: new object[] { new Guid("1e8356cb-a0fd-4859-e780-9e0fd7489afb"), 3, "Friend's Wedding Celebration", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"), "1e8356cb-a0fd-4859-b483-9e0fd7489afb" });

            migrationBuilder.InsertData(
                table: "TaskTag",
                columns: new[] { "TagId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("1e2549ea-a0fd-4859-b483-9e0fd7433adb"), new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb") },
                    { new Guid("1e4729ea-a0fd-4859-b483-9e0fd7422adb"), new Guid("2a5680ea-a0fd-4859-b483-9e0fd7489adb") }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "BreakTime", "Date", "InTime", "OutTime", "OverTime", "UserId", "WorkTime", "statutId" },
                values: new object[] { new Guid("1e3258cb-a9ae-4859-b483-9e0fd7489e15"), new TimeSpan(0, 1, 0, 0, 0), new DateTime(2024, 10, 12, 15, 7, 2, 241, DateTimeKind.Utc).AddTicks(8140), new DateTime(2024, 10, 12, 8, 30, 0, 0, DateTimeKind.Utc), new DateTime(2024, 10, 12, 19, 30, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 2, 0, 0, 0), "1e8356cb-a0fd-3619-b483-9e0fd7489aaa", new TimeSpan(0, 10, 0, 0, 0), new Guid("1e4729ea-a0fd-4859-b483-9e0fd7489adb") });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "Id", "Days", "Desc", "Fromdate", "ManagerId", "StatutId", "Todate", "TypeId", "UserId" },
                values: new object[] { new Guid("1e8356de-a0fd-4859-e780-9e0fd7489afb"), 5, "Vacation", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("1a5550ea-a0fd-4859-b483-9e0fd7489adb"), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("1e3258cb-a0fd-4859-b483-9e0fd7489adb"), "1e8356cb-a0fd-3619-b483-9e0fd7489aaa" });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_statutId",
                table: "Activities",
                column: "statutId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                name: "IX_AspNetUsers_DesignationId",
                table: "AspNetUsers",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagerId",
                table: "AspNetUsers",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TeamId",
                table: "AspNetUsers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_ManagerId",
                table: "Leaves",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_StatutId",
                table: "Leaves",
                column: "StatutId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_TypeId",
                table: "Leaves",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_UserId",
                table: "Leaves",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTag_TagId",
                table: "TaskTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

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
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "TaskTag");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuts");

            migrationBuilder.DropTable(
                name: "TypeLeaves");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
