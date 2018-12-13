using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PingPong_Game.Models;

namespace PingPong_Player.Models
{
    public class PingPong_PlayerContext : DbContext
    {
        public PingPong_PlayerContext (DbContextOptions<PingPong_PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<PingPong_Game.Models.GameModel> GameModel { get; set; }
    }
}
