using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Music_Manager.Models;

namespace Music_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext<SiteUser>
    {
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
                );

            PasswordHasher<SiteUser> ph = new PasswordHasher<SiteUser>();
            SiteUser kovi = new SiteUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "szalai@gmail.com",
                EmailConfirmed = true,
                UserName = "szalai@gmail.com",
                NormalizedUserName = "SZALAI@GMAIL.COM",
                FirstName = "Szalai",
                LastName = "Istvan"
            };

            kovi.PasswordHash = ph.HashPassword(kovi, "almafa123");
            builder.Entity<SiteUser>().HasData(kovi);

            builder.Entity<Albums>(entity =>
            {
                entity.HasOne(x => x.Artists)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.ArtistId);
            });

            builder.Entity<Ratings>(entity =>
            {
                entity.HasOne(x => x.Albums);
            });
            builder.Entity<Artists>().HasData(new Artists[]
            {
                new Artists(1, "AC/DC", "Australian rock band formed in Sydney, New South Wales, Australia in 1973 by Scottish-born brothers"),
                new Artists(2, "U2", "U2 are an Irish rock band from Dublin, formed in 1976."),
                new Artists(3, "Nelly", "Nelly, is an American rapper, singer, actor and entrepreneur."),
                new Artists(4, "Lorde", "Lorde, byname of Ella Marija Lani Yelich-O’Connor, (born November 7, 1996, Takapuna, New Zealand), New Zealand singer-songwriter"),
                new Artists(5, "Neil Young", "Canadian rock singer and songwriter."),
                new Artists(6, "New York Dolls", "New York Dolls were an American rock band formed in New York City in 1971."),
                new Artists(7, "Tom Petty","Thomas Earl Petty (October 20, 1950 – October 2, 2017) was an American musician who was the lead vocalist and guitarist of the rock band Tom Petty and the Heartbreakers"),
                new Artists(8, "Peter Gabriel", "Peter Brian Gabriel (born 13 February 1950) is an English musician, singer, songwriter, record producer and activist."),

            });
            builder.Entity<Albums>().HasData(new Albums[]
            {
                new Albums(1, "NellyVille", 3, "https://upload.wikimedia.org/wikipedia/en/9/9c/Nelly_-_Nellyville_-_Album.jpg"),
                new Albums(2, "Black Ice", 1, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FBlack_Ice_%2528album%2529&psig=AOvVaw2tHjnbe0pICVpdfcmifv4R&ust=1683288077764000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIDt6_HO2_4CFQAAAAAdAAAAABAE"),
                new Albums(3, "BallBreaker", 1, "https://upload.wikimedia.org/wikipedia/en/5/52/Ballbreaker.jpg"),
                new Albums(4, "October", 2, "https://upload.wikimedia.org/wikipedia/hu/thumb/3/37/U2_-_October_%28album_cover%29.png/200px-U2_-_October_%28album_cover%29.png"),
                new Albums(5, "Tonight’s the Night", 5, "https://upload.wikimedia.org/wikipedia/en/0/01/Neil_Young_TTN_cover.jpg"),
                new Albums(6, "New York Dolls", 6, "https://upload.wikimedia.org/wikipedia/en/0/05/NewYorkDollsNewYorkDolls.jpg"),
                new Albums(7, "Full Moon Fever", 7, "https://upload.wikimedia.org/wikipedia/en/4/4d/Tom_Petty_Full_Moon_Fever.jpg"),
                new Albums(8, "So", 8, "https://upload.wikimedia.org/wikipedia/en/a/a4/So_%28album%29.png"),
                new Albums(9, "Rust Never Sleeps", 5, "https://upload.wikimedia.org/wikipedia/en/4/47/Neil_Young_Rust_Never_Sleeps.jpg"),
                new Albums(10, "Rock or Bust", 1, "https://upload.wikimedia.org/wikipedia/en/7/7f/Rock_or_Bust.jpg"),
                new Albums(11, "Wildflowers", 7, "https://upload.wikimedia.org/wikipedia/en/d/d8/Tom_Petty_Wildflowers.jpg"),
                new Albums(12, "Melodrama", 4, "https://assets.vogue.com/photos/58b9984661298051ac278def/master/w_2560%2Cc_limit/00-holding-lorde-album-art.jpg"),
                new Albums(13, "Pure Heroin", 4, "https://i1.sndcdn.com/artworks-XuJCK0uDVz0QDk6T-1Y3n8A-t500x500.jpg"),
                new Albums(14, "Red Patent Leather", 6, "https://m.media-amazon.com/images/I/51xJhANpe4L._SY350_.jpg"),
                new Albums(15, "Butterflyin'", 6, "https://upload.wikimedia.org/wikipedia/en/thumb/1/16/Mariah_Carey_Butterfly_1997_album_cover.png/220px-Mariah_Carey_Butterfly_1997_album_cover.png"),
            });
            builder.Entity<Ratings>().HasData(new Ratings[]
            {
                new Ratings(1, 1, 5),
                new Ratings(2, 2, 3),
                new Ratings(3, 3, 3.5),
                new Ratings(4, 4, 4),
                new Ratings(5, 5, 2),
                new Ratings(6, 6, 1),
                new Ratings(7, 7, 3.2),
                new Ratings(8, 8, 3),
                new Ratings(9, 9, 5),
                new Ratings(10, 10, 3),
                new Ratings(11, 11, 3.5),
                new Ratings(12, 12, 4.9),
                new Ratings(13, 13, 2),
                new Ratings(14, 14, 1),
            });
            base.OnModelCreating(builder);
        }
    }
}
