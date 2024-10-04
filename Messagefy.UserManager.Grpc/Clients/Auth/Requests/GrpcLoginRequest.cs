using ProtoBuf;

namespace Messagefy.UserManager.Grpc.Clients.Auth.Requests;

[ProtoContract]
public class GrpcLoginRequest
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public string Password { get; set; }
}