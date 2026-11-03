namespace DG.Tweening.Core;

[Token(Token = "0x20000B3")]
internal class TweenLink
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000216")]
	public readonly GameObject target; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000217")]
	public readonly LinkBehaviour behaviour; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000218")]
	public bool lastSeenActive; //Field offset: 0x1C

	[Address(RVA = "0x6750D0", Offset = "0x6744D0", Length = "0x59")]
	[Token(Token = "0x6000418")]
	public TweenLink(GameObject target, LinkBehaviour behaviour) { }

}

