using Grpc.Core;
using grpc_csharp_helloworld;

namespace grpc_csharp_helloworld.Services;

public class UserManagerService : UserManager.UserManagerBase
{
    private readonly ILogger<UserManagerService> _logger;
    public UserManagerService(ILogger<UserManagerService> logger)
    {
        _logger = logger;
    }

    public override Task<ListUserResponse> ListUser(ListUserRequest request, ServerCallContext context) {
        return Task.FromResult(new ListUserResponse
        {
            // Users = null
        });
    }
}
