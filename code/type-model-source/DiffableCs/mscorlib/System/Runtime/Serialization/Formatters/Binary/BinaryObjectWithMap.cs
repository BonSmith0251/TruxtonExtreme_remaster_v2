namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000419")]
internal sealed class BinaryObjectWithMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400102A")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400102B")]
	internal int objectId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400102C")]
	internal string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400102D")]
	internal int numMembers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400102E")]
	internal String[] memberNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400102F")]
	internal int assemId; //Field offset: 0x30

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EC1")]
	internal BinaryObjectWithMap() { }

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6001EC2")]
	internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EC6")]
	public void Dump() { }

	[Address(RVA = "0x1F19220", Offset = "0x1F18620", Length = "0x122")]
	[Token(Token = "0x6001EC5")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F19350", Offset = "0x1F18750", Length = "0x57")]
	[Token(Token = "0x6001EC3")]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, int assemId) { }

	[Address(RVA = "0x1F193B0", Offset = "0x1F187B0", Length = "0x13F")]
	[Token(Token = "0x6001EC4")]
	public override void Write(__BinaryWriter sout) { }

}

