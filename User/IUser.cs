using Tripharma.Core.User;
using Tripharma.Core.Utility;

namespace Tripharma.Application.User
{
    public interface IUserDetail
    {
        Task<PagedResponse<UserDetail>> GetPagedAsync(int pageNumber, int pageSize);
        Task<PagedResponse<UserDetail>> GetPagedForOwnerAsync(string? ownerSubject, long? ownerNumericId, int pageNumber, int pageSize);
        Task<UserDetail?> GetForOwnerAsync(string? ownerSubject, long? ownerNumericId);
        Task<UserDetail?> GetByIdAsync(string id);
        Task<UserDetail?> GetByIdForOwnerAsync(string id, string? ownerSubject, long? ownerNumericId);
        Task<UserDetail> CreateAsync(UserDetail user);
        Task<UserDetail> CreateAsync(UserDetail user, string? ownerSubject, long? ownerNumericId);
        Task<bool> UpdateAsync(UserDetail user);
        Task<bool> UpdateAsync(UserDetail user, string? ownerSubject, long? ownerNumericId);
        Task<bool> DeleteAsync(string id);
        Task<bool> DeleteAsync(string id, string? ownerSubject, long? ownerNumericId);
    }
}
