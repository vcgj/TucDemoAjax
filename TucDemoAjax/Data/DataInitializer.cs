using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace TucDemoAjax.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDataContext.ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            if (dbContext.Teams.Count() == 0)
            {
                dbContext.Teams.Add(new Team {Name = "Brynäs IF"});
                dbContext.Teams.Add(new Team { Name = "Djurgårdens IF" });
                dbContext.Teams.Add(new Team { Name = "Frölunda HC" });
                dbContext.Teams.Add(new Team { Name = "Färjestads BK" });
                dbContext.Teams.Add(new Team { Name = "IK Oskarshamn" });
                dbContext.Teams.Add(new Team { Name = "Leksands IF" });
                dbContext.Teams.Add(new Team { Name = "Linköping HC" });
                dbContext.Teams.Add(new Team { Name = "Luleå HF" });
                dbContext.Teams.Add(new Team { Name = "Malmö Redhawks" });
                dbContext.Teams.Add(new Team { Name = "Rögle BK" });
                dbContext.Teams.Add(new Team { Name = "Skellefteå AIK" });
                dbContext.Teams.Add(new Team { Name = "Timrå IK" });
                dbContext.Teams.Add(new Team { Name = "Växjö Lakers HC" });
                dbContext.Teams.Add(new Team { Name = "Örebro HK" });
                dbContext.SaveChanges();
            }

            if (dbContext.Games.Count() > 1000)
                return;

            var teams = dbContext.Teams.ToList();
            for (int i = 0; i < 1000; i++)
                AddGame(dbContext, teams);
            dbContext.SaveChanges();
        }

        static Random rnd = new Random();
        private static void AddGame(ApplicationDataContext.ApplicationDbContext dbContext, List<Team> teams)
        {
            var cnt = teams.Count();
            var first = rnd.Next(0, cnt);
            var second = first + rnd.Next(1, cnt-1);
            var team1 = teams[first];
            var team2 = teams[second % cnt];

            if (team1.Id == team2.Id)
            {
                int t;
                t = 123;
            }

            var newGame = new Game
            {
                Away = team2,
                Home = team1,
                Awayscores = rnd.Next(0,7),
                Homescores = rnd.Next(0, 8),
                Date = DateTime.Now.AddDays(-rnd.Next(1,300)),
                Spectators = rnd.Next(1000,10000)
            };
            dbContext.Games.Add(newGame);
        }
    }
}