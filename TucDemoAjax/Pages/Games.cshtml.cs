using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TucDemoAjax.Data;

namespace TucDemoAjax.Pages
{
    public class GamesModel : PageModel
    {
        private readonly ApplicationDataContext.ApplicationDbContext _dbContext;

        public GamesModel(ApplicationDataContext.ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<GameListItem> GameListItems { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public class GameListItem
        {
            public int Id { get; set; }
            public string Hometeam { get; set; }
            public string Awayteam { get; set; }
            public int HomeScores { get; set; }
            public int AwayScores { get; set; }
            public string Datum { get; set; }
        }
        public void OnGet()
        {
            
            GameListItems = _dbContext.Games.OrderByDescending(r=>r.Date)
                .Select(r => new GameListItem
            {
                    Id = r.Id,
                    AwayScores = r.Awayscores,
                    Awayteam = r.Away.Name,
                    Datum = r.Date.ToString("yyyy-MM-dd"),
                    HomeScores = r.Homescores,
                    Hometeam = r.Home.Name

            }).ToList();
        }
    }
}
