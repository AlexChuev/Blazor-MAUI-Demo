using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace BlazorDemo.Shared.Data.DataProviders
{
    [Guid("DD279962-7EC6-494E-8C8E-416C9065D64D")]
    public interface IIssuesDataProvider : IDataProvider
    {
        Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default);
        Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default);
        Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default);
    }

    public class IssuesDataProvider : EntityDataProvider<IssuesContext>, IIssuesDataProvider
    {
        public IssuesDataProvider(IDbContextFactory<IssuesContext> contextFactory, IConfiguration configuration) : base(contextFactory, configuration) { }

        public async Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default)
        {
            return await LoadDataAsync<Issue>("Issues", ct);
        }
        public async Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default)
        {
            return await LoadDataAsync<Project>("Projects", ct);
        }
        public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default)
        {
            return await LoadDataAsync<User>("Users", ct);
        }
    }
}
