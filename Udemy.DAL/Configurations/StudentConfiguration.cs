using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Core.Entities;

namespace Udemy.DAL.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s=>s.Name).IsRequired().HasMaxLength(64);
            builder.Property(s=>s.Surname).IsRequired().HasMaxLength(64);
            builder.Property(s => s.Age).IsRequired();


        }
    }
}
