using Messagefy.UserManager.Grpc.Clients.Auth.Requests;
using Messagefy.UserManager.Grpc.Clients.Auth.Responses;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Messagefy.UserManager.Grpc.Clients.Auth;

[Service("GrpcAuthService")]
public interface IGrpcAuthClient
{
    Task<GrpcLoginResponse> LoginAsync(GrpcLoginRequest request, CallContext context = default);
}