namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000412")]
internal sealed class BinaryObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001012")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001013")]
	internal int mapId; //Field offset: 0x14

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EA5")]
	internal BinaryObject() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EA9")]
	public void Dump() { }

	[Address(RVA = "0x1F178E0", Offset = "0x1F16CE0", Length = "0x3F")]
	[Token(Token = "0x6001EA8")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F194F0", Offset = "0x1F188F0", Length = "0x8")]
	[Token(Token = "0x6001EA6")]
	internal void Set(int objectId, int mapId) { }

	[Address(RVA = "0x1F19500", Offset = "0x1F18900", Length = "0x81")]
	[Token(Token = "0x6001EA7")]
	public override void Write(__BinaryWriter sout) { }

}

