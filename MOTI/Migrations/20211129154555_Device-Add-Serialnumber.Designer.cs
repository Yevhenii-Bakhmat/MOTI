﻿// <auto-generated />
using System;
using MOTI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MOTI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211129154555_Device-Add-Serialnumber")]
    partial class DeviceAddSerialnumber
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("MOTI.Models.ClimateSetting", b =>
                {
                    b.Property<int>("ClimateSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Expression")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PresetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Units")
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("ClimateSettingId");

                    b.HasIndex("PresetId");

                    b.ToTable("ClimateSettings");
                });

            modelBuilder.Entity("MOTI.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Power")
                        .HasColumnType("REAL");

                    b.Property<int?>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("DeviceId");

                    b.HasIndex("RoomId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("MOTI.Models.Preset", b =>
                {
                    b.Property<int>("PresetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("PresetId");

                    b.ToTable("Presets");
                });

            modelBuilder.Entity("MOTI.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MOTI.Models.ClimateSetting", b =>
                {
                    b.HasOne("MOTI.Models.Preset", null)
                        .WithMany("Settings")
                        .HasForeignKey("PresetId");
                });

            modelBuilder.Entity("MOTI.Models.Device", b =>
                {
                    b.HasOne("MOTI.Models.Room", null)
                        .WithMany("Devices")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("MOTI.Models.Preset", b =>
                {
                    b.Navigation("Settings");
                });

            modelBuilder.Entity("MOTI.Models.Room", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
