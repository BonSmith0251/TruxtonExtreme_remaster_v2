namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000021")]
internal class Join
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000070")]
	internal OutPt OutPt1; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000071")]
	internal OutPt OutPt2; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000072")]
	internal IntPoint OffPt; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600003D")]
	public Join() { }

}

