using GLSI_D.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GLSI_D
{
    public class DBcontext: DbContext
    {
        public DbSet<Trajet> Trajets { get; set; }
        public DbSet<Sejour> Sejours { get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<Transporteur> Transporteurs{ get; set; }
        public DbSet<Parcour> Parcours { get; set; }
        public DbSet<Accompengateur> Accompengateurs { get; set; }

        public DBcontext(DbContextOptions options) : base(options)
        {


        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Voyage>()
         .HasDiscriminator<int>("TypeVoyage")
         .HasValue<Sejour>(1)
         .HasValue<Circuit>(2);
      
            
        }
        }
}