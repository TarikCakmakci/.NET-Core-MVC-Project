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
    [Migration("20220408154620_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Deneyimler", b =>
                {
                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CalismaSekli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sure")
                        .HasColumnType("int");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sektor");

                    b.ToTable("Deneyimler");
                });

            modelBuilder.Entity("EntityLayer.Concrete.EgitimBilgileri", b =>
                {
                    b.Property<string>("Universite")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bolum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fakulte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sinif")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Universite");

                    b.ToTable("EgitimBilgileri");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Iletisim", b =>
                {
                    b.Property<int>("CepTelefonNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogSayfasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSayfasi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CepTelefonNo");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kimlik", b =>
                {
                    b.Property<long>("KimlikNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AktivasyonTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("DogumYeri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KayitTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilFotografi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KimlikNo");

                    b.ToTable("Kimlik");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.Property<int>("KimlikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KimlikID");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yetkinlikler", b =>
                {
                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CalismaSekli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sure")
                        .HasColumnType("int");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sektor");

                    b.ToTable("Yetkinlikler");
                });
#pragma warning restore 612, 618
        }
    }
}
