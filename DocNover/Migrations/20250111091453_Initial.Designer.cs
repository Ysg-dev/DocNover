﻿// <auto-generated />
using DocNover.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DocNover.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250111091453_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DocNover.Domain.Models.Document", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("document_file_extension");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("document_name");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("document_path");

                    b.Property<int>("TopicId")
                        .HasColumnType("int")
                        .HasColumnName("TopicId");

                    b.HasKey("id");

                    b.HasIndex("TopicId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DocNover.Domain.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("topic_name");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parent_topic_id");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("DocNover.Domain.Models.Document", b =>
                {
                    b.HasOne("DocNover.Domain.Models.Topic", null)
                        .WithMany("Documents")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocNover.Domain.Models.Topic", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
