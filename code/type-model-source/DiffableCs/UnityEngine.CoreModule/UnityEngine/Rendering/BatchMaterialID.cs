namespace UnityEngine.Rendering;

[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000398")]
public struct BatchMaterialID : IEquatable<BatchMaterialID>
{
	[Token(Token = "0x4000AD4")]
	public static readonly BatchMaterialID Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AD5")]
	public uint value; //Field offset: 0x0

	[Address(RVA = "0x3098610", Offset = "0x3097A10", Length = "0x39")]
	[Token(Token = "0x6001CE0")]
	private static BatchMaterialID() { }

	[Address(RVA = "0x3098570", Offset = "0x3097970", Length = "0x97")]
	[Token(Token = "0x6001CDD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6001CDE")]
	public override bool Equals(BatchMaterialID other) { }

	[Address(RVA = "0x2FF3D00", Offset = "0x2FF3100", Length = "0x9")]
	[Token(Token = "0x6001CDC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3098650", Offset = "0x3097A50", Length = "0x4F")]
	[Token(Token = "0x6001CDF")]
	public static bool op_Equality(BatchMaterialID a, BatchMaterialID b) { }

}

