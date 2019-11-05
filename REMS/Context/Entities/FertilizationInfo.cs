﻿using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace REMS.Context.Entities
{
    public class FertilizationInfo : BaseEntity
    {
        public FertilizationInfo() : base()
        { }

        public int FertilizationInfoId { get; set; }

        public int? FertilizationId { get; set; }

        public string Variable { get; set; }

        public string Value { get; set; }


        public virtual Fertilization Fertilization { get; set; }

        public override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FertilizationInfo>(entity =>
            {
                // Define the primary key
                entity.HasKey(e => e.FertilizationInfoId)
                    .HasName("PrimaryKey");

                // Define the table indices
                entity.HasIndex(e => e.FertilizationInfoId)
                    .HasName("FertilizationInfoId")
                    .IsUnique();

                entity.HasIndex(e => e.FertilizationId)
                    .HasName("FertilizationInfoFertilizationId");

                entity.HasIndex(e => e.Variable)
                    .HasName("FertilizationInfoVariable");

                // Define the table properties
                entity.Property(e => e.FertilizationInfoId)
                    .HasColumnName("FertilizationInfoId");

                entity.Property(e => e.FertilizationId)
                    .HasColumnName("FertilizationId");

                entity.Property(e => e.Value)
                    .HasColumnName("Value")
                    .HasMaxLength(20);

                entity.Property(e => e.Variable)
                    .HasColumnName("Variable")
                    .HasMaxLength(20);

                // Define foreign key constraints
                entity.HasOne(d => d.Fertilization)
                    .WithMany(p => p.FertilizationInfo)
                    .HasForeignKey(d => d.FertilizationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FertilizationInfoFertilizationId");
            });
        }
    }
}