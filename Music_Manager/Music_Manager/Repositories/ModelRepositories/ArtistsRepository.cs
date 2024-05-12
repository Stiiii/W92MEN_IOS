using System.Linq;
using Music_Manager.Models;
using Music_Manager.Data;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Repositories.ModelRepositories
{
    public class ArtistsRepository : Repository<Artists>, IRepository<Artists>
    {

        public ArtistsRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override Artists Read(int id)
        {
            return ctx.Artists.FirstOrDefault(t => t.ArtistsId == id);
        }

        public override void Update(Artists item)
        {
            ctx.Artists.Update(item);
            ctx.SaveChanges();
        }
    }
}
