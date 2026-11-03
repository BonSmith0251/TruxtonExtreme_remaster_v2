namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000415")]
internal sealed class BinaryObjectString
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001023")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001024")]
	internal string value; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001EB1")]
	internal BinaryObjectString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EB5")]
	public void Dump() { }

	[Address(RVA = "0x1F167B0", Offset = "0x1F15BB0", Length = "0x4B")]
	[Token(Token = "0x6001EB4")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F16800", Offset = "0x1F15C00", Length = "0x13")]
	[Token(Token = "0x6001EB2")]
	internal void Set(int objectId, string value) { }

	[Address(RVA = "0x1F18BC0", Offset = "0x1F17FC0", Length = "0x82")]
	[Token(Token = "0x6001EB3")]
	public override void Write(__BinaryWriter sout) { }

}

