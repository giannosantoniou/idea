namespace FPP_Library
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base(Types.DBSettings.CS)
        {
        }

        public virtual DbSet<Fire> Fires { get; set; } 
        public virtual DbSet<ForecastPoint> ForecastPoints { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StationOriginal> StationOriginals { get; set; }
        public virtual DbSet<Temperature> Temperatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fire>()
                .Property(e => e.HR)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Station>()
                .Property(e => e.Lan)
                .HasPrecision(18, 9);

            modelBuilder.Entity<Station>()
                .Property(e => e.Lng)
                .HasPrecision(18, 9);

            modelBuilder.Entity<StationOriginal>()
                .Property(e => e.Lan)
                .HasPrecision(18, 5);

            modelBuilder.Entity<StationOriginal>()
                .Property(e => e.Lng)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Highest)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Lowest)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Average)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Huminity)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Precipitation)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.Rain)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Temperature>()
                .Property(e => e.RainTotal24HR)
                .HasPrecision(18, 5);
        }
    }
}
