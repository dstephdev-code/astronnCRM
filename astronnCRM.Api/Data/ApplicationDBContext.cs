using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : IdentityDbContext<astronnCRM.Api.Data.ApplicationUser>(options)
{
}
