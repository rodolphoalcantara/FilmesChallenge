using FilmesChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesChallenge.Data.Mapping
{
    public class VideoMap : IEntityTypeConfiguration<VideoEntity>
    {
        public void Configure(EntityTypeBuilder<VideoEntity> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Titulo)
                   .IsRequired();

            builder.Property(v => v.Descricao)
                   .IsRequired();

            builder.Property(v => v.URL)
                   .IsRequired();
        }
    }
}
