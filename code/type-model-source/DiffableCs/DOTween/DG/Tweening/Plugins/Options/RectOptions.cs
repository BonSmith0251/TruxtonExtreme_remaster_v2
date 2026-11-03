namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x200008E")]
public struct RectOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000184")]
	public bool snapping; //Field offset: 0x0

	[Address(RVA = "0x665340", Offset = "0x664740", Length = "0x4")]
	[Token(Token = "0x600035F")]
	public override void Reset() { }

}

