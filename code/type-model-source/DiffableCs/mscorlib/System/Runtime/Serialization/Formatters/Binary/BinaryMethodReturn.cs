namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000414")]
internal sealed class BinaryMethodReturn
{
	[Token(Token = "0x4001022")]
	private static object instanceOfVoid; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101B")]
	private object returnValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400101C")]
	private Object[] args; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400101D")]
	private object callContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400101E")]
	private Type[] argTypes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400101F")]
	private bool bArgsPrimitive; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001020")]
	private MessageEnum messageEnum; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001021")]
	private Type returnType; //Field offset: 0x38

	[Address(RVA = "0x1F18AF0", Offset = "0x1F17EF0", Length = "0xB2")]
	[Token(Token = "0x6001EAD")]
	private static BinaryMethodReturn() { }

	[Address(RVA = "0x1F18BB0", Offset = "0x1F17FB0", Length = "0xB")]
	[Token(Token = "0x6001EAE")]
	internal BinaryMethodReturn() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EB0")]
	public void Dump() { }

	[Address(RVA = "0x1F18810", Offset = "0x1F17C10", Length = "0x2DC")]
	[Token(Token = "0x6001EAF")]
	public override void Write(__BinaryWriter sout) { }

}

