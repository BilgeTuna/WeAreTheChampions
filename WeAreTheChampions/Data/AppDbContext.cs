using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WeAreTheChampions.Models;
using Match = WeAreTheChampions.Models.Match;

namespace WeAreTheChampions.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=WeAreTheChampionsDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamColor>().HasKey(k => new { k.TeamId, k.ColorId });


            modelBuilder.Entity<Match>()//match entitysi
                        .HasRequired(m => m.Team1)//zorunlu takım1
                        .WithMany(t => t.Team1Matches)//birden çok maç
                        .HasForeignKey(m => m.Team1Id)//takım maçından takım1 e referans veren Foreign key'ı Team1Id dir.
                        .WillCascadeOnDelete(false);//team1 silinirse bağlı olduğu maçı silme 

            modelBuilder.Entity<Match>()//match entitsi
                        .HasRequired(m => m.Team2)//zorunlu takım2
                        .WithMany(t => t.Team2Matches)//birden çok maç
                        .HasForeignKey(m => m.Team2Id)//takım2 maçından takım2 ye referans veren Fk'sı Team2Id dir
                        .WillCascadeOnDelete(false);//team2 silinirse bağlı olduğu maçı silme 
        }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
