using ProtoBuf;

namespace Messagefy.UserManager.Grpc.Clients.Auth.Requests;

[ProtoContract]
public class GrpcRegisterRequest
{
    [ProtoMember(1)]
    public string FirstName { get; set; }

    [ProtoMember(2)]
    public string? LastName { get; set; }

    [ProtoMember(3)]
    public string? Password { get; set; }
}