using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Utmaning
{
    enum Country
    {
        Sweden,
        Norway,
        Denmark,
        Finland,
        USA,
        Japan
    }

    class Platform
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int MaxLocalPlayers { get; set; }
        public bool IsHandheld { get; set; }
        public List<Game> Games { get; set; }

        public Publisher Publisher { get; set; }
    }

    class Game
    {
        public int Id { get; set; }
        public int PlatformId { get; set; }

        public int PublisherId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public int ReleaseYear { get; set; }
        public decimal Cost { get; set; }

        public Platform Platform { get; set; }

        public Publisher Publisher { get; set; }
    }

    class Publisher
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public Country Country { get; set; }

        public int NetWorth { get; set; }

        public List<Platform> Platforms { get; set; }

        public List<Game> Games { get; set; }
    }
}
