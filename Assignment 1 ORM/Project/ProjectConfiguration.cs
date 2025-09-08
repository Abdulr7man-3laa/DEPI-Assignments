using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(50)")
                .HasDefaultValue("OurProject")
                .IsRequired();

            builder.Property(p => p.Cost)
                .HasColumnType("money");

            builder.HasCheckConstraint("CK_Project_Cost_Range", "Cost >= 500000 AND Cost <= 3500000");

        }
    }
}
