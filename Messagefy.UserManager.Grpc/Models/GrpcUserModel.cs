using ProtoBuf;

namespace Messagefy.UserManager.Grpc.Models;

[ProtoContract]
public class GrpcUserModel
{
    [ProtoMember(1)]
    public Guid Id { get; set; }

    [ProtoMember(2)]
    public string FirstName { get; set; }

    [ProtoMember(3)]
    public string LastName { get; set; }

    [ProtoMember(4)]
    public int CreatedAt { get; set; }
}