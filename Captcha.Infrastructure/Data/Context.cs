using Captcha.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Captcha.Infrastructure.Data
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        DbSet<MousePositionData> mousePositionData {  get; set; }
    }
}
