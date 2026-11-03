namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200041B")]
internal sealed class BinaryArray
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001039")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400103A")]
	internal int rank; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400103B")]
	internal Int32[] lengthA; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400103C")]
	internal Int32[] lowerBoundA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400103D")]
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400103E")]
	internal object typeInformation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400103F")]
	internal int assemId; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001040")]
	private BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001041")]
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; //Field offset: 0x40

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001ECC")]
	internal BinaryArray() { }

	[Address(RVA = "0x1F16650", Offset = "0x1F15A50", Length = "0x24")]
	[Token(Token = "0x6001ECD")]
	internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F15CD0", Offset = "0x1F150D0", Length = "0x528")]
	[Token(Token = "0x6001ED0")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F16220", Offset = "0x1F15620", Length = "0xC0")]
	[Token(Token = "0x6001ECE")]
	internal void Set(int objectId, int rank, Int32[] lengthA, Int32[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	[Address(RVA = "0x1F162E0", Offset = "0x1F156E0", Length = "0x367")]
	[Token(Token = "0x6001ECF")]
	public override void Write(__BinaryWriter sout) { }

}

