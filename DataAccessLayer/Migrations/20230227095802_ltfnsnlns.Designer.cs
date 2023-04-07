﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230227095802_ltfnsnlns")]
    partial class ltfnsnlns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EntityLayer.Concrete.Agent", b =>
                {
                    b.Property<int>("AgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AgentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgentPhone")
                        .HasColumnType("int");

                    b.Property<string>("AgentPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentSocialMedia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentID");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ContactWithAgent", b =>
                {
                    b.Property<int>("ContactWithAgentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactWithAgentID");

                    b.ToTable("ContactWithAgents");
                });

            modelBuilder.Entity("EntityLayer.Concrete.New", b =>
                {
                    b.Property<int>("NewsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewsPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Propertie", b =>
                {
                    b.Property<int>("PropertieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AgentID")
                        .HasColumnType("int");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<bool>("Balcony")
                        .HasColumnType("bit");

                    b.Property<int>("Bath")
                        .HasColumnType("int");

                    b.Property<int>("Bed")
                        .HasColumnType("int");

                    b.Property<bool>("CableTV")
                        .HasColumnType("bit");

                    b.Property<bool>("ConcreteFlooring")
                        .HasColumnType("bit");

                    b.Property<bool>("Deck")
                        .HasColumnType("bit");

                    b.Property<int>("Garage")
                        .HasColumnType("int");

                    b.Property<bool>("Internet")
                        .HasColumnType("bit");

                    b.Property<bool>("OutdoorKitchen")
                        .HasColumnType("bit");

                    b.Property<bool>("Parking")
                        .HasColumnType("bit");

                    b.Property<string>("PropertieFloorPlans")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieGridPhoto1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieGridPhoto2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieIntroPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieMainPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertiePrice")
                        .HasColumnType("int");

                    b.Property<string>("PropertieType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertieVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SportCourts")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SunRoom")
                        .HasColumnType("bit");

                    b.Property<string>("Ubication")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertieID");

                    b.HasIndex("AgentID");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Testimonial", b =>
                {
                    b.Property<int>("TestimonialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TestimonialMiniPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialID");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Propertie", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Agent", "Agent")
                        .WithMany("Properties")
                        .HasForeignKey("AgentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Agent", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
