namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000639")]
internal struct MatchResultInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001765")]
	public readonly bool success; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001766")]
	public readonly PseudoStates triggerPseudoMask; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001767")]
	public readonly PseudoStates dependencyPseudoMask; //Field offset: 0x8

	[Address(RVA = "0x334F0F0", Offset = "0x334E4F0", Length = "0xB")]
	[Token(Token = "0x6002C60")]
	public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }

}

