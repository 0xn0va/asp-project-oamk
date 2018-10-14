using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_project_oamk.Models
{
    public class IMDBContext : DbContext
    {
        public IMDBContext() : base("IMDBContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Actor>()
                 .HasMany<Movie>(a => a.Movies)
                 .WithMany(m => m.Actors)
                 .Map(am =>
                 {
                     am.MapLeftKey("intActorId");
                     am.MapRightKey("intMovieId");
                     am.ToTable("ActorMovie");
                 });

            modelBuilder.Entity<Movie>()
                .HasRequired<Producer>(m => m.Producer)
                .WithMany(x => x.Movies)
                .HasForeignKey<int>(m => m.ProducerId);

        }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}