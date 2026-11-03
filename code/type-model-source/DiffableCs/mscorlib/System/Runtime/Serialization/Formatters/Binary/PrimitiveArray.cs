namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000438")]
internal sealed class PrimitiveArray
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001178")]
	private InternalPrimitiveTypeE code; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001179")]
	private Boolean[] booleanA; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400117A")]
	private Char[] charA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400117B")]
	private Double[] doubleA; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400117C")]
	private Int16[] int16A; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400117D")]
	private Int32[] int32A; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400117E")]
	private Int64[] int64A; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400117F")]
	private SByte[] sbyteA; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001180")]
	private Single[] singleA; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001181")]
	private UInt16[] uint16A; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001182")]
	private UInt32[] uint32A; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001183")]
	private UInt64[] uint64A; //Field offset: 0x68

	[Address(RVA = "0x1F3A270", Offset = "0x1F39670", Length = "0x3D")]
	[Token(Token = "0x6002002")]
	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	[Address(RVA = "0x1F398B0", Offset = "0x1F38CB0", Length = "0x57C")]
	[Token(Token = "0x6002003")]
	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	[Address(RVA = "0x1F39E70", Offset = "0x1F39270", Length = "0x3BC")]
	[Token(Token = "0x6002004")]
	internal void SetValue(string value, int index) { }

}

