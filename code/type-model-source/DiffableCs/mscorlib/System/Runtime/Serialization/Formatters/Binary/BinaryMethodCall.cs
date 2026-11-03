namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000413")]
internal sealed class BinaryMethodCall
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001014")]
	private string methodName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001015")]
	private string typeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001016")]
	private Object[] args; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001017")]
	private object callContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001018")]
	private Type[] argTypes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001019")]
	private bool bArgsPrimitive; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400101A")]
	private MessageEnum messageEnum; //Field offset: 0x3C

	[Address(RVA = "0x1F18800", Offset = "0x1F17C00", Length = "0xB")]
	[Token(Token = "0x6001EAC")]
	public BinaryMethodCall() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EAB")]
	internal void Dump() { }

	[Address(RVA = "0x1F18460", Offset = "0x1F17860", Length = "0x39C")]
	[Token(Token = "0x6001EAA")]
	internal void Write(__BinaryWriter sout) { }

}

