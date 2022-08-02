﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterClone.Infrastructure.Persistence;

#nullable disable

namespace TwitterClone.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(TwitterCloneDbContext))]
    [Migration("20220802234132_addUserDescriptionCollumns")]
    partial class addUserDescriptionCollumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TwitterClone.Core.Entites.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPostOwner")
                        .HasColumnType("int");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPostOwner");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCommentOwner")
                        .HasColumnType("int");

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCommentOwner");

                    b.HasIndex("IdPost");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.Post", b =>
                {
                    b.HasOne("TwitterClone.Core.Entites.User", "PostOwner")
                        .WithMany("Posts")
                        .HasForeignKey("IdPostOwner")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PostOwner");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.PostComment", b =>
                {
                    b.HasOne("TwitterClone.Core.Entites.User", "CommentOwner")
                        .WithMany("Comments")
                        .HasForeignKey("IdCommentOwner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TwitterClone.Core.Entites.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("IdPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommentOwner");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TwitterClone.Core.Entites.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
