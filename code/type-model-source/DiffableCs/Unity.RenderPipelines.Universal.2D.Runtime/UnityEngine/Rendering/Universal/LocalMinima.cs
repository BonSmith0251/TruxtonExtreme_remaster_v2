namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200001C")]
internal class LocalMinima
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005C")]
	internal long Y; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005D")]
	internal TEdge LeftBound; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005E")]
	internal TEdge RightBound; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005F")]
	internal LocalMinima Next; //Field offset: 0x28

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000038")]
	public LocalMinima() { }

}

