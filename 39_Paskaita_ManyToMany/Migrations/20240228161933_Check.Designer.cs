﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _39_Paskaita_ManyToMany;

#nullable disable

namespace _39_Paskaita_ManyToMany.Migrations
{
    [DbContext(typeof(FileContext))]
    [Migration("20240228161933_Check")]
    partial class Check
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FileInformationFolder", b =>
                {
                    b.Property<int>("FileFoldersId")
                        .HasColumnType("int");

                    b.Property<int>("FolderFileInformationId")
                        .HasColumnType("int");

                    b.HasKey("FileFoldersId", "FolderFileInformationId");

                    b.HasIndex("FolderFileInformationId");

                    b.ToTable("FileInformationFolder");
                });

            modelBuilder.Entity("_39_Paskaita_ManyToMany.Models.FileInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FolderId")
                        .HasColumnType("int");

                    b.Property<string>("FullPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("_39_Paskaita_ManyToMany.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentFolderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Folders");
                });

            modelBuilder.Entity("FileInformationFolder", b =>
                {
                    b.HasOne("_39_Paskaita_ManyToMany.Models.Folder", null)
                        .WithMany()
                        .HasForeignKey("FileFoldersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_39_Paskaita_ManyToMany.Models.FileInformation", null)
                        .WithMany()
                        .HasForeignKey("FolderFileInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
