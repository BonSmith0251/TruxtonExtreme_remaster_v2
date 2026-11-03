namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041A")]
internal sealed class BinaryObjectWithMapTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001030")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001031")]
	internal int objectId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001032")]
	internal string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001033")]
	internal int numMembers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001034")]
	internal String[] memberNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001035")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001036")]
	internal Object[] typeInformationA; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001037")]
	internal Int32[] memberAssemIds; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001038")]
	internal int assemId; //Field offset: 0x48

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EC7")]
	internal BinaryObjectWithMapTyped() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6001EC8")]
	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F18C50", Offset = "0x1F18050", Length = "0x30A")]
	[Token(Token = "0x6001ECB")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F18F60", Offset = "0x1F18360", Length = "0x9A")]
	[Token(Token = "0x6001EC9")]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, int assemId) { }

	[Address(RVA = "0x1F19000", Offset = "0x1F18400", Length = "0x217")]
	[Token(Token = "0x6001ECA")]
	public override void Write(__BinaryWriter sout) { }

}

