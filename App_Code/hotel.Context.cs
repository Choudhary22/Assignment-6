﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class hotelEntities : DbContext
{
    public hotelEntities()
        : base("name=hotelEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<adminlogin> adminlogins { get; set; }
    public DbSet<book> books { get; set; }
    public DbSet<contactu> contactus { get; set; }
    public DbSet<register> registers { get; set; }
}
