namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000410")]
internal sealed class BinaryAssembly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400100E")]
	internal int assemId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400100F")]
	internal string assemblyString; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001E9D")]
	internal BinaryAssembly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001EA1")]
	public void Dump() { }

	[Address(RVA = "0x1F167B0", Offset = "0x1F15BB0", Length = "0x4B")]
	[Token(Token = "0x6001EA0")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1F16800", Offset = "0x1F15C00", Length = "0x13")]
	[Token(Token = "0x6001E9E")]
	internal void Set(int assemId, string assemblyString) { }

	[Address(RVA = "0x1F16820", Offset = "0x1F15C20", Length = "0x82")]
	[Token(Token = "0x6001E9F")]
	public override void Write(__BinaryWriter sout) { }

}

