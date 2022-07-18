using Kantaiko.Hosting.Modularity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Replikit.Examples.EntityFrameworkCore;

internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .AddModule<EfCoreExampleModule>()
            .ConfigureAppConfiguration(x => x.AddUserSecrets<ApplicationDbContext>())
            .Build();

        var configuration = host.Services.GetRequiredService<IConfiguration>();

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseNpgsql(configuration.GetConnectionString("Default")!);

        return new ApplicationDbContext(builder.Options, host.Services);
    }
}
