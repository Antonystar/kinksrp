using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using kinksrp.Areas.Wow.Models;

namespace kinksrp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170217140311_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.AccessGroup", b =>
                {
                    b.Property<int>("AccessGroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AccessFlags");

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

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.MessageLike", b =>
                {
                    b.Property<int>("MessageLikeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MessageID");

                    b.Property<bool>("Up");

                    b.Property<int>("UserID");

                    b.HasKey("MessageLikeID");

                    b.HasIndex("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("MessageLikes");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<int>("SectionID");

                    b.Property<int>("UserID");

                    b.HasKey("PostID");

                    b.HasIndex("SectionID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.PostLike", b =>
                {
                    b.Property<int>("PostLikeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostID");

                    b.Property<bool>("Up");

                    b.Property<int>("UserID");

                    b.HasKey("PostLikeID");

                    b.HasIndex("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("PostLikes");
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

                    b.Property<byte[]>("Avatar");

                    b.Property<byte[]>("Background");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Reputation");

                    b.HasKey("UserID");

                    b.HasIndex("AccessGroupID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.UserProfileLike", b =>
                {
                    b.Property<int>("UserProfileLikeID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Up");

                    b.Property<int>("UserID");

                    b.Property<int>("UserProfileID");

                    b.HasKey("UserProfileLikeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserProfileLikes");
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Message", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kinksrp.Areas.Wow.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.MessageLike", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kinksrp.Areas.Wow.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.Post", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kinksrp.Areas.Wow.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.PostLike", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kinksrp.Areas.Wow.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.User", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.AccessGroup", "AccessGroup")
                        .WithMany()
                        .HasForeignKey("AccessGroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kinksrp.Areas.Wow.Models.UserProfileLike", b =>
                {
                    b.HasOne("kinksrp.Areas.Wow.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
