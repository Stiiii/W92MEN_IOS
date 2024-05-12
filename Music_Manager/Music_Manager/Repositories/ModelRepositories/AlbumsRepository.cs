using System.Linq;
using Music_Manager.Models;
using Music_Manager.Data;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Repositories.ModelRepositories
{ 
    public class AlbumsRepository : Repository<Albums>, IRepository<Albums>
    {

        public AlbumsRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override Albums Read(int id)
        {
            return ctx.Albums.FirstOrDefault(t => t.AlbumId == id);
        }

        public override void Update(Albums item)
        {
            ctx.Albums.Update(item);
            ctx.SaveChanges();
        }
    }
}
