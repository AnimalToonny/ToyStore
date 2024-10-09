using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToyStore.DataAccess.Entities;
using ToyStore.Core.Models;

namespace ToyStore.DataAccess.Configurations
{
    public class ToysCondiguration : IEntityTypeConfiguration<ToyEntity>
    {
        public void Configure(EntityTypeBuilder<ToyEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(Toy.MaxSize)
                .IsRequired();

            builder.Property(b => b.Price)
                .IsRequired();
        }
    }
}
