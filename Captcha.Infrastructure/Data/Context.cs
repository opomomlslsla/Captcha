using Captcha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Captcha.Infrastructure.Data
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MousePositionData>().OwnsOne(
                m => m.PositionsData,
                builder =>
                {
                    builder.ToJson();
                }
                );
        }


        DbSet<MousePositionData> mousePositionData {  get; set; }
    }
}
