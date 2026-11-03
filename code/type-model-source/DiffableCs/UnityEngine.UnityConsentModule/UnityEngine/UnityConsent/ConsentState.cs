namespace UnityEngine.UnityConsent;

[Token(Token = "0x2000002")]
public struct ConsentState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	public ConsentStatus AdsIntent; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000002")]
	public ConsentStatus AnalyticsIntent; //Field offset: 0x4

	[Address(RVA = "0x30D7E90", Offset = "0x30D7290", Length = "0x6")]
	[Token(Token = "0x6000001")]
	public ConsentState() { }

	[Address(RVA = "0x3479AE0", Offset = "0x3478EE0", Length = "0x20D")]
	[Token(Token = "0x6000002")]
	public virtual string ToString() { }

}

