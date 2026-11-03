namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200042F")]
internal sealed class __BinaryParser
{
	[Token(Token = "0x4001120")]
	private static Encoding encoding; //Field offset: 0x0
	[Token(Token = "0x400112C")]
	internal static MessageEnd messageEnd; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001114")]
	internal ObjectReader objectReader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001115")]
	internal Stream input; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001116")]
	internal long topId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001117")]
	internal long headerId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001118")]
	internal SizedArray objectMapIdTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001119")]
	internal SizedArray assemIdToAssemblyTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400111A")]
	internal SerStack stack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400111B")]
	internal BinaryTypeEnum expectedType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400111C")]
	internal object expectedTypeInformation; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400111D")]
	internal ParseRecord PRS; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400111E")]
	private BinaryAssemblyInfo systemAssemblyInfo; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400111F")]
	private BinaryReader dataReader; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001121")]
	private SerStack opPool; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001122")]
	private BinaryObject binaryObject; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001123")]
	private BinaryObjectWithMap bowm; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001124")]
	private BinaryObjectWithMapTyped bowmt; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001125")]
	internal BinaryObjectString objectString; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001126")]
	internal BinaryCrossAppDomainString crossAppDomainString; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001127")]
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001128")]
	private Byte[] byteBuffer; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001129")]
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400112A")]
	internal MemberReference memberReference; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400112B")]
	internal ObjectNull objectNull; //Field offset: 0xC0

	[Token(Token = "0x170003E7")]
	internal SizedArray AssemIdToAssemblyTable
	{
		[Address(RVA = "0x1F49BE0", Offset = "0x1F48FE0", Length = "0xCB")]
		[Token(Token = "0x6001FB2")]
		internal get { } //Length: 203
	}

	[Token(Token = "0x170003E6")]
	internal SizedArray ObjectMapIdTable
	{
		[Address(RVA = "0x1F49CB0", Offset = "0x1F490B0", Length = "0xCB")]
		[Token(Token = "0x6001FB1")]
		internal get { } //Length: 203
	}

	[Token(Token = "0x170003E8")]
	internal ParseRecord prs
	{
		[Address(RVA = "0x1F49E50", Offset = "0x1F49250", Length = "0x17E")]
		[Token(Token = "0x6001FB3")]
		internal get { } //Length: 382
	}

	[Token(Token = "0x170003E5")]
	internal BinaryAssemblyInfo SystemAssemblyInfo
	{
		[Address(RVA = "0x1F49D80", Offset = "0x1F49180", Length = "0xC1")]
		[Token(Token = "0x6001FB0")]
		internal get { } //Length: 193
	}

	[Address(RVA = "0x1F49A30", Offset = "0x1F48E30", Length = "0x79")]
	[Token(Token = "0x6001FDD")]
	private static __BinaryParser() { }

	[Address(RVA = "0x1F49AB0", Offset = "0x1F48EB0", Length = "0x130")]
	[Token(Token = "0x6001FAF")]
	internal __BinaryParser(Stream stream, ObjectReader objectReader) { }

	[Address(RVA = "0x1F49BE0", Offset = "0x1F48FE0", Length = "0xCB")]
	[Token(Token = "0x6001FB2")]
	internal SizedArray get_AssemIdToAssemblyTable() { }

	[Address(RVA = "0x1F49CB0", Offset = "0x1F490B0", Length = "0xCB")]
	[Token(Token = "0x6001FB1")]
	internal SizedArray get_ObjectMapIdTable() { }

	[Address(RVA = "0x1F49E50", Offset = "0x1F49250", Length = "0x17E")]
	[Token(Token = "0x6001FB3")]
	internal ParseRecord get_prs() { }

	[Address(RVA = "0x1F49D80", Offset = "0x1F49180", Length = "0xC1")]
	[Token(Token = "0x6001FB0")]
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	[Address(RVA = "0x1F44810", Offset = "0x1F43C10", Length = "0xA2")]
	[Token(Token = "0x6001FDB")]
	private ObjectProgress GetOp() { }

	[Address(RVA = "0x1F448C0", Offset = "0x1F43CC0", Length = "0x9E")]
	[Token(Token = "0x6001FDC")]
	private void PutOp(ObjectProgress op) { }

	[Address(RVA = "0x1F44C70", Offset = "0x1F44070", Length = "0x70C")]
	[Token(Token = "0x6001FD4")]
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F44960", Offset = "0x1F43D60", Length = "0x304")]
	[Token(Token = "0x6001FD5")]
	private void ReadArrayAsBytes(ParseRecord pr) { }

	[Address(RVA = "0x1F453A0", Offset = "0x1F447A0", Length = "0x288")]
	[Token(Token = "0x6001FCB")]
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001FB5")]
	internal void ReadBegin() { }

	[Address(RVA = "0x1F45630", Offset = "0x1F44A30", Length = "0x2A")]
	[Token(Token = "0x6001FB7")]
	internal bool ReadBoolean() { }

	[Address(RVA = "0x1F45660", Offset = "0x1F44A60", Length = "0x2A")]
	[Token(Token = "0x6001FB8")]
	internal byte ReadByte() { }

	[Address(RVA = "0x1F456C0", Offset = "0x1F44AC0", Length = "0x90")]
	[Token(Token = "0x6001FBA")]
	internal void ReadBytes(Byte[] byteA, int offset, int size) { }

	[Address(RVA = "0x1F45690", Offset = "0x1F44A90", Length = "0x2A")]
	[Token(Token = "0x6001FB9")]
	internal Byte[] ReadBytes(int length) { }

	[Address(RVA = "0x1F45760", Offset = "0x1F44B60", Length = "0x2A")]
	[Token(Token = "0x6001FBB")]
	internal char ReadChar() { }

	[Address(RVA = "0x1F45790", Offset = "0x1F44B90", Length = "0x2A")]
	[Token(Token = "0x6001FBC")]
	internal Char[] ReadChars(int length) { }

	[Address(RVA = "0x1F457C0", Offset = "0x1F44BC0", Length = "0x1DF")]
	[Token(Token = "0x6001FCD")]
	internal void ReadCrossAppDomainMap() { }

	[Address(RVA = "0x1F459A0", Offset = "0x1F44DA0", Length = "0x6D")]
	[Token(Token = "0x6001FC6")]
	internal DateTime ReadDateTime() { }

	[Address(RVA = "0x1F45A10", Offset = "0x1F44E10", Length = "0xC1")]
	[Token(Token = "0x6001FBD")]
	internal decimal ReadDecimal() { }

	[Address(RVA = "0x1F45AE0", Offset = "0x1F44EE0", Length = "0x2A")]
	[Token(Token = "0x6001FBF")]
	internal double ReadDouble() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001FB6")]
	internal void ReadEnd() { }

	[Address(RVA = "0x1F45B10", Offset = "0x1F44F10", Length = "0x2A")]
	[Token(Token = "0x6001FC0")]
	internal short ReadInt16() { }

	[Address(RVA = "0x1F45B40", Offset = "0x1F44F40", Length = "0x2A")]
	[Token(Token = "0x6001FC1")]
	internal int ReadInt32() { }

	[Address(RVA = "0x1F45B70", Offset = "0x1F44F70", Length = "0x2A")]
	[Token(Token = "0x6001FC2")]
	internal long ReadInt64() { }

	[Address(RVA = "0x1F45BA0", Offset = "0x1F44FA0", Length = "0x621")]
	[Token(Token = "0x6001FD3")]
	private void ReadMemberPrimitiveTyped() { }

	[Address(RVA = "0x1F461D0", Offset = "0x1F455D0", Length = "0x563")]
	[Token(Token = "0x6001FD6")]
	private void ReadMemberPrimitiveUnTyped() { }

	[Address(RVA = "0x1F46740", Offset = "0x1F45B40", Length = "0x3B0")]
	[Token(Token = "0x6001FD7")]
	private void ReadMemberReference() { }

	[Address(RVA = "0x1F46B00", Offset = "0x1F45F00", Length = "0x1A9")]
	[Token(Token = "0x6001FD9")]
	private void ReadMessageEnd() { }

	[Address(RVA = "0x1F487E0", Offset = "0x1F47BE0", Length = "0x53E")]
	[Token(Token = "0x6001FCC")]
	private void ReadObject() { }

	[Address(RVA = "0x1F46CB0", Offset = "0x1F460B0", Length = "0x37A")]
	[Token(Token = "0x6001FD8")]
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F47030", Offset = "0x1F46430", Length = "0xA07")]
	[Token(Token = "0x6001FD2")]
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F48150", Offset = "0x1F47550", Length = "0xC9")]
	[Token(Token = "0x6001FCE")]
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F48220", Offset = "0x1F47620", Length = "0x5BA")]
	[Token(Token = "0x6001FCF")]
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	[Address(RVA = "0x1F47B00", Offset = "0x1F46F00", Length = "0x648")]
	[Token(Token = "0x6001FD1")]
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	[Address(RVA = "0x1F47A40", Offset = "0x1F46E40", Length = "0xB6")]
	[Token(Token = "0x6001FD0")]
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1F45660", Offset = "0x1F44A60", Length = "0x2A")]
	[Token(Token = "0x6001FC3")]
	internal sbyte ReadSByte() { }

	[Address(RVA = "0x1F48D20", Offset = "0x1F48120", Length = "0xB6")]
	[Token(Token = "0x6001FCA")]
	internal void ReadSerializationHeaderRecord() { }

	[Address(RVA = "0x1F48DE0", Offset = "0x1F481E0", Length = "0x2A")]
	[Token(Token = "0x6001FBE")]
	internal float ReadSingle() { }

	[Address(RVA = "0x1F48E10", Offset = "0x1F48210", Length = "0x2A")]
	[Token(Token = "0x6001FC4")]
	internal string ReadString() { }

	[Address(RVA = "0x1F45B70", Offset = "0x1F44F70", Length = "0x2A")]
	[Token(Token = "0x6001FC5")]
	internal TimeSpan ReadTimeSpan() { }

	[Address(RVA = "0x1F48E40", Offset = "0x1F48240", Length = "0x2A")]
	[Token(Token = "0x6001FC7")]
	internal ushort ReadUInt16() { }

	[Address(RVA = "0x1F48E70", Offset = "0x1F48270", Length = "0x2A")]
	[Token(Token = "0x6001FC8")]
	internal uint ReadUInt32() { }

	[Address(RVA = "0x1F48EA0", Offset = "0x1F482A0", Length = "0x2A")]
	[Token(Token = "0x6001FC9")]
	internal ulong ReadUInt64() { }

	[Address(RVA = "0x1F48ED0", Offset = "0x1F482D0", Length = "0x530")]
	[Token(Token = "0x6001FDA")]
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x1F49440", Offset = "0x1F48840", Length = "0x598")]
	[Token(Token = "0x6001FB4")]
	internal void Run() { }

}

