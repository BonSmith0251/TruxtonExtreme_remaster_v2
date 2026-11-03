namespace System.Reflection;

[CLSCompliant(False)]
[Token(Token = "0x20004F5")]
public sealed class Pointer : ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001394")]
	private readonly Void* _ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001395")]
	private readonly Type _ptrType; //Field offset: 0x18

	[Address(RVA = "0x1F62A50", Offset = "0x1F61E50", Length = "0x42")]
	[Token(Token = "0x60022B9")]
	private Pointer(Void* ptr, Type ptrType) { }

	[Address(RVA = "0x1F62840", Offset = "0x1F61C40", Length = "0x1C8")]
	[Token(Token = "0x60022BA")]
	public static object Box(Void* ptr, Type type) { }

	[Address(RVA = "0x1F62A10", Offset = "0x1F61E10", Length = "0x3E")]
	[Token(Token = "0x60022BB")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

