namespace UnityEngine.Rendering;

[NativeClass("BatchID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000397")]
public struct BatchID : IEquatable<BatchID>
{
	[Token(Token = "0x4000AD2")]
	public static readonly BatchID Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD3")]
	public uint value; //Field offset: 0x0

	[Address(RVA = "0x3098530", Offset = "0x3097930", Length = "0x39")]
	[Token(Token = "0x6001CDB")]
	private static BatchID() { }

	[Address(RVA = "0x3098490", Offset = "0x3097890", Length = "0x97")]
	[Token(Token = "0x6001CD9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6001CDA")]
	public override bool Equals(BatchID other) { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x6001CD8")]
	public virtual int GetHashCode() { }

}

