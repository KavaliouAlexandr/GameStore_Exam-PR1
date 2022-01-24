using System.Collections.Generic;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }

        public void IfObjects()
        {
            List<Game> db = new List<Game>();
            foreach (var item in Games)
                db.Add(item);


            DbObjects def = new DbObjects();
            int n;
            foreach (var item in def.DefGames)
            {
                n = 0;
                foreach (var dbitem in db)
                {
                    if (dbitem.Name == item.Name)
                        n++;
                }
                if (n == 0)
                {
                    db.Add(item);
                    Games.Add(item);
                    SaveChanges();
                }
            }
        }
    }
}