using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using kinksrp.Areas.Wow.Models;

namespace kinksrp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.AccessGroup", b =>
                {
                    b.Property<int>("AccessGroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AccessGroupID");

                    b.ToTable("AccessGroups");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<int>("PostID");

                    b.Property<int>("UserID");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<int>("SectionID");

                    b.HasKey("PostID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SectionID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessGroupID");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
        }
    }
}
