﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucHanh.Migrations
{
    [DbContext(typeof(LTQDD))]
    [Migration("20240616134827_AXL1")]
    partial class AXL1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BaiThucHanh.Models.SinhVien", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lophoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tensinhvien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Masinhvien");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
