using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CreateGroup.Models;

public partial class SplitwiseContext : DbContext
{
    public SplitwiseContext()
    {
    }

    public SplitwiseContext(DbContextOptions<SplitwiseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__149AF30A455C7CB9");

            entity.ToTable("Group");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupMemberNames).HasMaxLength(100);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.GroupStatus)
                .HasMaxLength(10)
                .HasDefaultValue("Active");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
