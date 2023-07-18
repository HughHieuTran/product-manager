using System;
using System.Collections.Generic;
using product_manage.Model;
using Microsoft.EntityFrameworkCore;

namespace product_manage.Repository;

public partial class DbManagerContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbManagerContext()
    {
    }

    public DbManagerContext(DbContextOptions<DbManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductimage> TblProductimages { get; set; }

    public virtual DbSet<TblRefreshtoken> TblRefreshtokens { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
