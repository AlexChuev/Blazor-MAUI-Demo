using BlazorDemo.Shared.Data.DataProviders;
using BlazorDemo.Shared.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Server.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddIssueServices(this IServiceCollection services) {
            services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            services.AddScoped<IssuesDataService>();
            //services.AddDbContextFactory<IssuesContext>(opt => {
            //    opt.UseSqlite($"Data Source={Path.Combine(System.AppContext.BaseDirectory, "DataSources", "issue-list.db")}");
            //});
        }
    }
}
