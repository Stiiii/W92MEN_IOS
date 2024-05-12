using System.Linq;
using Music_Manager.Models;
using Music_Manager.Data;
using Music_Manager.Repositories.Generic_Repository;

namespace Music_Manager.Repositories.ModelRepositories
{
    public class RatingsRepository : Repository<Ratings>, IRepository<Ratings>
    {

        public RatingsRepository(ApplicationDbContext ctx) : base(ctx)
        {
        }

        public override Ratings Read(int id)
        {
            return ctx.Ratings.FirstOrDefault(t => t.RatingId == id);
        }

        public override void Update(Ratings item)
        {
            ctx.Ratings.Update(item);
            ctx.SaveChanges();
        }
    }
}
