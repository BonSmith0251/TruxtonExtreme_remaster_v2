namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200001D")]
internal class Scanbeam
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000060")]
	internal long Y; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000061")]
	internal Scanbeam Next; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000039")]
	public Scanbeam() { }

}

