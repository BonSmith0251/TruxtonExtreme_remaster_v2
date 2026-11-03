namespace DG.Tweening.Plugins;

[Token(Token = "0x2000071")]
public struct CircleOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000151")]
	public float endValueDegrees; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000152")]
	public bool relativeCenter; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000153")]
	public bool snapping; //Field offset: 0x5
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000154")]
	internal Vector2 center; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000155")]
	internal float radius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000156")]
	internal float startValueDegrees; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000157")]
	internal bool initialized; //Field offset: 0x18

	[Address(RVA = "0x647800", Offset = "0x646C00", Length = "0x12D")]
	[Token(Token = "0x60002A7")]
	public void Initialize(Vector2 startValue, Vector2 endValue) { }

	[Address(RVA = "0x647930", Offset = "0x646D30", Length = "0x10")]
	[Token(Token = "0x60002A6")]
	public override void Reset() { }

}

