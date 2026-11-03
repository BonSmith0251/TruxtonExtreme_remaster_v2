namespace UnityEngine.Rendering;

[NativeClass("BatchMeshID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000399")]
public struct BatchMeshID : IEquatable<BatchMeshID>
{
	[Token(Token = "0x4000AD6")]
	public static readonly BatchMeshID Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD7")]
	public uint value; //Field offset: 0x0

	[Address(RVA = "0x3098740", Offset = "0x3097B40", Length = "0x39")]
	[Token(Token = "0x6001CE5")]
	private static BatchMeshID() { }

	[Address(RVA = "0x30986A0", Offset = "0x3097AA0", Length = "0x97")]
	[Token(Token = "0x6001CE2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6001CE3")]
	public override bool Equals(BatchMeshID other) { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x6001CE1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3098780", Offset = "0x3097B80", Length = "0x4F")]
	[Token(Token = "0x6001CE4")]
	public static bool op_Equality(BatchMeshID a, BatchMeshID b) { }

}

