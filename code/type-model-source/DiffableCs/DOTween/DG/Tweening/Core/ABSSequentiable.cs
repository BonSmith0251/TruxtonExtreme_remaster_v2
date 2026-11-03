namespace DG.Tweening.Core;

[Token(Token = "0x200009E")]
public abstract class ABSSequentiable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BE")]
	internal TweenType tweenType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001BF")]
	internal float sequencedPosition; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C0")]
	internal float sequencedEndPosition; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C1")]
	internal TweenCallback onStart; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60003AB")]
	protected ABSSequentiable() { }

}

