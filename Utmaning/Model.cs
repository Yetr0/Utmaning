using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Utmaning
{
    class Platform
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        public string Name { get; set; }

        public int Max_local_players { get; set; }

        public bool Is_handheld { get; set; }

        public List<Game> Games { get; set; }

        public Publisher Publisher { get; set; }
    }

    class Game
    {
        public int id { get; set; }

        public int PublisherId { get; set; }

        public string Name { get; set; }

        public int Release_year { get; set; }

        public decimal Cost { get; set; }

        public Platform Platform { get; set; }

        public Publisher Publisher { get; set; }
    }

    class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public int Net_worth { get; set; }

        public List<Platform> Platforms { get; set; }

        public List<Game> Games { get; set; }
    }
}
