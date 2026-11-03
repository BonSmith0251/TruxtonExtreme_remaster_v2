namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000435")]
internal sealed class ValueFixup
{
	[Token(Token = "0x4001164")]
	internal static MemberInfo valueInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400115F")]
	internal ValueFixupEnum valueFixupEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001160")]
	internal Array arrayObj; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001161")]
	internal Int32[] indexMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001162")]
	internal object header; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001163")]
	internal object memberObject; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001165")]
	internal ReadObjectInfo objectInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001166")]
	internal string memberName; //Field offset: 0x40

	[Address(RVA = "0x1F43C90", Offset = "0x1F43090", Length = "0x55")]
	[Token(Token = "0x6001FF9")]
	internal ValueFixup(Array arrayObj, Int32[] indexMap) { }

	[Address(RVA = "0x1F43CF0", Offset = "0x1F430F0", Length = "0x72")]
	[Token(Token = "0x6001FFA")]
	internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	[Address(RVA = "0x1F43950", Offset = "0x1F42D50", Length = "0x330")]
	[Token(Token = "0x6001FFB")]
	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

