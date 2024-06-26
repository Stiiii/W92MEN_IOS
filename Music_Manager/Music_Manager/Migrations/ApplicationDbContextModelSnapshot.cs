﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Music_Manager.Data;

#nullable disable

namespace Music_Manager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Music_Manager.Models.Albums", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"), 1L, 1);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            AlbumName = "NellyVille",
                            ArtistId = 3,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/9/9c/Nelly_-_Nellyville_-_Album.jpg"
                        },
                        new
                        {
                            AlbumId = 2,
                            AlbumName = "Black Ice",
                            ArtistId = 1,
                            ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FBlack_Ice_%2528album%2529&psig=AOvVaw2tHjnbe0pICVpdfcmifv4R&ust=1683288077764000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIDt6_HO2_4CFQAAAAAdAAAAABAE"
                        },
                        new
                        {
                            AlbumId = 3,
                            AlbumName = "BallBreaker",
                            ArtistId = 1,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/5/52/Ballbreaker.jpg"
                        },
                        new
                        {
                            AlbumId = 4,
                            AlbumName = "October",
                            ArtistId = 2,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/hu/thumb/3/37/U2_-_October_%28album_cover%29.png/200px-U2_-_October_%28album_cover%29.png"
                        },
                        new
                        {
                            AlbumId = 5,
                            AlbumName = "Tonight’s the Night",
                            ArtistId = 5,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/01/Neil_Young_TTN_cover.jpg"
                        },
                        new
                        {
                            AlbumId = 6,
                            AlbumName = "New York Dolls",
                            ArtistId = 6,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/0/05/NewYorkDollsNewYorkDolls.jpg"
                        },
                        new
                        {
                            AlbumId = 7,
                            AlbumName = "Full Moon Fever",
                            ArtistId = 7,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/4/4d/Tom_Petty_Full_Moon_Fever.jpg"
                        },
                        new
                        {
                            AlbumId = 8,
                            AlbumName = "So",
                            ArtistId = 8,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/a/a4/So_%28album%29.png"
                        },
                        new
                        {
                            AlbumId = 9,
                            AlbumName = "Rust Never Sleeps",
                            ArtistId = 5,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/4/47/Neil_Young_Rust_Never_Sleeps.jpg"
                        },
                        new
                        {
                            AlbumId = 10,
                            AlbumName = "Rock or Bust",
                            ArtistId = 1,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/7f/Rock_or_Bust.jpg"
                        },
                        new
                        {
                            AlbumId = 11,
                            AlbumName = "Wildflowers",
                            ArtistId = 7,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/d/d8/Tom_Petty_Wildflowers.jpg"
                        },
                        new
                        {
                            AlbumId = 12,
                            AlbumName = "Melodrama",
                            ArtistId = 4,
                            ImageURL = "https://assets.vogue.com/photos/58b9984661298051ac278def/master/w_2560%2Cc_limit/00-holding-lorde-album-art.jpg"
                        },
                        new
                        {
                            AlbumId = 13,
                            AlbumName = "Pure Heroin",
                            ArtistId = 4,
                            ImageURL = "https://i1.sndcdn.com/artworks-XuJCK0uDVz0QDk6T-1Y3n8A-t500x500.jpg"
                        },
                        new
                        {
                            AlbumId = 14,
                            AlbumName = "Red Patent Leather",
                            ArtistId = 6,
                            ImageURL = "https://m.media-amazon.com/images/I/51xJhANpe4L._SY350_.jpg"
                        },
                        new
                        {
                            AlbumId = 15,
                            AlbumName = "Butterflyin'",
                            ArtistId = 6,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/thumb/1/16/Mariah_Carey_Butterfly_1997_album_cover.png/220px-Mariah_Carey_Butterfly_1997_album_cover.png"
                        });
                });

            modelBuilder.Entity("Music_Manager.Models.Artists", b =>
                {
                    b.Property<int>("ArtistsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistsId"), 1L, 1);

                    b.Property<string>("ArtistsName")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistsId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistsId = 1,
                            ArtistsName = "AC/DC",
                            Description = "Australian rock band formed in Sydney, New South Wales, Australia in 1973 by Scottish-born brothers"
                        },
                        new
                        {
                            ArtistsId = 2,
                            ArtistsName = "U2",
                            Description = "U2 are an Irish rock band from Dublin, formed in 1976."
                        },
                        new
                        {
                            ArtistsId = 3,
                            ArtistsName = "Nelly",
                            Description = "Nelly, is an American rapper, singer, actor and entrepreneur."
                        },
                        new
                        {
                            ArtistsId = 4,
                            ArtistsName = "Lorde",
                            Description = "Lorde, byname of Ella Marija Lani Yelich-O’Connor, (born November 7, 1996, Takapuna, New Zealand), New Zealand singer-songwriter"
                        },
                        new
                        {
                            ArtistsId = 5,
                            ArtistsName = "Neil Young",
                            Description = "Canadian rock singer and songwriter."
                        },
                        new
                        {
                            ArtistsId = 6,
                            ArtistsName = "New York Dolls",
                            Description = "New York Dolls were an American rock band formed in New York City in 1971."
                        },
                        new
                        {
                            ArtistsId = 7,
                            ArtistsName = "Tom Petty",
                            Description = "Thomas Earl Petty (October 20, 1950 – October 2, 2017) was an American musician who was the lead vocalist and guitarist of the rock band Tom Petty and the Heartbreakers"
                        },
                        new
                        {
                            ArtistsId = 8,
                            ArtistsName = "Peter Gabriel",
                            Description = "Peter Brian Gabriel (born 13 February 1950) is an English musician, singer, songwriter, record producer and activist."
                        });
                });

            modelBuilder.Entity("Music_Manager.Models.Ratings", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"), 1L, 1);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("RatingId");

                    b.HasIndex("AlbumId")
                        .IsUnique();

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            AlbumId = 1,
                            Rating = 5.0
                        },
                        new
                        {
                            RatingId = 2,
                            AlbumId = 2,
                            Rating = 3.0
                        },
                        new
                        {
                            RatingId = 3,
                            AlbumId = 3,
                            Rating = 3.5
                        },
                        new
                        {
                            RatingId = 4,
                            AlbumId = 4,
                            Rating = 4.0
                        },
                        new
                        {
                            RatingId = 5,
                            AlbumId = 5,
                            Rating = 2.0
                        },
                        new
                        {
                            RatingId = 6,
                            AlbumId = 6,
                            Rating = 1.0
                        },
                        new
                        {
                            RatingId = 7,
                            AlbumId = 7,
                            Rating = 3.2000000000000002
                        },
                        new
                        {
                            RatingId = 8,
                            AlbumId = 8,
                            Rating = 3.0
                        },
                        new
                        {
                            RatingId = 9,
                            AlbumId = 9,
                            Rating = 5.0
                        },
                        new
                        {
                            RatingId = 10,
                            AlbumId = 10,
                            Rating = 3.0
                        },
                        new
                        {
                            RatingId = 11,
                            AlbumId = 11,
                            Rating = 3.5
                        },
                        new
                        {
                            RatingId = 12,
                            AlbumId = 12,
                            Rating = 4.9000000000000004
                        },
                        new
                        {
                            RatingId = 13,
                            AlbumId = 13,
                            Rating = 2.0
                        },
                        new
                        {
                            RatingId = 14,
                            AlbumId = 14,
                            Rating = 1.0
                        });
                });

            modelBuilder.Entity("Music_Manager.Models.SiteUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "4c38ab3a-17db-48bd-8651-2fe426c469a5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95e79a84-ed90-4355-9bbe-f4c16d5cd8a2",
                            Email = "szalai@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Szalai",
                            LastName = "Istvan",
                            LockoutEnabled = false,
                            NormalizedUserName = "SZALAI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO33ig0SfXs4mEYHBD6ZMpk/L1qpyUCv1TQcgHKb5E7l+6U85onC9ts4DNmIjzpl8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "51bc702a-597c-45da-bbc6-ac752eb68202",
                            TwoFactorEnabled = false,
                            UserName = "szalai@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Music_Manager.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Music_Manager.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Music_Manager.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Music_Manager.Models.SiteUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Manager.Models.Albums", b =>
                {
                    b.HasOne("Music_Manager.Models.Artists", "Artists")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artists");
                });

            modelBuilder.Entity("Music_Manager.Models.Ratings", b =>
                {
                    b.HasOne("Music_Manager.Models.Albums", "Albums")
                        .WithOne("Ratings")
                        .HasForeignKey("Music_Manager.Models.Ratings", "AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Music_Manager.Models.Albums", b =>
                {
                    b.Navigation("Ratings")
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Manager.Models.Artists", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
