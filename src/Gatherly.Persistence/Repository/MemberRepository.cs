using Gatherly.Domain.Entities;
using Gatherly.Domain.Repositories;

namespace Gatherly.Persistence.Repository;

public sealed class MemberRepository : IMemberRepository
{
    public async Task<Member?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;

        return null;
    }

    public void Add(Member member)
    {
    }
}