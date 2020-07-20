using System;
using Microsoft.EntityFrameworkCore;
using ShinaMashina.Data.Postgres.Entities;

namespace ShinaMashina.Data.Postgres
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DataContext(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
            // TODO убрать?
            Database.EnsureCreated();
        }

        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        public DbSet<ProductEntity> ProductEntities { get; set; }
        public DbSet<PropertyEntity> PropertyEntities { get; set; }
        public DbSet<PropertyValueEntity> PropertyValueEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // TODO сконфигурировать?
            builder.Entity<CategoryEntity>()
                .ToTable("Category");

            builder.Entity<ProductEntity>()
                .ToTable("Product");

            builder.Entity<PropertyEntity>()
                .ToTable("Property");

            builder.Entity<PropertyValueEntity>()
                .ToTable("PropertyValue");

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            //, options =>
            //{
            //    options.SetPostgresVersion(new Version(9, 6));
            //});
        }

        //public void Configure(EntityTypeBuilder<RawMetadataEntity> builder)
        //{
        //    builder.ToTable("storage_devices");

        //    builder.HasKey(x => x.DeviceId)
        //        .HasName("pk_storage_devices");

        //    builder.Property(x => x.DeviceId)
        //        .HasColumnName("database_device_id");
        //    builder.Property(x => x.DeviceTypeId)
        //        .HasColumnName("device_type_id");
        //    builder.Property(x => x.SerialId)
        //        .HasColumnName("serial_id")
        //        .HasMaxLength(64);
        //}
    }
}
