using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ecsCore.Data;

namespace ecsCore.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ecsCore.Domain.POCO.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<int>("SecurityType");

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Address2")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SortOrder");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityAddresses");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityCreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CC")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Code")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<string>("ExpirationMonth")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("ExpirationYear")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityCreditCards");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("EntityId");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityEmails");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<string>("First")
                        .HasMaxLength(255);

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<string>("Last")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<string>("Middle")
                        .HasMaxLength(50);

                    b.Property<int>("NameType");

                    b.Property<string>("Prefix")
                        .HasMaxLength(5);

                    b.Property<string>("Salutation")
                        .HasMaxLength(5);

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<string>("Suffix")
                        .HasMaxLength(5);

                    b.Property<int>("SystemOwnerID");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityNames");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityPhone");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<int>("RelatedEntityId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityRelationships");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntitySocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("CreateUserId");

                    b.Property<string>("DebugToken");

                    b.Property<int>("EntityId");

                    b.Property<Guid>("Guid");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDirty");

                    b.Property<bool>("IsLocked");

                    b.Property<bool>("IsPrimary");

                    b.Property<DateTime>("LastEditDate");

                    b.Property<int>("LastEditUserId");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PW")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("SortOrder");

                    b.Property<int>("SubType1");

                    b.Property<int>("SubType2");

                    b.Property<int>("SystemOwnerID");

                    b.Property<int>("Type");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("EntitySocialMedia");
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityAddress", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("Addresses")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityCreditCard", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("CreditCards")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityEmail", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("Emails")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityName", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("Names")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityPhone", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("Phones")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntityRelationship", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("Relationships")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ecsCore.Domain.POCO.EntitySocialMedia", b =>
                {
                    b.HasOne("ecsCore.Domain.POCO.Entity", "Entity")
                        .WithMany("SocialMedia")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
