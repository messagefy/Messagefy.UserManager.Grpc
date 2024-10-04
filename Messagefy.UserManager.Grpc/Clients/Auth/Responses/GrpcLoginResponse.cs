using Messagefy.UserManager.Grpc.Models;
using ProtoBuf;

namespace Messagefy.UserManager.Grpc.Clients.Auth.Responses;

[ProtoContract]
public class GrpcLoginResponse
{
    [ProtoMember(1)]
    public GrpcUserModel? User { get; set; }
}