using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ecsCore.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    DebugToken = table.Column<string>(nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    SecurityType = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(maxLength: 255, nullable: false),
                    Address2 = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityCreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CC = table.Column<string>(maxLength: 50, nullable: false),
                    Code = table.Column<int>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    ExpirationMonth = table.Column<string>(maxLength: 2, nullable: false),
                    ExpirationYear = table.Column<string>(maxLength: 4, nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityCreditCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityCreditCards_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityEmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityEmails_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    First = table.Column<string>(maxLength: 255, nullable: true),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    Last = table.Column<string>(maxLength: 255, nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    Middle = table.Column<string>(maxLength: 50, nullable: true),
                    NameType = table.Column<int>(nullable: false),
                    Prefix = table.Column<string>(maxLength: 5, nullable: true),
                    Salutation = table.Column<string>(maxLength: 5, nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    Suffix = table.Column<string>(maxLength: 5, nullable: true),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityNames_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityPhone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityPhone_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityRelationships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    RelatedEntityId = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityRelationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityRelationships_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntitySocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Guid = table.Column<Guid>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDirty = table.Column<bool>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    LastEditUserId = table.Column<int>(nullable: false),
                    Login = table.Column<string>(maxLength: 255, nullable: false),
                    PW = table.Column<string>(maxLength: 255, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SubType1 = table.Column<int>(nullable: false),
                    SubType2 = table.Column<int>(nullable: false),
                    SystemOwnerID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitySocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntitySocialMedia_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_EntityId",
                table: "EntityAddresses",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityCreditCards_EntityId",
                table: "EntityCreditCards",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityEmails_EntityId",
                table: "EntityEmails",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityNames_EntityId",
                table: "EntityNames",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityPhone_EntityId",
                table: "EntityPhone",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityRelationships_EntityId",
                table: "EntityRelationships",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntitySocialMedia_EntityId",
                table: "EntitySocialMedia",
                column: "EntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityAddresses");

            migrationBuilder.DropTable(
                name: "EntityCreditCards");

            migrationBuilder.DropTable(
                name: "EntityEmails");

            migrationBuilder.DropTable(
                name: "EntityNames");

            migrationBuilder.DropTable(
                name: "EntityPhone");

            migrationBuilder.DropTable(
                name: "EntityRelationships");

            migrationBuilder.DropTable(
                name: "EntitySocialMedia");

            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
