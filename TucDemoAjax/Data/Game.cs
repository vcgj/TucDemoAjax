using System;

namespace TucDemoAjax.Data
{
    public class Game
    {
        public int Id { get; set; }
        public Team Home { get; set; }
        public Team Away { get; set; }
        public int Homescores { get; set; }
        public int Awayscores { get; set; }
        public DateTime Date { get; set; }
        public int Spectators { get; set; }
    }
}