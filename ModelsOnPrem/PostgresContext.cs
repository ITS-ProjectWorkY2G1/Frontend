using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ModelsOnPrem;

public partial class PostgresContext : DbContext
{
    public DbSet<SmartwatchesOnPrem> _smartwatchesOnPrem { get; set; }

    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("host=192.168.103.7;database=postgres;username=postgres;password=password;", x => x.MigrationsHistoryTable("_MyMigrationHistory", "pw_gruppo1"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
