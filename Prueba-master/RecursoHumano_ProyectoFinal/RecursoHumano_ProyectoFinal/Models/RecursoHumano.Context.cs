﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RecursoHumano_ProyectoFinal.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class RecursoHumanoContainer : DbContext
{
    public RecursoHumanoContainer()
        : base("name=RecursoHumanoContainer")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Empleados> Empleados { get; set; }

    public virtual DbSet<Departamentos> Departamentos { get; set; }

    public virtual DbSet<Cargos> Cargos { get; set; }

    public virtual DbSet<Vacaciones> Vacaciones { get; set; }

    public virtual DbSet<Licencias> Licencias { get; set; }

    public virtual DbSet<Cal_Nomina> Cal_Nomina { get; set; }

    public virtual DbSet<Salida_Empleados> Salida_Empleados { get; set; }

    public virtual DbSet<Permisos> Permisos { get; set; }

}

}

